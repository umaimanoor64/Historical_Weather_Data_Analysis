using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using check.Models;
using System.Timers;

namespace check
{
    public partial class Main : Form
    {
        public static Main instance;
        public string WeatherUpdate = "";
        public Main()
        {
            InitializeComponent();
            PopulateLocationComboBox();
            lbl_currentTime.Text = DateTime.Now.ToLongTimeString();
            lbl_currentDate.Text = DateTime.Now.ToLongDateString();
            this.TimePicker_startTime.Visible = false;
            this.TimePicker_endTime.Visible = false;
            this.lbl_startTime.Visible = false;
            this.lbl_endTime.Visible = false;
        }

        private void PopulateLocationComboBox()
        {
            locationComboBox.DataSource = GetLocation().ToList(); 
            locationComboBox.DisplayMember = "Value"; 
            locationComboBox.ValueMember = "Key";

            // Set default selected value
            if (locationComboBox.Items.Count > 0)
            {
                locationComboBox.SelectedIndex = 0;
            }
        }

        private Dictionary<int, string> GetLocation()
        {
            try
            {
                Dictionary<int, string> location = new Dictionary<int, string>();
                string query = @"SELECT LocationId, City FROM [dbo].[Location]";

                var connection = Configuration.getInstance().getConnection();
                SqlCommand command = new SqlCommand(query, connection);

                int default_id = Convert.ToInt32(0);
                string default_location = "Select Location";
                location.Add(default_id, default_location);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["LocationId"]);
                        string desg = reader["City"].ToString();
                        location.Add(id, desg);
                    }
                }
                return location;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_currentTime.Text = DateTime.Now.ToLongTimeString();
            lbl_currentDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbl_location_validation.Visible = false;
            lbl_datePicker_endDate_validation.Visible = false;
            lbl_datePicker_startDate_validation.Visible = false;
            lbl_startTime_validation.Visible = false;
            lbl_endTime_validation.Visible = false;
            lbl_radio_validation.Visible = false;
            if (locationComboBox.SelectedIndex <= 0 || datePicker_startDate.Value == null || datePicker_endDate.Value == null
                || TimePicker_startTime.Value == null || TimePicker_endTime.Value == null || WeatherUpdate == "")
            {
                if(locationComboBox.SelectedIndex <= 0)
                {
                    lbl_location_validation.Text = "Location is required";
                    lbl_location_validation.Visible = true;
                }
                if (datePicker_startDate.Value == null)
                {
                    lbl_datePicker_startDate_validation.Text = "Start date is required";
                    lbl_datePicker_startDate_validation.Visible = true;
                }
                if (datePicker_endDate.Value == null)
                {
                    lbl_datePicker_endDate_validation.Text = "End date is required";
                    lbl_datePicker_endDate_validation.Visible = true;
                }
                if (TimePicker_startTime.Value == null)
                {
                    lbl_startTime_validation.Text = "Start time is required";
                    lbl_startTime_validation.Visible = true;
                }
                if (TimePicker_endTime.Value == null)
                {
                    lbl_endTime_validation.Text = "End time is required";
                    lbl_endTime_validation.Visible = true;
                }
                if(WeatherUpdate == "")
                {
                    lbl_radio_validation.Text = "Select atleast one option";
                    lbl_radio_validation.Visible = true;
                }
                return;
            }
            else
            {
                if (WeatherUpdate == "Weekly")
                {
                    // Check if the selected date range is valid for one week
                    TimeSpan selectedDuration = datePicker_endDate.Value - datePicker_startDate.Value;
                    if (selectedDuration.TotalDays >= 7)
                    {
                        lbl_datePicker_endDate_validation.Text = "Please select a date range valid for one week.";
                        lbl_datePicker_endDate_validation.Visible = true;
                        return;
                    }
                }
                if (WeatherUpdate == "Monthly")
                {
                    // Check if the selected date range is valid for one week
                    TimeSpan selectedDuration = datePicker_endDate.Value - datePicker_startDate.Value;
                    if (selectedDuration.TotalDays >= 31)
                    {
                        lbl_datePicker_endDate_validation.Text = "Please select a date range valid for one month.";
                        lbl_datePicker_endDate_validation.Visible = true;
                        return;
                    }
                }
                if (datePicker_startDate.Value > datePicker_endDate.Value)
                {
                    lbl_datePicker_startDate_validation.Text = "Start date cannot be greater than end date.";
                    lbl_datePicker_startDate_validation.Visible = true;
                    return;
                }
                SearchWeatherData searchWeatherData = new SearchWeatherData();
                searchWeatherData.LocationId = Convert.ToInt32(locationComboBox.SelectedValue);
                searchWeatherData.LocationName = locationComboBox.Text;
                searchWeatherData.Periodicity = WeatherUpdate;
                searchWeatherData.StartDate = datePicker_startDate.Value;
                searchWeatherData.EndDate = datePicker_endDate.Value;
                searchWeatherData.StartTime = TimePicker_startTime.Value;
                searchWeatherData.EndTime = TimePicker_endTime.Value;

                Visualization form = new Visualization(searchWeatherData);
                form.Show();
                this.Hide();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            WeatherUpdate = "Hourly";
            this.TimePicker_startTime.Visible = true;
            this.TimePicker_endTime.Visible = true;
            this.lbl_startTime.Visible = true;
            this.lbl_endTime.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            WeatherUpdate = "Daily";
            this.TimePicker_startTime.Visible = false;
            this.TimePicker_endTime.Visible = false;
            this.lbl_startTime.Visible = false;
            this.lbl_endTime.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            WeatherUpdate = "Weekly";
            this.TimePicker_startTime.Visible = false;
            this.TimePicker_endTime.Visible = false;
            this.lbl_startTime.Visible = false;
            this.lbl_endTime.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            WeatherUpdate = "Monthly";
            this.TimePicker_startTime.Visible = false;
            this.TimePicker_endTime.Visible = false;
            this.lbl_startTime.Visible = false;
            this.lbl_endTime.Visible = false;
        }

    }
}
