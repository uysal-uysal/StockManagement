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
    public partial class category : Form
    {
        public category()
        {
            InitializeComponent();
        }

        private void category_Load(object sender, EventArgs e)
        {
           
        }
        mainPage mainPage = new mainPage();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            mainPage.productType = "bread";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            mainPage.productType = "drinks";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            mainPage.productType = "fruits";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            mainPage.productType = "vegetables";
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            mainPage.productType = "menswear";
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            mainPage.productType = "womenswear";
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            mainPage.productType = "tools";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
