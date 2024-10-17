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
    public partial class Form3 : Form
    {
        private string selectedMovie;
        private string selectedDate;
        private string selectedTime;

        public Form3(string movie, string date, string time)
        {
            InitializeComponent();

            selectedMovie = movie;
            selectedDate = date;
            selectedTime = time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(selectedMovie, selectedDate, selectedTime);
            form4.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Hide();
        }
    }
}
