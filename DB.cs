using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StokOtomasyonu
{
    class DB
    {
        MySqlConnection myConnection;

        public void Connection()
        {
            myConnection = new MySqlConnection("SERVER = localhost; ; DATABASE = otomasyon; UID = root; PWD = uysal");
            myConnection.Open();
        }


        public void Disconnect()
        {
            myConnection.Close();
        }


        public MySqlDataReader Reader(string query)
        {
            Connection();
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            return myReader;
        }


        public MySqlDataReader StatusReader(string query)
        {
            Connection();
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            return myReader;
        }

      
        public void ExecuteQuery(string query)
        {
            Connection();
            MySqlCommand command = new MySqlCommand(query, myConnection);
            command.ExecuteReader();
        }


        public DataSet ListDatas(string table)
        {
            Connection();
            string query = $"SELECT * FROM {table}";
            MySqlDataAdapter da = new MySqlDataAdapter(query,myConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public DataSet ListProducts(string table, string stockroom)
        {
            Connection();
            string query = $"SELECT * FROM {table} WHERE warehouse = {stockroom}";
            MySqlDataAdapter da = new MySqlDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}