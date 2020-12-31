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
using DevExpress.LookAndFeel;
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
            draw();

        }

        public bool checkStockroom(int id)
        {
            string query = $"SELECT count(id) as kontrol FROM stockroom WHERE id = {id}";
            MySqlDataReader reader = database.Reader(query);

            try
            {
                while (reader.Read())
                {
                    if (int.Parse(reader[0].ToString()) == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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
            return false;
        }


        public void draw()
        {
            addStr.count();

            SimpleButton[] graphBar = new SimpleButton[4];
            graphBar[0]= simpleButton1;
            graphBar[1]= simpleButton2;
            graphBar[2]= simpleButton3;
            graphBar[3]= simpleButton4;

            Button[] stockroomButtons = new Button[4];
            stockroomButtons[0] = stockroomBtn1;
            stockroomButtons[1] = stockroomBtn2;
            stockroomButtons[2] = stockroomBtn3;
            stockroomButtons[3] = stockroomBtn4;


            for (int i = 0; i < 4; i++)
            {
                if (checkStockroom(i+1))
                {

                    graphBar[i].LookAndFeel.Style = LookAndFeelStyle.Flat;
                    graphBar[i].LookAndFeel.UseDefaultLookAndFeel = false;
                    graphBar[i].Appearance.Options.UseBackColor = true;

                    stockroomButtons[i].Visible = true;
                    graphBar[i].Visible = true;

                    stockroomButtons[i].Text = setName(i + 1);
                    checkCurrentCapacity(i + 1);
                    graphBar[i].Text = setName(i + 1) + " - " + currentCapacity.ToString(); ;
                    graphBar[i].Width = 50 + (int.Parse(currentCapacity.ToString()) * 3);

                }
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
        public static int graphStore;

        public static int totalCapacity = 0;
        public static int currentCapacity = 0;


        private void stockroomBtn1_Click(object sender, EventArgs e)
        {
            store = "1";
            productPanel.Visible = true;
            productTable.DataSource = null;
            deleteStockroom.Visible = true;
            updateCapacity();
        }


        private void stockroomBtn2_Click(object sender, EventArgs e)
        {
            store = "2";
            productPanel.Visible = true;
            productTable.DataSource = null;
            deleteStockroom.Visible = true;
            updateCapacity();
        }


        private void stockroomBtn3_Click(object sender, EventArgs e)
        {
            store = "3";
            productPanel.Visible = true;
            productTable.DataSource = null;
            deleteStockroom.Visible = true;
            updateCapacity();
        }


        private void stockroomBtn4_Click(object sender, EventArgs e)
        {
            store = "4";
            productPanel.Visible = true;
            productTable.DataSource = null;
            deleteStockroom.Visible = true;
            updateCapacity();
        }


        private void addStockroom_Click(object sender, EventArgs e)
        {
            if (loginpage.IsAdmin())
            {
                addStr addStocroom = new addStr();
                addStocroom.Show();
            }
            else
            {
                MessageBox.Show("You cant add new Stockroom!");
            }
        }


        private void deleteStockroom_Click(object sender, EventArgs e)
        {
            //refresh combobox
            cmbDeleteStockroom.DataSource = null;
            cmbDeleteStockroom.Items.Clear();


            if (addStr.countStockroom >= 1)
            {
                if (loginpage.IsAdmin())
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (checkStockroom(i + 1))
                        {
                            cmbDeleteStockroom.Items.Add(setName(i + 1).ToString());
                        }
                    }
                    cmbDeleteStockroom.SelectedIndex = 0;
                    pnlConfirmDelete.Visible = true;
                    lblConfirm.Text = "DELETE-DELETE " + cmbDeleteStockroom.SelectedItem.ToString();

                }
                else
                {
                    MessageBox.Show("You cant delete Stockroom!");
                }
            }
            else
            {
                MessageBox.Show("Couldnt find any Stockroom!");
            }
        }


        private void cmbDeleteStockroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblConfirm.Text = "DELETE-DELETE " + cmbDeleteStockroom.SelectedItem.ToString();
        }


        private void btnDeleteStockroom_Click(object sender, EventArgs e)
        {

            Button[] stockroomButtons = new Button[4];
            stockroomButtons[0] = stockroomBtn1;
            stockroomButtons[1] = stockroomBtn2;
            stockroomButtons[2] = stockroomBtn3;
            stockroomButtons[3] = stockroomBtn4;

            SimpleButton[] graphButtons = new SimpleButton[4];
            graphButtons[0] = simpleButton1;
            graphButtons[1] = simpleButton2;
            graphButtons[2] = simpleButton3;
            graphButtons[3] = simpleButton4;

            string[] category = { "bread", "drinks", "fruits", "menswear", "womenswear", "vegetables", "tools" };

            if (txtConfirm.Text.Equals(lblConfirm.Text))
            {
                //check confirmation text

                string deleteStr = $"DELETE FROM stockroom WHERE name = '{cmbDeleteStockroom.SelectedItem.ToString()}'";
                //delete stockroom at db

                foreach (var item in category)
                {
                    string deletePrd = $"DELETE FROM {item} WHERE warehouse = {store}";
                    //delete products from db where-> at this warehouse 

                    try
                    {
                        database.ExecuteQuery(deletePrd);
                        database.ExecuteQuery(deleteStr);
                       
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
                    }
                    finally
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (stockroomButtons[i].Text.ToString().Equals(cmbDeleteStockroom.SelectedItem.ToString()))
                            {
                                stockroomButtons[i].Visible = false;
                                graphButtons[i].Visible = false;
                            }
                        }
                        pnlConfirmDelete.Visible = false;
                        deleteStockroom.Visible = false;
                        productPanel.Visible = false;
                        database.Disconnect();
                        txtConfirm.Clear();
                        updateCapacity();
                        draw();
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong!");
            }

        }


        public void refreshBtn_Click(object sender, EventArgs e)
        {
            draw();
        }


        public string setName(int id)
        {
            //set buttons and graph buttons name
            string query = $"SELECT name FROM stockroom WHERE id={id}";
            MySqlDataReader reader = database.Reader(query);
            string name = "";
            while (reader.Read())
            {
                name = reader[0].ToString();
            }
            database.Disconnect();
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
            stt = false;
            //mean of stt--> if true, user admin
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
                MessageBox.Show("You cant delete any user!");
            }
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
                    deletePrd deletePrd = new deletePrd();
                    deletePrd.Show();
                }
            }
            else
            {
                MessageBox.Show("You cant delete any product!");
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
            refreshTable.Visible = true;
            productTable.DataSource = database.ListDatas(mainPage.productType, mainPage.store).Tables[0];
            database.Disconnect();
        }


        private void prdValue_TextChanged(object sender, EventArgs e)
        {
            //only can type number

            try
            {
                value = Int32.Parse(prdValue.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        
        private void prdValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only type number at increase/reduce textbox

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

            checkTotalCapacity(int.Parse(store));
            checkCurrentCapacity(int.Parse(store));

            try
            {
                if (currentCapacity + value <= totalCapacity)
                {
                    //if capacity is enough

                    database.ExecuteQuery(query);
                    updateCapacity();
                    draw();
                    productTable.DataSource = database.ListDatas(mainPage.productType, mainPage.store).Tables[0];
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
            finally
            {
                database.Disconnect();
            }
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
                    updateCapacity();
                    draw();
                    productTable.DataSource = database.ListDatas(mainPage.productType, mainPage.store).Tables[0];
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
            finally
            {
                database.Disconnect();
            }
        }


        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogRes = MessageBox.Show("Do you want to exit", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogRes == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }


       

       

        public void checkTotalCapacity(int stockroom)
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
            finally
            {
                database.Disconnect();
            }
        }


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
                finally
                {
                    database.Disconnect();
                }
            }
        }

       


        public void updateCapacity()
        {
            checkTotalCapacity(int.Parse(store));
            checkCurrentCapacity(int.Parse(store));
            lblCapacity.Text = currentCapacity.ToString() + " / " + totalCapacity.ToString();
        }

        private void refreshTable_Click(object sender, EventArgs e)
        {
            try
            {
                updateCapacity();
                productTable.DataSource = database.ListDatas(mainPage.productType, mainPage.store).Tables[0];
            }
            catch (Exception err)
            {
                MessageBox.Show("err" + MessageBox.Show(err.Message) + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
            finally
            {
                draw();
                database.Disconnect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            graphStore = 1;
            graph graph = new graph();
            graph.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            graphStore = 2;
            graph graph = new graph();
            graph.Show();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            graphStore = 3;
            graph graph = new graph();
            graph.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            graphStore = 4;
            graph graph = new graph();
            graph.Show();
        }
    }
}
