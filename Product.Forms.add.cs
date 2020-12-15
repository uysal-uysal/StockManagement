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

        private void addPrdButton_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO {mainPage.productType} (id,name,stock) " +
                           $"VALUES ('{int.Parse(idTxt.Text)}','{nameTxt.Text}','{int.Parse(stockTxt.Text)}')";
            database.ExecuteQuery(query);
            this.Hide();
        }
    }
}
