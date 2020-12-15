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
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
            productTable.DataSource = database.ListDatas(mainPage.productType).Tables[0];//list
        }

        DB database = new DB();
        mainPage main = new mainPage();

        private void reduceButton_Click(object sender, EventArgs e)
        {
            string selectedCell = productTable.SelectedRows[0].Cells[0].Value.ToString();
            string query = $"UPDATE {mainPage.productType} SET stock = stock - '{x}' WHERE id= '{selectedCell}'";
            database.ExecuteQuery(query);
            productTable.DataSource = database.ListDatas(mainPage.productType).Tables[0];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string selectedCell = productTable.SelectedRows[0].Cells[0].Value.ToString();
            string query = $"UPDATE {mainPage.productType} SET stock = stock + '{x}' WHERE id= '{selectedCell}'";
            database.ExecuteQuery(query);
            productTable.DataSource = database.ListDatas(mainPage.productType).Tables[0];
        }


        //TODO 
        //outofstock 
        //user logs

        public int x;
        public void txtPiece_TextChanged(object sender, EventArgs e)
        {
            string piece = txtPiece.Text;
            x = Int32.Parse(piece);
        }
        private void txtPiece_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addPrdButton_Click(object sender, EventArgs e)
        {
            addPrd prd = new addPrd();
            prd.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            productTable.DataSource = database.ListDatas(mainPage.productType).Tables[0];//listele
        }
    }
}
