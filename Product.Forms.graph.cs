using DevExpress.XtraCharts;
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
    public partial class graph : Form
    {
        public graph()
        {
            InitializeComponent();
        }


        DB database = new DB();
        mainPage mainpage = new mainPage();

        int pieceProduct = 0;//count products at this category and this warehouse 
        int productSort = 0;//count all products at this category
        string productType;



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        string[] category = { "bread", "drinks", "fruits", "menswear", "womenswear", "vegetables", "tools" };

        private void categoryGraph()
        {
            //graph by category

            chartControl.Series.Clear();

            foreach (var item in category)
            {
                Series series = new Series(item, ViewType.Bar);
                chartControl.Series.Add(series);

                checkByCategory(mainPage.graphStore, item);

                chartControl.Series[item].Points.Add(new DevExpress.XtraCharts.SeriesPoint(item.ToString(), pieceProduct));

            }
        }


        private void productGraph()
        {
            //graph by product at this category

            chartControl.Series.Clear();
            countProduct(mainPage.graphStore, productType);

            List<String> names = new List<String>();
            List<int> stocks = new List<int>();


            string nameQuery = $"SELECT name FROM {productType} WHERE warehouse = {mainPage.graphStore}";
            string stockQuery = $"SELECT stock FROM {productType} WHERE warehouse = {mainPage.graphStore}";

            for (int i = 0; i < productSort; i++)
            {
               
                MySqlDataReader readName = database.Reader(nameQuery);
                MySqlDataReader readStock = database.Reader(stockQuery);

                try
                {
                    while (readName.Read())
                    {
                        names.Add(readName[0].ToString());
                    }

                    while (readStock.Read())
                    {
                        stocks.Add(int.Parse(readStock[0].ToString()));
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

            for (int i = 0; i < productSort; i++)
            {
                Series series = new Series(names[i], ViewType.Bar);
                chartControl.Series.Add(series);

                chartControl.Series[names[i]].Points.Add(new SeriesPoint(names[i].ToString(), stocks[i]));
            }
        }


        private void countProduct(int stockroom, string product)
        {
            //count product at this warehouse
            //etc--> count breads at warehouse1
            string query = $"SELECT count(id) as kontrol FROM {product} WHERE warehouse = {stockroom}";
            MySqlDataReader reader = database.Reader(query);

            try
            {
                while (reader.Read())
                {
                    productSort = int.Parse(reader[0].ToString());
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


        private void checkByCategory(int stockroom, string product)
        {
            //calculate overall stock at this category

            pieceProduct = 0;
            string checkProduct = $"SELECT stock FROM {product} WHERE warehouse={stockroom}";
            MySqlDataReader reader = database.Reader(checkProduct);

            try
            {
                while (reader.Read())
                {
                    pieceProduct += int.Parse(reader[0].ToString());
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
    

        private void byCategory_Click(object sender, EventArgs e)
        {
            categoryGraph();
        }


        private void byProduct_Click(object sender, EventArgs e)
        {
            chartControl.Series.Clear();

            sortButton1.Visible = true;
            sortButton2.Visible = true;
            sortButton3.Visible = true;
            sortButton4.Visible = true;
            sortButton5.Visible = true;
            sortButton6.Visible = true;
            sortButton7.Visible = true;
        }

        private void sortButton1_Click(object sender, EventArgs e)
        {
            productType = "drinks";
            productGraph();
        }


        private void sortButton2_Click(object sender, EventArgs e)
        {
            productType = "tools";
            productGraph();

        }


        private void sortButton3_Click(object sender, EventArgs e)
        {
            productType = "bread";
            productGraph();

        }


        private void sortButton4_Click(object sender, EventArgs e)
        {
            productType = "vegetables";
            productGraph();

        }


        private void sortButton5_Click(object sender, EventArgs e)
        {
            productType = "menswear";
            productGraph();

        }


        private void sortButton6_Click(object sender, EventArgs e)
        {
            productType = "womenswear";
            productGraph();

        }


        private void sortButton7_Click(object sender, EventArgs e)
        {
            productType = "fruits";
            productGraph();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
