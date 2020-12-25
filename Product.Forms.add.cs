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
    public partial class addPrd : Form
    {

        public addPrd()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        DB database = new DB();
        mainPage mainpage = new mainPage();

        private void addPrdButton_Click(object sender, EventArgs e)
        {
            //check this id is already exist at warehouse?
            string checkId = $"SELECT count(warehouse) as kontrol FROM {mainPage.productType} WHERE id = {int.Parse(txtId.Text)} AND warehouse = {mainPage.store}";
            MySqlDataReader reader = database.Reader(checkId);
            mainpage.checkTotalCapacity(int.Parse(mainPage.store));
            mainpage.checkCurrentCapacity(int.Parse(mainPage.store));

            try
            {
                while (reader.Read())
                {
                    if (reader[0].ToString() != "1")
                    {
                        if (mainPage.currentCapacity + int.Parse(txtStock.Text) <= mainPage.totalCapacity)
                        {
                            string query = $"INSERT INTO {mainPage.productType} (id,name,stock,warehouse) " +
                                      $"VALUES ('{int.Parse(txtId.Text)}','{txtName.Text}','{int.Parse(txtStock.Text)}','{mainPage.store}')";
                            database.ExecuteQuery(query);
                            mainpage.draw();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Not enough capacity");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Id already exist!");
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


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
