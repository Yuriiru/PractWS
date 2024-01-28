using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PractikSW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = textBox2.Text.ToString();
            string Password = textBox1.Text.ToString();
            SD.DataTable dt = new SD.DataTable();
            string PasswordZap = CreateMD5(Password);

            openConnection();
            string commandString = $"select Role from Authoriz where Login ='{Login}' and PaswordHash='{PasswordZap}'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt);
            try
            {
                string role = Convert.ToString(dt.Rows[0][0]);

                if (Check(Login, Password) == true)
                {
                    if (role == comboBox1.SelectedItem.ToString())
                    {
                        if (role == "Оператор")
                        {
                            MessageBox.Show("Успешна выполнена", "Авторизация");
                            GlavnoeW glavnoeW = new GlavnoeW();
                            glavnoeW.Show();
                        }
                        else if (role == "Админ")
                        {
                            
                        }
                        else if (role == "Абонент")
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выбрана неправильная роль", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка");
                }
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
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

        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private Boolean Check(string log, string pass)
        {
            SD.DataTable table = new SD.DataTable();
            string Login_l = log;
            string Password_p = pass;

            Password_p = CreateMD5(Password_p);

            string commandString = $"select Login, PaswordHash from Authoriz where Login='{Login_l}' and PaswordHash='{Password_p}'";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
