using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace StokOtomasyonu
{
    public partial class loginPage : Form
    {
       
        public loginPage()
        {
            InitializeComponent();
        }


        DB database = new DB();
        public static string username;


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        public bool IsAdmin()
        {
            string sqlStatusQuery = $"SELECT count(userStt) as kontrol FROM users WHERE username = '{username}' AND userStt = 'admin'";
            MySqlDataReader statusReader = database.StatusReader(sqlStatusQuery);

            while (statusReader.Read())
            {
                if (statusReader[0].ToString() == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            database.Disconnect();
            return false;
        }


        public void logButton_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;//set to global variable 'username'

            string query = $"SELECT count(username) as kontrol FROM users WHERE username = '{txtUsername.Text}' AND userPass = '{txtPass.Text}'";

            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) == true || string.IsNullOrWhiteSpace(txtPass.Text) == true)
                {
                    MessageBox.Show("Textfields cannot be null and must not contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlDataReader reader = database.Reader(query);
                    while (reader.Read())
                    {
                        if (reader[0].ToString() == "1")
                        {
                            this.Hide();
                            mainPage mainPage = new mainPage();
                            mainPage.Show();
                        }
                        else
                        {
                            MessageBox.Show("User not found");
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
            finally
            {
                database.Disconnect();
            }
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
