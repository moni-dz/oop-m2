using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_m2
{
    public partial class Form3 : Form
    {
        private string selectedMovie;
        private string selectedDate;
        private string selectedTime;
        private BitArray aSeats, bSeats, cSeats, dSeats, eSeats, fSeats;
        private BitArray aSeatsMod, bSeatsMod, cSeatsMod, dSeatsMod, eSeatsMod, fSeatsMod;
        private CheckBox[] aRow, bRow, cRow, dRow, eRow, fRow;
        private const int seatCost = 150;

        private int BitArrayToInt(BitArray a)
        {
            var result = new int[1];
            a.CopyTo(result, 0);
            return result[0];
        }

        public Form3(string movie, string date, string time)
        {
            InitializeComponent();
            
            selectedMovie = movie;
            selectedDate = date;
            selectedTime = time;
            aRow = new[] { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18 };
            bRow = new[] { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, b16, b17, b18 };
            cRow = new[] { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18 };
            dRow = new[] { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18 };
            eRow = new[] { e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15, e16, e17, e18 };
            fRow = new[] { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16, f17, f18 };

            aSeatsMod = new BitArray(18);
            bSeatsMod = new BitArray(18);
            cSeatsMod = new BitArray(18);
            dSeatsMod = new BitArray(18);
            eSeatsMod = new BitArray(18);
            fSeatsMod = new BitArray(18);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aCombined = BitArrayToInt(aSeats.Or(aSeatsMod));
            var bCombined = BitArrayToInt(bSeats.Or(bSeatsMod));
            var cCombined = BitArrayToInt(cSeats.Or(cSeatsMod));
            var dCombined = BitArrayToInt(dSeats.Or(dSeatsMod));
            var eCombined = BitArrayToInt(eSeats.Or(eSeatsMod));
            var fCombined = BitArrayToInt(fSeats.Or(fSeatsMod));

            var conn = DatabaseConnection.Instance.Connection;
            const string updateQuery = "update Movies set a_seats=@1, b_seats=@2, c_seats=@3, d_seats=@4, e_seats@=@5, f_seats=@6 where name=@7, time=@8, date=@9";
            var command = new SqlCommand(updateQuery, conn);
            command.Parameters.AddWithValue("@1", aCombined);
            command.Parameters.AddWithValue("@2", bCombined);
            command.Parameters.AddWithValue("@3", cCombined);
            command.Parameters.AddWithValue("@4", dCombined);
            command.Parameters.AddWithValue("@5", eCombined);
            command.Parameters.AddWithValue("@6", fCombined);
            command.Parameters.AddWithValue("@7", selectedMovie);
            command.Parameters.AddWithValue("@8", selectedTime);
            command.Parameters.AddWithValue("@9", selectedDate);
            command.ExecuteNonQuery();
            
            var form4 = new Form4(selectedMovie, selectedDate, selectedTime);
            form4.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Hide();
        }

        private void Seats_OnCheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox cBox)) return;
            
            var aIdx = Array.IndexOf(aRow, cBox);
            var bIdx = Array.IndexOf(bRow, cBox);
            var cIdx = Array.IndexOf(cRow, cBox);
            var dIdx = Array.IndexOf(dRow, cBox);
            var eIdx = Array.IndexOf(eRow, cBox);
            var fIdx = Array.IndexOf(fRow, cBox);

            if (aIdx != -1) aSeatsMod[aIdx] = cBox.Checked;
            if (bIdx != -1) bSeatsMod[bIdx] = cBox.Checked;
            if (cIdx != -1) cSeatsMod[cIdx] = cBox.Checked;
            if (dIdx != -1) dSeatsMod[dIdx] = cBox.Checked;
            if (eIdx != -1) eSeatsMod[eIdx] = cBox.Checked;
            if (fIdx != -1) fSeatsMod[fIdx] = cBox.Checked;
            
            if (cBox.Checked)
            {
                if (aIdx != -1) textBox1.AppendText($"A{aIdx + 1},");
                if (bIdx != -1) textBox1.AppendText($"B{bIdx + 1},");
                if (cIdx != -1) textBox1.AppendText($"C{cIdx + 1},");
                if (dIdx != -1) textBox1.AppendText($"D{dIdx + 1},");
                if (eIdx != -1) textBox1.AppendText($"E{eIdx + 1},");
                if (fIdx != -1) textBox1.AppendText($"F{fIdx + 1},");
            }
            else
            {
                textBox1.Text = Regex.Replace(textBox1.Text, $"A{aIdx + 1},", "");
                textBox1.Text = Regex.Replace(textBox1.Text, $"B{bIdx + 1},", "");
                textBox1.Text = Regex.Replace(textBox1.Text, $"C{cIdx + 1},", "");
                textBox1.Text = Regex.Replace(textBox1.Text, $"D{dIdx + 1},", "");
                textBox1.Text = Regex.Replace(textBox1.Text, $"E{eIdx + 1},", "");
                textBox1.Text = Regex.Replace(textBox1.Text, $"F{fIdx + 1},", "");
            }
            
            var aCount = aSeatsMod.Cast<bool>().Count(b => b);
            var bCount = bSeatsMod.Cast<bool>().Count(b => b);
            var cCount = cSeatsMod.Cast<bool>().Count(b => b);
            var dCount = dSeatsMod.Cast<bool>().Count(b => b);
            var eCount = eSeatsMod.Cast<bool>().Count(b => b);
            var fCount = fSeatsMod.Cast<bool>().Count(b => b);
            var totalCount = aCount + bCount + cCount + dCount + eCount + fCount;
            
            textBox2.Text = totalCount.ToString();
            label4.Text = $@"{totalCount * seatCost}";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var conn = DatabaseConnection.Instance.Connection;
            const string seatsQuery =
                "select a_seats, b_seats, c_seats, d_seats, e_seats from Movies where name=@1, time=@2, date=@3";
            var command = new SqlCommand(seatsQuery, conn);
            command.Parameters.AddWithValue("@1", selectedMovie);
            command.Parameters.AddWithValue("@2", selectedDate);
            command.Parameters.AddWithValue("@3", selectedTime);

            using (var sda = new SqlDataAdapter(command))
            using (var dt = new DataTable())
            {
                sda.Fill(dt);
                int SeatDataFor(string seats) => dt.AsEnumerable().Select(row => row.Field<int>(seats)).ToArray()[0];
                aSeats = new BitArray(new []{ SeatDataFor("a_seats") });
                bSeats = new BitArray(new []{ SeatDataFor("b_seats") });
                cSeats = new BitArray(new []{ SeatDataFor("c_seats") });
                dSeats = new BitArray(new []{ SeatDataFor("d_seats") });
                eSeats = new BitArray(new []{ SeatDataFor("e_seats") });
                fSeats = new BitArray(new []{ SeatDataFor("f_seats") });
            }

            for (var i = 0; i < 18; i++)
            {
                aRow[i].CheckState = aSeats[i] ? CheckState.Checked : CheckState.Unchecked;
                bRow[i].CheckState = bSeats[i] ? CheckState.Checked : CheckState.Unchecked;
                cRow[i].CheckState = cSeats[i] ? CheckState.Checked : CheckState.Unchecked;
                dRow[i].CheckState = dSeats[i] ? CheckState.Checked : CheckState.Unchecked;
                eRow[i].CheckState = eSeats[i] ? CheckState.Checked : CheckState.Unchecked;
                fRow[i].CheckState = fSeats[i] ? CheckState.Checked : CheckState.Unchecked;
                aRow[i].Enabled = !aSeats[i];
                bRow[i].Enabled = !bSeats[i];
                cRow[i].Enabled = !cSeats[i];
                dRow[i].Enabled = !dSeats[i];
                eRow[i].Enabled = !eSeats[i];
                fRow[i].Enabled = !fSeats[i];
                aRow[i].CheckStateChanged += Seats_OnCheckedChanged;
                bRow[i].CheckStateChanged += Seats_OnCheckedChanged;
                cRow[i].CheckStateChanged += Seats_OnCheckedChanged;
                dRow[i].CheckStateChanged += Seats_OnCheckedChanged;
                eRow[i].CheckStateChanged += Seats_OnCheckedChanged;
                fRow[i].CheckStateChanged += Seats_OnCheckedChanged;
            }
        }
    }
}
