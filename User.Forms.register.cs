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
    public partial class regPage : Form
    {
        public regPage()
        {
            InitializeComponent();
        }


        DB database = new DB();
        mainPage main = new mainPage();


        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void regButton_Click(object sender, EventArgs e)
        {
            string _username = txtUsername.Text;
            string _userPass1 = txtPass1.Text;
            string _userPass2 = txtPass2.Text;
            string _userStt = "";

            if (mainPage.stt)
            {
                _userStt = "admin";// _userStt --> admin
            }
            else _userStt = "common";


            string query = $"INSERT INTO users VALUES('{_userStt}','{_username}','{_userPass1}')";
            string isAlreadyHave = $"SELECT count(username) as kontrol FROM users WHERE username = '{_username}'";

            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) == true || string.IsNullOrWhiteSpace(txtPass1.Text) == true || string.IsNullOrWhiteSpace(txtPass2.Text) == true)
                {
                    MessageBox.Show("Textfields cannot be null and must not contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlDataReader reader = database.Reader(isAlreadyHave);
                    if (_userPass1 != _userPass2)
                    {
                        MessageBox.Show("Passwords doesn't same!");
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == "1")
                            {
                                MessageBox.Show("User already registered!");
                            }
                            else
                            {
                                database.ExecuteQuery(query);
                                MessageBox.Show("User get registered!");
                                this.Hide();
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
