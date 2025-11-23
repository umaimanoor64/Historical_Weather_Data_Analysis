using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        string WeatherUpdate;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startDate = textBox1.Text;

            string dateFormat = "yyyy-MM-dd"; // Change the date format according to your requirement

            // Attempt to parse the input string into a DateTime object using the specified format
            if (!(DateTime.TryParseExact(startDate, dateFormat, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out _)))
            {
                MessageBox.Show("Invalid date format. Please enter date in the format yyyy-MM-dd.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                startDate = textBox1.Text;
            }
            string endDate = textBox2.Text;
            // Attempt to parse the input string into a DateTime object using the specified format
            if (!(DateTime.TryParseExact(endDate, dateFormat, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out _)))
            {
                MessageBox.Show("Invalid date format. Please enter date in the format yyyy-MM-dd.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                endDate = textBox2.Text;
            }
            string startTime = textBox3.Text;
            string timeFormat = "HH:mm"; // Change the time format according to your requirement

            // Attempt to parse the input string into a DateTime object using the specified format
            if (!(DateTime.TryParseExact(startTime, timeFormat, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out _)))
            {
                MessageBox.Show("Invalid time format. Please enter time in the format HH:mm.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                startTime = textBox3.Text;
            }
            string endTime = textBox4.Text;


            // Attempt to parse the input string into a DateTime object using the specified format
            if (!(DateTime.TryParseExact(endTime, timeFormat, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out _)))
            {
                MessageBox.Show("Invalid time format. Please enter time in the format HH:mm.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                endTime = textBox4.Text;
            }




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            WeatherUpdate = "Hourly";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            WeatherUpdate = "Daily";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            WeatherUpdate = "Weekly";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            WeatherUpdate = "Monthly";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}