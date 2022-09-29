using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sqltest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //SqlTableData stb = new SqlTableData(160);
            //stb.Fill();
        }

        string connStr = "server=localhost;user=root;database=shp_uni;convert zero datetime=True";
        MySqlConnection conn = new MySqlConnection();
        //MySqlCommand sqlComm;
        //DataSet ds;

        private void connBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                MessageBox.Show("Подключение прошло успешно");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void connStatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("База данных подключена");
                }
                else
                {
                    MessageBox.Show("База данных не подключена");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void discBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                MessageBox.Show("Отключение прошло успешно");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = richTextBox1.Text;
                MySqlDataAdapter msda = new MySqlDataAdapter(query, connStr);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) 
            {
                try
                {
                    MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM client", connStr);
                    DataTable dt = new DataTable();
                    msda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                try
                {
                    MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM employees", connStr);
                    DataTable dt = new DataTable();
                    msda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 2) 
            {
                try
                {
                    MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM log", connStr);
                    DataTable dt = new DataTable();
                    msda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 3) 
            {
                try
                {
                    MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM product", connStr);
                    DataTable dt = new DataTable();
                    msda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 4) 
            {
                try
                {
                    MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM storage", connStr);
                    DataTable dt = new DataTable();
                    msda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { return; }
        }
    }
}
