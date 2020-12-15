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
            prdTable.DataSource = database.ListDatas(mainPage.productType).Tables[0];//listele
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {

            string selectedCell = prdTable.SelectedRows[0].Cells[0].Value.ToString();

            string query = $"DELETE FROM {mainPage.productType} WHERE id = '{selectedCell}'";
            database.Delete(query);
            prdTable.DataSource = database.ListDatas(mainPage.productType).Tables[0];//listele
        }
    }
}
