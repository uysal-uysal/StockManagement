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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            mainPage main = new mainPage();
            DB database = new DB();
            //verilerin alınması
            string _username = txtUsername.Text;
            string _userPass1 = txtPass1.Text;
            string _userPass2 = txtPass2.Text;
            string _userStt = "";

            if (mainPage.stt)
            {
                _userStt = "admin";//admin eklenecekse _userStt --> admin
            }
            else _userStt = "common";

            string query = $"INSERT INTO users VALUES('{_userStt}','{_username}','{_userPass1}')";

            //db'de böyle bir kullanıcı var mı yok mu sorgusu 
            string isAlreadyHave = $"SELECT count(username) as kontrol FROM users WHERE username = '{_username}' AND userPass = '{_userPass1}'";

            if (string.IsNullOrWhiteSpace(txtUsername.Text) == true || string.IsNullOrWhiteSpace(txtPass1.Text) == true || string.IsNullOrWhiteSpace(txtPass2.Text) == true)
            {
                MessageBox.Show("textfields cannot be null and must not contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlDataReader reader = database.Reader(isAlreadyHave);
                if (_userPass1 != _userPass2)
                {
                    MessageBox.Show("passwords doesn't same!");
                }
                while (reader.Read())
                {
                    if (reader[0].ToString() == "1")
                    {
                        MessageBox.Show("user already registered!");//db'de zaten böyle bir kullanıcı var
                        //TODO ayni isim farklı şifre girince kayıt ediyor, etmemeli
                    }
                    else
                    {
                        database.Add(query);
                        MessageBox.Show("user get registered!");
                        this.Hide();
                    }
                }
            }
        }
    }
}
