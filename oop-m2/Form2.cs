using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_m2
{
    public partial class Form2 : Form
    {
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
            cmbMovie.Items.AddRange(new string[] { "Movie 1", "Movie 2" });

            cmbDate.Items.AddRange(new string[]
            {
                "05/05/2024", "05/25/2024"
            });

            cmbTime.Items.AddRange(new string[]
            {
                "10:00 AM - 12:00 PM",
                "12:00 PM - 02:00 PM",
                "02:00 PM - 04:00 PM",
                "04:00 PM - 06:00 PM"
            });

            // default selections 
            cmbMovie.SelectedIndex = 0;
            cmbDate.SelectedIndex = 0;
            cmbTime.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedMovie = cmbMovie.SelectedItem.ToString();
            string selectedDate = cmbDate.SelectedItem.ToString();
            string selectedTime = cmbTime.SelectedItem.ToString();

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
    }
}
