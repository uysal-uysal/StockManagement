using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace StokOtomasyonu
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();  
        }


        private void mainPage_Load(object sender, EventArgs e)
        {
            addStr.count();

            Button[] buttons = new Button[4];
            buttons[0] = stockroomBtn1;
            buttons[1] = stockroomBtn2;
            buttons[2] = stockroomBtn3;
            buttons[3] = stockroomBtn4;
            for (int i = 0; i < addStr.countStockroom; i++)
            {
                buttons[i].Visible = true;
                buttons[i].Text = setName(i+1);
            }
        }


        DB database = new DB();
        loginPage loginpage = new loginPage();
        addStr addStr = new addStr();
        deletePrd deletePrd;
        deleteUser deleteuser;


        public int value;
        public static bool stt = false;//new user is admin? stt-false -- > common
        public static string store;
        public static string productType;

      
        private void stockroomBtn1_Click(object sender, EventArgs e)
        {
            store= "1";
            panel2.Visible = true;
            productTable.DataSource = null;
            timer.Enabled = true;
        }


        private void stockroomBtn2_Click(object sender, EventArgs e)
        {
            store = "2";
            panel2.Visible = true;
            productTable.DataSource = null;
            timer.Enabled = true;
        }


        private void stockroomBtn3_Click(object sender, EventArgs e)
        {
            store = "3";
            panel2.Visible = true;
            productTable.DataSource = null;
            timer.Enabled = true;
        }


        private void stockroomBtn4_Click(object sender, EventArgs e)
        {
            store = "4";
            panel2.Visible = true;
            productTable.DataSource = null;
            timer.Enabled = true;
        }


        private void addStockroom_Click(object sender, EventArgs e)
        {
            addStr addStocroom = new addStr();
            addStocroom.Show();
        }


        public void refreshBtn_Click(object sender, EventArgs e)
        {
            mainPage_Load(null, EventArgs.Empty);
        }


        public string setName(int id)
        {
            string query = $"SELECT name FROM stockroom WHERE id={id}";
            MySqlDataReader reader = database.Reader(query);
            string name = "";
            while (reader.Read())
            {
                name = reader[0].ToString();
            }
            return name;
        }


        private void newUser_Click(object sender, EventArgs e)
        {
            addAdmin.Visible = true;
            addCommon.Visible = true;
        }


        private void addAdmin_Click(object sender, EventArgs e)
        {
            if (loginpage.IsAdmin())
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


        private void addCommon_Click(object sender, EventArgs e)
        {
            stt = false;//new user -- > common
            regPage register = new regPage();
            register.Show();
        }


        private void delUser_Click(object sender, EventArgs e)
        {
            if (loginpage.IsAdmin())
            {
                if (deleteuser == null || deleteuser.IsDisposed)
                {
                    deleteuser = new deleteUser();
                    deleteuser.Show();
                }
            }
            else
            {
                MessageBox.Show("you cant delete any user!");
            }
        }
        

        private void category_Click(object sender, EventArgs e)
        {
            category category = new category();
            category.Show();
        }


        private void addProduct_Click(object sender, EventArgs e)
        {
            addPrd addProduct = new addPrd();
            addProduct.Show();
        }


        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (loginpage.IsAdmin())
            {
                if (deletePrd == null || deletePrd.IsDisposed)
                {
                    deletePrd = new deletePrd();
                    deletePrd.Show();
                }
            }
            else
            {
                MessageBox.Show("you cant delete any product!");
            }
        }


        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            productType = categoryList.SelectedItem.ToString();
            addProduct.Visible = true;
            deleteProduct.Visible = true;
            productTable.Visible = true;
            increase.Visible = true;
            reduce.Visible = true;
            prdValue.Visible = true;
            productTable.DataSource = database.ListProducts(mainPage.productType, mainPage.store).Tables[0];
        }


        private void prdValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                value = Int32.Parse(prdValue.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }


        //only type number at increase/reduce textbox
        private void prdValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void increase_Click(object sender, EventArgs e)
        {
            //productTable.SelectedRows[0].Cells[0].Value.ToString() --> Selected rows stock
            string query = $"UPDATE {mainPage.productType} SET stock = stock + '{value}' " +
                           $"WHERE id= '{productTable.SelectedRows[0].Cells[0].Value.ToString()}' AND warehouse='{mainPage.store}'";

            checkCapacity(int.Parse(store));
            checkCurrentCapacity(int.Parse(store));

            try
            {
                if (mainPage.currentCapacity + value <= mainPage.totalCapacity)
                {
                    database.ExecuteQuery(query);
                }
                else
                {
                    MessageBox.Show("Not enough capacity!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
            productTable.DataSource = database.ListProducts(mainPage.productType, mainPage.store).Tables[0];
        }


        private void reduce_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE {mainPage.productType} SET stock = stock - '{value}' " +
                           $"WHERE id= '{productTable.SelectedRows[0].Cells[0].Value.ToString()}'AND warehouse='{mainPage.store}'";

            try
            {
                if (Int32.Parse(productTable.SelectedRows[0].Cells[2].Value.ToString()) > 0 && value <= Int32.Parse(productTable.SelectedRows[0].Cells[2].Value.ToString()))
                {
                    database.ExecuteQuery(query);
                }
                else
                {
                    MessageBox.Show("Stock cant be less than 0!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
           
            productTable.DataSource = database.ListProducts(mainPage.productType, mainPage.store).Tables[0];
        }


        //timer for slide effect 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.HorizontalScroll.Value >= 1222)
            {
                this.timer.Enabled = false;
            }
            else
            {
                int x = this.HorizontalScroll.Value + this.HorizontalScroll.SmallChange * 6;
                this.AutoScrollPosition = new Point(x, 0);
            }
        }


        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Do you want to exit", "Are you sure?", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }


        private void main_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Do you want to exit", "Are you sure?", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (x == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        public static int totalCapacity;
        public void checkCapacity(int stockroom)
        {
            string checkcapacity = $"SELECT capacity FROM stockroom WHERE id={stockroom}";
            MySqlDataReader reader = database.Reader(checkcapacity);

            try
            {
                while (reader.Read())
                {
                    totalCapacity = int.Parse(reader[0].ToString()); 
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
            database.Disconnect();
        }


        public static int currentCapacity = 0;
        public void checkCurrentCapacity(int stockroom)
        {
            currentCapacity = 0;
            string[] category = { "bread", "drinks", "fruits", "menswear","womenswear","vegetables","tools" };

            foreach (var item in category)
            {
                string checkcurrentcapacity = $"SELECT stock FROM {item} WHERE warehouse={stockroom}";
                MySqlDataReader reader = database.Reader(checkcurrentcapacity);

                try
                {
                    while (reader.Read())
                    {
                        currentCapacity += int.Parse(reader[0].ToString());
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
            }
            database.Disconnect();
        }
    }
}
