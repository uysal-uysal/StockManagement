using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace StokOtomasyonu
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();  
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        public static string productType;
        public static bool stt = false;//eklenecek kullanıcı admin mi, common mı? stt-false --> common

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)//admin ekleme
            {
            loginPage lp = new loginPage();
            if (lp.IsAdmin())//giriş yapmış olan kullanıcı admin mi?
            {
                stt = true;
                regPage register = new regPage();
                register.Show();
            }
            else
            {
                MessageBox.Show("only admins can add new admin!");
            }
        }

        private void commonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stt = false;//eklenecek kullanıcı admin değil
            regPage register = new regPage();
            register.Show();
        }

        deleteUser deleteuser;
        private void productRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();

            if (login.IsAdmin())
            {
                if (deleteuser == null || deleteuser.IsDisposed)
                {
                    deleteuser = new deleteUser();
                    if (login.IsAdmin()) //giriş yapmış olan kullanıcı admin mi?
                    {
                        deleteuser.Show();
                    }
                    else
                    {
                        MessageBox.Show("only admins can delete admin!");
                    }
                }
            }
            else
            {
                MessageBox.Show("you cant delete any user!");
            }
        }

        private void main_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("do you want to exit", "are you sure?", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Environment.Exit(0); 
            }
            else if (x == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("do you want to exit", "are you sure?", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            products urunler = new products();
            productType = "bread";
            urunler.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            products urunler = new products();
            productType = "drinks"; 
            urunler.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            products urunler = new products();
            productType = "fruits";
            urunler.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            products urunler = new products();
            productType = "vegetables";
            urunler.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            products urunler = new products();
            productType = "menswear";
            urunler.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            products urunler = new products();
            productType = "womenswear";
            urunler.Show();
        }


        deletePrd deletePrd;
        private void breadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deletePrd == null || deletePrd.IsDisposed)
            {
                deletePrd = new deletePrd();
                productType = "bread";
                deletePrd.Show();
            }
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deletePrd == null || deletePrd.IsDisposed)
            {
                deletePrd = new deletePrd();
                productType = "drinks";
                deletePrd.Show();
            }
        }

        private void fruitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deletePrd == null || deletePrd.IsDisposed)
            {
                deletePrd = new deletePrd();
                productType = "fruits";
                deletePrd.Show();
            }
        }

        private void vegetablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deletePrd == null || deletePrd.IsDisposed)
            {
                deletePrd = new deletePrd();
                productType = "vegetables";
                deletePrd.Show();
            }
        }

        private void menswearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deletePrd == null || deletePrd.IsDisposed)
            {
                deletePrd = new deletePrd();
                productType = "menswear";
                deletePrd.Show();
            }
        }

        private void womenswearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deletePrd == null || deletePrd.IsDisposed)
            {
                deletePrd = new deletePrd();
                productType = "womenswear";
                deletePrd.Show();
            }
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deletePrd == null || deletePrd.IsDisposed)
            {
                deletePrd = new deletePrd();
                productType = "tools";
                deletePrd.Show();
            }
        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SimpleButton simpleButton = new SimpleButton();
            simpleButton.Text = "new category";
            //simpleButton.ImageIndex = 0;
            simpleButton.Height = 200;
            simpleButton.Width = 205;
            simpleButton.Location = new Point(263, 511);
            simpleButton.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            bottomPanel.Controls.Add(simpleButton);
        }
    }
}
