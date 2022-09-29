using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace sqltest
{
    class SqlTableData
    {
        string connStr = "server=localhost;user=root;database=shp_uni;convert zero datetime=True";
        MySqlConnection conn;
        private int rowCount;

        public SqlTableData(int rowCount)
        {
            conn = new MySqlConnection(connStr);
            this.rowCount = rowCount;
        }

        public void Fill()
        {
            try
            {
                Random rnd = new Random();
                string queryClient = "SELECT Id FROM client ORDER BY RAND() LIMIT 1";
                string querySeller = "SELECT Id FROM employees ORDER BY RAND() LIMIT 1";
                string queryProduct = "SELECT Id FROM product ORDER BY RAND() LIMIT 1";
                int ClientId = 0, SellerId = 0, ProductId = 0, Quantity = 0;
                //DataTable dtClient = new DataTable(), dtSeller = new DataTable(), dtProduct = new DataTable();
                conn.Open();
                //MySqlDataAdapter msda = new MySqlDataAdapter(queryClient, connStr); msda.Fill(dtClient);
                //msda = new MySqlDataAdapter(querySeller, connStr); msda.Fill(dtSeller);
                //msda = new MySqlDataAdapter(queryProduct, connStr); msda.Fill(dtProduct);

                MySqlCommand cmClient, cmSeller, cmProduct, cmd;
                MySqlDataReader dr;
                for (int i = 0; i < rowCount; i++)
                {
                    cmClient = new MySqlCommand(queryClient, conn);
                    cmSeller = new MySqlCommand(querySeller, conn);
                    cmProduct = new MySqlCommand(queryProduct, conn);
                    dr = cmClient.ExecuteReader(); dr.Read();
                    ClientId = dr.GetInt32(0); dr.Close();
                    dr = cmSeller.ExecuteReader(); dr.Read();
                    SellerId = dr.GetInt32(0); dr.Close();
                    dr = cmProduct.ExecuteReader(); dr.Read();
                    ProductId = dr.GetInt32(0); dr.Close();
                    Quantity = rnd.Next(1, 5);
                    string query = $"INSERT INTO log VALUES({ClientId}, {SellerId}, {ProductId}, {Quantity}, 20220{rnd.Next(1, 9)}{rnd.Next(1, 30).ToString("00")}{rnd.Next(0, 23).ToString("00")}{rnd.Next(0, 60).ToString("00")}{rnd.Next(0, 60).ToString("00")});";
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            } 
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
