using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SD = System.Data;
using System.Data.SqlClient;

namespace PractikSW
{
    public partial class CRMForm : Form
    {
        public CRMForm()
        {
            InitializeComponent();
        }

       

        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-09DA1D0; Initial Catalog=program; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        public void openConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        SqlCommandBuilder commandBuilder;

        private void CRMForm_Load(object sender, EventArgs e)
        {
            openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Application", sqlConnection);

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            dataGridView1.DataSource = db.Tables[0];


            closeConnection();


        }

        


        private void Addbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ContainsSqlInjection(problemMoreBox.Text))
                {
                    throw new Exception("Ошибка: невозможно выполнить операцию из-за инъекции в параметре описания.");
                }

                string query = "INSERT INTO Application (id_application, DateCreation , SubscribersLogin , PersonalAccount , Services , TypeProblem, HistoryDescriptionProblem , ClosingDate ) " +
"VALUES (@id, @opendateTime, @login, @ls, @usl, @problem, @problemMore, @closeTimePicker)";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@id", idBox.Text);
                command.Parameters.AddWithValue("@opendateTime", opendateTime.Text);
                command.Parameters.AddWithValue("@login", loginBox.Text);
                command.Parameters.AddWithValue("@ls", lsBox.Text);
                command.Parameters.AddWithValue("@usl", uslBox.Text);
                command.Parameters.AddWithValue("@problem", problemBox.Text);
                command.Parameters.AddWithValue("@closeTimePicker", closeTimePicker.Text);
                command.Parameters.AddWithValue("@problemMore", problemMoreBox.Text);

                sqlConnection.Open();


                command.ExecuteNonQuery();
                sqlConnection.Close();

                
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

        }

        private void RefreshDataGridView()
        {
            string query = "SELECT * FROM Application";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

               

                if (row.Cells["ClosingDate"].Value.ToString() == "01.01.1900 0:00:00")
                {
                    idBox.Text = row.Cells["id_application"].Value.ToString();
                    opendateTime.Text = row.Cells["DateCreation"].Value.ToString();
                    loginBox.Text = row.Cells["SubscribersLogin"].Value.ToString();
                    lsBox.Text = row.Cells["PersonalAccount"].Value.ToString();
                    uslBox.Text = row.Cells["Services"].Value.ToString();
                    problemBox.Text = row.Cells["TypeProblem"].Value.ToString();
                    problemMoreBox.Text = row.Cells["HistoryDescriptionProblem"].Value.ToString();
                    closeTimePicker.Text = row.Cells["ClosingDate"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Нельзя изменить запись.");
                }

                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                    if (columnName == "HistoryDescriptionProblem")
                    {
                        string newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                        if (ContainsSqlInjection(newValue))
                        {
                            MessageBox.Show("Нельзя записывать SQL запросы в базу данных.");
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        }
                    }
                }
            }

        }

        private bool ContainsSqlInjection(string value)
        {
            
            string[] sqlKeywords = { "SELECT", "INSERT", "UPDATE", "DELETE", "DROP", "ALTER", "CREATE" };

            foreach (string keyword in sqlKeywords)
            {
                if (value.ToUpper().Contains(keyword))
                {
                    return true;
                }
            }

            return false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click_1(object sender, EventArgs e)
        {
            if (closeTimePicker.Text != "01.01.1900 0:00:00")
            {
                DialogResult result = MessageBox.Show("Дата закрытия верна?", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (ContainsSqlInjection(problemMoreBox.Text))
                    {
                        throw new Exception("Ошибка: невозможно выполнить операцию из-за инъекции в параметре описания.");
                    }

                    string query = "UPDATE Application SET DateCreation = @opendateTime, SubscribersLogin = @login, PersonalAccount  = @ls, Services  = @usl, TypeProblem  = @problem, HistoryDescriptionProblem  = @problemMore, ClosingDate  = @closeTimePicker WHERE id_application = @id";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@id", idBox.Text);
                    command.Parameters.AddWithValue("@opendateTime", opendateTime.Text);
                    command.Parameters.AddWithValue("@login", loginBox.Text);
                    command.Parameters.AddWithValue("@ls", lsBox.Text);
                    command.Parameters.AddWithValue("@usl", uslBox.Text);
                    command.Parameters.AddWithValue("@problem", problemBox.Text);
                    command.Parameters.AddWithValue("@closeTimePicker", closeTimePicker.Text);
                    command.Parameters.AddWithValue("@problemMore", problemMoreBox.Text);

                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();

                    
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Нельзя изменить запись с датой закрытия 01.01.1900");
            }


        }
    }
}







