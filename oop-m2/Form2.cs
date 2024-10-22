using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_m2
{
    public partial class Form2 : Form
    {
        private List<string> _movieNames = new List<string>();
        private List<string> _movieTimes = new List<string>();
        private List<string> _movieDates = new List<string>();
        
        public Form2()
        {
            InitializeComponent();
            LoadComboBoxData(); 

            cmbMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTime.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadComboBoxData()
        {
            // default selections 
            //cmbMovie.SelectedIndex = 0;
            //cmbDate.SelectedIndex = 0;
            //cmbTime.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedMovie = cmbMovie.SelectedItem.ToString();
            var selectedDate = cmbDate.SelectedItem.ToString();
            var selectedTime = cmbTime.SelectedItem.ToString();

            Form3 form3 = new Form3(
                selectedMovie,
                selectedDate,
                selectedTime);
            form3.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void movie_Click(object sender, EventArgs e)
        {
        }

        private void time_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var conn = DatabaseConnection.Instance.Connection;
            const string firstSchedQuery = "select name, time, date from Movies where date='2024-05-05'";
            const string secondSchedQuery = "select name, time, date from Movies where date='2024-05-15'";

            using (var sda = new SqlDataAdapter(firstSchedQuery, conn))
            {
                using (var dt = new DataTable())
                {
                    sda.Fill(dt);
                    dataGridView3.DataSource = dt;
                }
                
                using (var command = new SqlCommand(firstSchedQuery, conn))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        _movieNames.Add(reader["name"].ToString());
                        _movieTimes.Add(reader["time"].ToString());
                        _movieDates.Add(reader["date"].ToString());
                    }
                }
            }


            using (var sda = new SqlDataAdapter(secondSchedQuery, conn))
            {
                using (var dt = new DataTable())
                {
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                
                using (var command = new SqlCommand(secondSchedQuery, conn))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        _movieNames.Add(reader["name"].ToString());
                        _movieTimes.Add(reader["time"].ToString());
                        _movieDates.Add(reader["date"].ToString());                    
                    }
                }
            }
            
            _movieNames = _movieNames.Distinct().ToList();
            _movieTimes = _movieTimes.Distinct().ToList();
            _movieDates = _movieDates.Distinct().ToList();
            
            foreach (var m in _movieNames) cmbMovie.Items.Add(m);
            foreach (var t in _movieTimes) cmbTime.Items.Add(t);
            foreach (var d in _movieDates) cmbDate.Items.Add(d.Split(' ')[0]);
        }
    }
}
