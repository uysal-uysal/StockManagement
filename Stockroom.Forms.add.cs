using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public partial class addStr : Form
    {
        public addStr()
        {
            InitializeComponent();
        }

        DB database = new DB();
        public static int countStockroom;


        public void count()
        {
            string query = $"SELECT count(id) as kontrol FROM stockroom";
            MySqlDataReader reader = database.Reader(query);
            while (reader.Read())
            {
                countStockroom = int.Parse(reader[0].ToString());
            }
        }



        private void addBtn_Click(object sender, EventArgs e)
        {
            //check this stockroom is already exist?
            string checkId = $"SELECT count(id) as kontrol FROM stockroom WHERE id = {int.Parse(txtId.Text)} OR name = '{txtName.Text}'";
            MySqlDataReader reader = database.Reader(checkId);
            count();

            try
            {
                while (reader.Read())
                {
                    if (int.Parse(reader[0].ToString()) < 1 && countStockroom < 4)
                    {
                        string query = $"INSERT INTO stockroom (id,name,capacity) " +
                                       $"VALUES ('{int.Parse(txtId.Text)}','{txtName.Text}','{int.Parse(txtCapacity.Text)}')";
                        database.ExecuteQuery(query);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("This Stockroom already exist or you have reached max Stockroom (4)!");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
            database.Disconnect();
        }

       
        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
