using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace PractikSW
{
    public partial class GlavnoeW : Form
    {
        public GlavnoeW()
        {
            InitializeComponent();
        }

        private void CRM_Click(object sender, EventArgs e)
        {
            CRMForm cRMForm = new CRMForm();
            cRMForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SD.DataTable dt = new SD.DataTable();
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                string User_FIO = row.Cells["ФИО"].Value.ToString();
                string Personal_Account = row.Cells["Лицевой_счёт"].Value.ToString();
                // int Contract_Number = row.Cells["Номер_абонента"].Value.;
                int x = Int32.Parse(row.Cells["Номер_абонента"].Value.ToString());

                openConnection();
                string commandString = $"select Login from Support where FIO ='{User_FIO}' and PersonalAccount='{Personal_Account}'and PersonalAccount='{Personal_Account}'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dt);

                string Login = Convert.ToString(dt.Rows[0][0]);

               ApplicationW applicationW = new ApplicationW(Login);
               applicationW.Show();

                closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

      

        private void GlavnoeW_Load(object sender, EventArgs e)
        {
            openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT FIO as ФИО, ContractNumber as Номер_абонента ,PersonalAccount as Лицевой_счёт, Services as Услуги FROM Support", sqlConnection);

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            dataGridView1.DataSource = db.Tables[0];


            closeConnection();
        }
    }
}
