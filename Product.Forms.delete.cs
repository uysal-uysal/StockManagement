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
    public partial class deletePrd : Form
    {
        public deletePrd()
        {
            InitializeComponent();
        }


        DB database = new DB();


        private void Form1_Load(object sender, EventArgs e)
        {
            prdTable.DataSource = database.ListProducts(mainPage.productType, mainPage.store).Tables[0];// --> list datas to datagridview
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM {mainPage.productType} WHERE id = '{prdTable.SelectedRows[0].Cells[0].Value.ToString()}' AND warehouse = '{mainPage.store}'";

            try
            {
                database.ExecuteQuery(query);
            }
            catch (Exception err)
            {
                MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
            prdTable.DataSource = database.ListProducts(mainPage.productType, mainPage.store).Tables[0];
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
