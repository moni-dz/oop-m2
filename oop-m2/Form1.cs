using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_m2
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            var conn = DatabaseConnection.Instance.Connection;
            const string firstSchedQuery = "select name, time from Movies where date='2024-05-15'";
            const string secondSchedQuery = "select name, time from Movies where date='2024-05-25'";

            using (var sda = new SqlDataAdapter(firstSchedQuery, conn))
            using (var dt = new DataTable())
            {
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }

            using (var sda = new SqlDataAdapter(secondSchedQuery, conn))
            using (var dt = new DataTable())
            {
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) => Application.Exit();

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}