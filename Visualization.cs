using check.Models;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace check
{
    public partial class Visualization : Form
    {
        public SearchWeatherData searchWeather = new SearchWeatherData();
        public Visualization(SearchWeatherData searchWeatherData)
        {
            InitializeComponent();
            this.searchWeather = searchWeatherData;
            this.lbl_location_name.Text = searchWeatherData.LocationName;
            this.lbl_dateRange_txt.Text = searchWeatherData.StartDate.ToShortDateString() + " -> " + searchWeatherData.EndDate.ToShortDateString();
            if (searchWeatherData.Periodicity == "Hourly")
            {
                this.btn_daily.BackColor = System.Drawing.Color.White;
                this.btn_daily.ForeColor = System.Drawing.Color.Teal;
                this.btn_weekly.BackColor = System.Drawing.Color.White;
                this.btn_weekly.ForeColor = System.Drawing.Color.Teal;
                this.btn_monthly.BackColor = System.Drawing.Color.White;
                this.btn_monthly.ForeColor = System.Drawing.Color.Teal;

                this.btn_hourly.BackColor = System.Drawing.Color.Teal;
                this.btn_hourly.ForeColor = System.Drawing.Color.White;
            }
            else if (searchWeatherData.Periodicity == "Daily")
            {
                this.btn_hourly.BackColor = System.Drawing.Color.White;
                this.btn_hourly.ForeColor = System.Drawing.Color.Teal;
                this.btn_weekly.BackColor = System.Drawing.Color.White;
                this.btn_weekly.ForeColor = System.Drawing.Color.Teal;
                this.btn_monthly.BackColor = System.Drawing.Color.White;
                this.btn_monthly.ForeColor = System.Drawing.Color.Teal;

                this.btn_daily.BackColor = System.Drawing.Color.Teal;
                this.btn_daily.ForeColor = System.Drawing.Color.White;
            }
            else if (searchWeatherData.Periodicity == "Weekly")
            {
                this.btn_hourly.BackColor = System.Drawing.Color.White;
                this.btn_hourly.ForeColor = System.Drawing.Color.Teal;
                this.btn_daily.BackColor = System.Drawing.Color.White;
                this.btn_daily.ForeColor = System.Drawing.Color.Teal;
                this.btn_monthly.BackColor = System.Drawing.Color.White;
                this.btn_monthly.ForeColor = System.Drawing.Color.Teal;

                this.btn_weekly.BackColor = System.Drawing.Color.Teal;
                this.btn_weekly.ForeColor = System.Drawing.Color.White;
            }
            else if (searchWeatherData.Periodicity == "Monthly")
            {
                this.btn_hourly.BackColor = System.Drawing.Color.White;
                this.btn_hourly.ForeColor = System.Drawing.Color.Teal;
                this.btn_daily.BackColor = System.Drawing.Color.White;
                this.btn_daily.ForeColor = System.Drawing.Color.Teal;
                this.btn_weekly.BackColor = System.Drawing.Color.White;
                this.btn_weekly.ForeColor = System.Drawing.Color.Teal;

                this.btn_monthly.BackColor = System.Drawing.Color.Teal;
                this.btn_monthly.ForeColor = System.Drawing.Color.White;
            }
            PopulateDataGridView_requiredRecord(this.searchWeather);

        }

        private void PopulateDataGridView_requiredRecord(SearchWeatherData searchWeatherData)
        {
            try {
                this.chart.Visible = false;
                this.dataGridView_event.Visible = false;
                if (this.dataGridView_showRecord.DataSource != null)
                {
                    this.dataGridView_showRecord.DataSource = null;
                }
                else
                {
                    this.dataGridView_showRecord.Rows.Clear();
                }
                this.dataGridView_showRecord.Visible = true;
                this.btn_graph.BackColor = System.Drawing.Color.Transparent;
                this.btn_requiredRecord.BackColor = System.Drawing.Color.Teal;

                var connection = Configuration.getInstance().getConnection();
                SqlCommand command = new SqlCommand("GetWeatherData", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LocationId", searchWeatherData.LocationId);
                command.Parameters.AddWithValue("@Periodicity", searchWeatherData.Periodicity);
                command.Parameters.AddWithValue("@StartDate", searchWeatherData.StartDate.ToString("MM/dd/yyyy"));
                command.Parameters.AddWithValue("@EndDate", searchWeatherData.EndDate.ToString("MM/dd/yyyy"));
                command.Parameters.AddWithValue("@StartTime", searchWeatherData.StartTime.ToShortTimeString());
                command.Parameters.AddWithValue("@EndTime", searchWeatherData.EndTime.ToShortTimeString());
                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "WeatherData");

                dataGridView_showRecord.DataSource = dataSet.Tables["WeatherData"];
                dataGridView_showRecord.AutoResizeColumns();
                dataGridView_showRecord.Columns["LocationId"].Visible = false;
                dataGridView_showRecord.Columns["Location"].Visible = false;
                if (searchWeatherData.Periodicity == "Hourly")
                {
                    dataGridView_showRecord.Columns["DateTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                }
                else if (searchWeatherData.Periodicity == "Daily")
                {
                    dataGridView_showRecord.Columns["DateTime"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
                else
                {
                    dataGridView_showRecord.Columns["DateTime"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_requiredRecord_Click(object sender, EventArgs e)
        {
            this.chart.Visible = false;
            this.btn_graph.BackColor = System.Drawing.Color.Transparent;
            this.btn_events.BackColor = System.Drawing.Color.Transparent;
            this.btn_report.BackColor = System.Drawing.Color.Transparent;
            this.btn_requiredRecord.BackColor = System.Drawing.Color.Teal;
            this.dataGridView_showRecord.Visible = true;
            this.btn_downloadpdf.Visible = false;
            PopulateDataGridView_requiredRecord(this.searchWeather);
        }

        private void btn_graph_Click(object sender, EventArgs e)
        {
            this.btn_requiredRecord.BackColor = System.Drawing.Color.Transparent;
            this.btn_events.BackColor = System.Drawing.Color.Transparent;
            this.btn_report.BackColor = System.Drawing.Color.Transparent;
            this.btn_graph.BackColor = System.Drawing.Color.Teal;
            this.dataGridView_showRecord.Visible = false;
            this.dataGridView_event.Visible = false;
            this.chart.Visible = true;
            this.btn_downloadpdf.Visible = false;
            fillChart(this.searchWeather);
        }

        private void fillChart(SearchWeatherData searchWeather)
        {
            var connection = Configuration.getInstance().getConnection();
            SqlCommand command = new SqlCommand("GetWeatherGraphData", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@LocationId", searchWeather.LocationId);
            command.Parameters.AddWithValue("@Periodicity", searchWeather.Periodicity);
            command.Parameters.AddWithValue("@StartDate", searchWeather.StartDate.ToString("MM/dd/yyyy"));
            command.Parameters.AddWithValue("@EndDate", searchWeather.EndDate.ToString("MM/dd/yyyy"));

            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            chart.DataSource = ds;
            chart.Series.Clear();
            chart.Series.Add("Avg Temperature");
            chart.Series["Avg Temperature"].XValueMember = "Date";
            chart.Series["Avg Temperature"].YValueMembers = "TemperatureAvg";

            chart.Series.Add("Avg Humidity");
            chart.Series["Avg Humidity"].XValueMember = "Date";
            chart.Series["Avg Humidity"].YValueMembers = "HumidityAvg";

            chart.Series.Add("Avg Visibility");
            chart.Series["Avg Visibility"].XValueMember = "Date";
            chart.Series["Avg Visibility"].YValueMembers = "VisibilityAvg";

            chart.Titles.Clear();
            chart.Titles.Add("Weather Graph");

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
        }

        private void chart_MouseMove(object sender, MouseEventArgs e)
        {
            Chart chart = (Chart)sender;

            // Check if the mouse is over a data point
            HitTestResult result = chart.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // Get the data point
                DataPoint dataPoint = chart.Series[result.Series.Name].Points[result.PointIndex];
                if(result.Series.Name == "Avg Temperature")
                {
                    toolTip1.SetToolTip(chart, $"Temperature: {dataPoint.YValues[0]}°C");
                }
                else if (result.Series.Name == "Avg Humidity")
                {
                    toolTip1.SetToolTip(chart, $"Humidity: {dataPoint.YValues[0]}°C");
                }
                else if (result.Series.Name == "Avg Visibility")
                {
                    toolTip1.SetToolTip(chart, $"Visibility: {dataPoint.YValues[0]}°C");
                }
                else
                {
                    toolTip1.SetToolTip(chart, $"Temperature: {dataPoint.YValues[0]}°C");
                }
            }
            else
            {
                // Hide the tooltip if the mouse is not over a data point
                toolTip1.SetToolTip(chart, "");
            }
        }

        private void btn_events_Click(object sender, EventArgs e)
        {
            this.btn_requiredRecord.BackColor = System.Drawing.Color.Transparent;
            this.btn_graph.BackColor = System.Drawing.Color.Transparent;
            this.btn_report.BackColor = System.Drawing.Color.Transparent;
            this.btn_events.BackColor = System.Drawing.Color.Teal;
            this.dataGridView_showRecord.Visible = false;
            this.chart.Visible = false;
            this.btn_downloadpdf.Visible = false;
            GetEventData(this.searchWeather);
        }

        public void GetEventData(SearchWeatherData searchWeatherData)
        {
            try
            {
                this.chart.Visible = false;
                this.dataGridView_showRecord.Visible = false;
                if (this.dataGridView_event.DataSource != null)
                {
                    this.dataGridView_event.DataSource = null;
                }
                else
                {
                    this.dataGridView_event.Rows.Clear();
                }
                this.dataGridView_event.Visible = true;

                var connection = Configuration.getInstance().getConnection();
                SqlCommand command = new SqlCommand("GetWeatherEventData", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LocationId", searchWeatherData.LocationId);
                command.Parameters.AddWithValue("@StartDate", searchWeatherData.StartDate.ToString("MM/dd/yyyy"));
                command.Parameters.AddWithValue("@EndDate", searchWeatherData.EndDate.ToString("MM/dd/yyyy"));

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "WeatherEvent");

                dataGridView_event.DataSource = dataSet.Tables["WeatherEvent"];
                dataGridView_event.AutoResizeColumns();
                dataGridView_event.Columns["LocationId"].Visible = false;
                dataGridView_event.Columns["Location"].Visible = false;
                dataGridView_event.Columns["EventDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btn_report_Click(object sender, EventArgs e)
        {
            this.btn_requiredRecord.BackColor = System.Drawing.Color.Transparent;
            this.btn_graph.BackColor = System.Drawing.Color.Transparent;
            this.btn_events.BackColor = System.Drawing.Color.Transparent;
            this.btn_report.BackColor = System.Drawing.Color.Teal;
            this.dataGridView_showRecord.Visible = false;
            this.chart.Visible = false;
            this.dataGridView_event.Visible = false;
            this.btn_downloadpdf.Visible = true;
        }

        private void btnPdf_Click()
        {
            if (dataGridView_showRecord.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView_showRecord.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView_showRecord.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView_showRecord.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.Show();
            this.Hide();
        }

        private void btn_downloadpdf_Click(object sender, EventArgs e)
        {
            btnPdf_Click();
        }

        //private void btn_daily_Click(object sender, EventArgs e)
        //{
        //    this.searchWeather.Periodicity = "Daily";
        //    PopulateDataGridView_requiredRecord(this.searchWeather);
        //}

        //private void btn_hourly_Click(object sender, EventArgs e)
        //{
        //    this.searchWeather.Periodicity = "Hourly";
        //    PopulateDataGridView_requiredRecord(this.searchWeather);
        //}

        //private void btn_weekly_Click(object sender, EventArgs e)
        //{
        //    this.searchWeather.Periodicity = "Weekly";
        //    PopulateDataGridView_requiredRecord(this.searchWeather);
        //}

        //private void btn_monthly_Click(object sender, EventArgs e)
        //{
        //    this.searchWeather.Periodicity = "Monthly";
        //    PopulateDataGridView_requiredRecord(this.searchWeather);
        //}
    }
}
