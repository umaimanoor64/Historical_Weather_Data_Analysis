using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace check
{
    public partial class Record : UserControl
    {
        public static Record instance;

        public Record()
        {
            InitializeComponent();
         //   SqlConnection[] allConnections = Configuration.getInstance().getConnection();

         //   // Access the connections by index
         //   SqlConnection con = allConnections[0];
         //  // SqlConnection con1 = allConnections[1];

         //   SqlCommand cmd = new SqlCommand("Select * from dbo.WeatherData", con);
         //   SqlDataAdapter da = new SqlDataAdapter(cmd);
         //   DataTable dt = new DataTable();
         //   da.Fill(dt);
         //   string City = dt.Rows[0]["Location"].ToString();
         //   string PValue = dt.Rows[0]["Periodicity"].ToString();
         //   string SDValue = dt.Rows[0]["startDate"].ToString();
         //   string EDValue = dt.Rows[0]["endDate"].ToString();
         //   string STValue = dt.Rows[0]["startTime"].ToString();
         //   string ETValue = dt.Rows[0]["endTime"].ToString();

         //   // Set the value to the label's text property
         //   city.Text = City;
         //   Periodicity.Text = PValue;
         //   SDate.Text = SDValue;
         //   EDate.Text = EDValue;
         //   STime.Text = STValue;
         //   ETime.Text = ETValue;

         //   //SqlCommand cd = new SqlCommand("DELETE FROM WeatherData", con);

         //   SqlConnection[] allConnections1 = Configuration.getInstance().getConnection();

         //   // Access the connections by index
         //   SqlConnection connec = allConnections1[0];
         ////   SqlConnection connec1 = allConnections1[1];
         //   SqlCommand cd = new SqlCommand("SELECT Province, City, DateTime, Temperature, Humidity, Precipitation, Description " +
         //       "FROM WeatherData wd INNER JOIN Location loc ON wd.LocationId = loc.LocationId WHERE loc.City = @City " +
         //       "AND wd.DateTime BETWEEN @SDValue,STime AND @EDValue,ETime ", con);
            
         //   cd.Parameters.AddWithValue("@City", City); // Replace locationValue with the specific city
         //   cd.Parameters.AddWithValue("@DateTime", SDValue+STValue); // Replace SDValue with the start date
         //   //cd.Parameters.AddWithValue("@DateTime", EDValue+ETValue); // Replace EDValue with the end date

         //   SqlDataAdapter db = new SqlDataAdapter(cd);
         //   DataTable ds = new DataTable();
         //   db.Fill(ds);
         //   dataGridView1.DataSource = ds;
        }
        //Select Province, City, DateTime, Temperature, Humidity, Precipitation, Description FROM WeatherData WHERE locationValue = @City

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
