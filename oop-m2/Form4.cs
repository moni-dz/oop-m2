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
    public partial class Form4 : Form
    {
        public Form4(string movie, string date, string time)
        {
            InitializeComponent();

            txtMovie.Text = movie;
            txtDateTime.Text = $"{date} / {time}";

            txtTicketMovie.Text = movie;
            txtTicketTime.Text = time;

            txtTicketDate.Text = date;  
        }

        public Form4()
        {
        }

        private void txtMovie_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtTicketDate_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDateTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTicketMovie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTicketDateTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
