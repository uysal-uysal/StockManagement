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

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }


        public static string username;
        public bool IsAdmin() //giriş yapan kullanıcı admin mi, değil mi?
        {
            DB database = new DB();
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
            DB database = new DB();

            username = txtUsername.Text;

            string sqlQuery = $"SELECT count(username) as kontrol FROM users WHERE username = '{txtUsername.Text}' AND userPass = '{txtPass.Text}'";
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) == true || string.IsNullOrWhiteSpace(txtPass.Text) == true)
                {
                    MessageBox.Show("textfields cannot be null and must not contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlDataReader reader = database.Reader(sqlQuery);
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
                            MessageBox.Show("user not found");
                        }
                    }
                    database.Disconnect();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
