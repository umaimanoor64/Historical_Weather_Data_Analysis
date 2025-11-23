namespace check
{
    partial class Visualization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualization));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_events = new System.Windows.Forms.Button();
            this.btn_graph = new System.Windows.Forms.Button();
            this.btn_requiredRecord = new System.Windows.Forms.Button();
            this.dataGridView_showRecord = new System.Windows.Forms.DataGridView();
            this.btn_daily = new System.Windows.Forms.Button();
            this.btn_hourly = new System.Windows.Forms.Button();
            this.lbl_weatherData = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_location_name = new System.Windows.Forms.Label();
            this.lbl_dateRange = new System.Windows.Forms.Label();
            this.lbl_dateRange_txt = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_weekly = new System.Windows.Forms.Button();
            this.btn_monthly = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView_event = new System.Windows.Forms.DataGridView();
            this.btn_downloadpdf = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_event)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_report);
            this.panel1.Controls.Add(this.btn_events);
            this.panel1.Controls.Add(this.btn_graph);
            this.panel1.Controls.Add(this.btn_requiredRecord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 895);
            this.panel1.TabIndex = 5;
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(0, 519);
            this.btn_back.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(383, 100);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "    Back";
            this.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_report
            // 
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Image = ((System.Drawing.Image)(resources.GetObject("btn_report.Image")));
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(0, 419);
            this.btn_report.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(383, 100);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "    Reports";
            this.btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_events
            // 
            this.btn_events.FlatAppearance.BorderSize = 0;
            this.btn_events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_events.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_events.ForeColor = System.Drawing.Color.White;
            this.btn_events.Image = ((System.Drawing.Image)(resources.GetObject("btn_events.Image")));
            this.btn_events.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_events.Location = new System.Drawing.Point(0, 308);
            this.btn_events.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_events.Name = "btn_events";
            this.btn_events.Size = new System.Drawing.Size(383, 100);
            this.btn_events.TabIndex = 4;
            this.btn_events.Text = "    Events";
            this.btn_events.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_events.UseVisualStyleBackColor = true;
            this.btn_events.Click += new System.EventHandler(this.btn_events_Click);
            // 
            // btn_graph
            // 
            this.btn_graph.FlatAppearance.BorderSize = 0;
            this.btn_graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_graph.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_graph.ForeColor = System.Drawing.Color.White;
            this.btn_graph.Image = ((System.Drawing.Image)(resources.GetObject("btn_graph.Image")));
            this.btn_graph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_graph.Location = new System.Drawing.Point(0, 209);
            this.btn_graph.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.Size = new System.Drawing.Size(383, 100);
            this.btn_graph.TabIndex = 4;
            this.btn_graph.Text = "    Graphs";
            this.btn_graph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_graph.UseVisualStyleBackColor = true;
            this.btn_graph.Click += new System.EventHandler(this.btn_graph_Click);
            // 
            // btn_requiredRecord
            // 
            this.btn_requiredRecord.FlatAppearance.BorderSize = 0;
            this.btn_requiredRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_requiredRecord.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_requiredRecord.ForeColor = System.Drawing.Color.White;
            this.btn_requiredRecord.Image = ((System.Drawing.Image)(resources.GetObject("btn_requiredRecord.Image")));
            this.btn_requiredRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_requiredRecord.Location = new System.Drawing.Point(0, 109);
            this.btn_requiredRecord.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_requiredRecord.Name = "btn_requiredRecord";
            this.btn_requiredRecord.Size = new System.Drawing.Size(383, 100);
            this.btn_requiredRecord.TabIndex = 4;
            this.btn_requiredRecord.Text = "    Required Record";
            this.btn_requiredRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_requiredRecord.UseVisualStyleBackColor = false;
            this.btn_requiredRecord.Click += new System.EventHandler(this.btn_requiredRecord_Click);
            // 
            // dataGridView_showRecord
            // 
            this.dataGridView_showRecord.AllowUserToAddRows = false;
            this.dataGridView_showRecord.AllowUserToDeleteRows = false;
            this.dataGridView_showRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_showRecord.Location = new System.Drawing.Point(431, 251);
            this.dataGridView_showRecord.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView_showRecord.Name = "dataGridView_showRecord";
            this.dataGridView_showRecord.ReadOnly = true;
            this.dataGridView_showRecord.RowHeadersWidth = 72;
            this.dataGridView_showRecord.Size = new System.Drawing.Size(1333, 594);
            this.dataGridView_showRecord.TabIndex = 8;
            this.dataGridView_showRecord.Visible = false;
            // 
            // btn_daily
            // 
            this.btn_daily.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_daily.ForeColor = System.Drawing.Color.Teal;
            this.btn_daily.Location = new System.Drawing.Point(431, 153);
            this.btn_daily.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_daily.Name = "btn_daily";
            this.btn_daily.Size = new System.Drawing.Size(172, 74);
            this.btn_daily.TabIndex = 9;
            this.btn_daily.Text = "Daily";
            this.btn_daily.UseVisualStyleBackColor = true;
            // 
            // btn_hourly
            // 
            this.btn_hourly.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hourly.ForeColor = System.Drawing.Color.Teal;
            this.btn_hourly.Location = new System.Drawing.Point(598, 153);
            this.btn_hourly.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_hourly.Name = "btn_hourly";
            this.btn_hourly.Size = new System.Drawing.Size(172, 74);
            this.btn_hourly.TabIndex = 10;
            this.btn_hourly.Text = "Hourly";
            this.btn_hourly.UseVisualStyleBackColor = true;
            // 
            // lbl_weatherData
            // 
            this.lbl_weatherData.AutoSize = true;
            this.lbl_weatherData.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weatherData.ForeColor = System.Drawing.Color.Teal;
            this.lbl_weatherData.Location = new System.Drawing.Point(424, 109);
            this.lbl_weatherData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_weatherData.Name = "lbl_weatherData";
            this.lbl_weatherData.Size = new System.Drawing.Size(181, 36);
            this.lbl_weatherData.TabIndex = 11;
            this.lbl_weatherData.Text = "Weather data";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.ForeColor = System.Drawing.Color.Teal;
            this.lbl_location.Location = new System.Drawing.Point(425, 50);
            this.lbl_location.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(133, 36);
            this.lbl_location.TabIndex = 12;
            this.lbl_location.Text = "Location: ";
            // 
            // lbl_location_name
            // 
            this.lbl_location_name.AutoSize = true;
            this.lbl_location_name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location_name.ForeColor = System.Drawing.Color.Teal;
            this.lbl_location_name.Location = new System.Drawing.Point(557, 50);
            this.lbl_location_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_location_name.Name = "lbl_location_name";
            this.lbl_location_name.Size = new System.Drawing.Size(0, 35);
            this.lbl_location_name.TabIndex = 13;
            // 
            // lbl_dateRange
            // 
            this.lbl_dateRange.AutoSize = true;
            this.lbl_dateRange.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateRange.ForeColor = System.Drawing.Color.Teal;
            this.lbl_dateRange.Location = new System.Drawing.Point(1078, 65);
            this.lbl_dateRange.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_dateRange.Name = "lbl_dateRange";
            this.lbl_dateRange.Size = new System.Drawing.Size(158, 36);
            this.lbl_dateRange.TabIndex = 14;
            this.lbl_dateRange.Text = "Date range:";
            // 
            // lbl_dateRange_txt
            // 
            this.lbl_dateRange_txt.AutoSize = true;
            this.lbl_dateRange_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateRange_txt.ForeColor = System.Drawing.Color.Teal;
            this.lbl_dateRange_txt.Location = new System.Drawing.Point(1252, 65);
            this.lbl_dateRange_txt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_dateRange_txt.Name = "lbl_dateRange_txt";
            this.lbl_dateRange_txt.Size = new System.Drawing.Size(0, 35);
            this.lbl_dateRange_txt.TabIndex = 15;
            // 
            // chart
            // 
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.Teal;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(431, 251);
            this.chart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chart.Name = "chart";
            series4.ChartArea = "ChartArea1";
            series4.LabelToolTip = "#LABEL";
            series4.Legend = "Legend1";
            series4.Name = "Avg Temperature";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Avg Humidity";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Avg Visibility";
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(1333, 594);
            this.chart.TabIndex = 16;
            this.chart.Text = "chart1";
            this.chart.Visible = false;
            this.chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // btn_weekly
            // 
            this.btn_weekly.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_weekly.ForeColor = System.Drawing.Color.Teal;
            this.btn_weekly.Location = new System.Drawing.Point(763, 153);
            this.btn_weekly.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_weekly.Name = "btn_weekly";
            this.btn_weekly.Size = new System.Drawing.Size(172, 74);
            this.btn_weekly.TabIndex = 17;
            this.btn_weekly.Text = "Weekly";
            this.btn_weekly.UseVisualStyleBackColor = true;
            // 
            // btn_monthly
            // 
            this.btn_monthly.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_monthly.ForeColor = System.Drawing.Color.Teal;
            this.btn_monthly.Location = new System.Drawing.Point(930, 153);
            this.btn_monthly.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_monthly.Name = "btn_monthly";
            this.btn_monthly.Size = new System.Drawing.Size(172, 74);
            this.btn_monthly.TabIndex = 18;
            this.btn_monthly.Text = "Monthly";
            this.btn_monthly.UseVisualStyleBackColor = true;
            // 
            // dataGridView_event
            // 
            this.dataGridView_event.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_event.Location = new System.Drawing.Point(431, 251);
            this.dataGridView_event.Name = "dataGridView_event";
            this.dataGridView_event.RowHeadersWidth = 72;
            this.dataGridView_event.RowTemplate.Height = 31;
            this.dataGridView_event.Size = new System.Drawing.Size(536, 268);
            this.dataGridView_event.TabIndex = 19;
            // 
            // btn_downloadpdf
            // 
            this.btn_downloadpdf.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadpdf.ForeColor = System.Drawing.Color.Teal;
            this.btn_downloadpdf.Location = new System.Drawing.Point(431, 308);
            this.btn_downloadpdf.Name = "btn_downloadpdf";
            this.btn_downloadpdf.Size = new System.Drawing.Size(265, 62);
            this.btn_downloadpdf.TabIndex = 20;
            this.btn_downloadpdf.Text = "Download PDF";
            this.btn_downloadpdf.UseVisualStyleBackColor = true;
            this.btn_downloadpdf.Click += new System.EventHandler(this.btn_downloadpdf_Click);
            // 
            // Visualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 895);
            this.Controls.Add(this.btn_downloadpdf);
            this.Controls.Add(this.dataGridView_event);
            this.Controls.Add(this.btn_monthly);
            this.Controls.Add(this.btn_weekly);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.lbl_dateRange_txt);
            this.Controls.Add(this.lbl_dateRange);
            this.Controls.Add(this.lbl_location_name);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_weatherData);
            this.Controls.Add(this.btn_hourly);
            this.Controls.Add(this.btn_daily);
            this.Controls.Add(this.dataGridView_showRecord);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Visualization";
            this.Text = "Visualization";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_event)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_events;
        private System.Windows.Forms.Button btn_graph;
        private System.Windows.Forms.Button btn_requiredRecord;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView_showRecord;
        private System.Windows.Forms.Button btn_daily;
        private System.Windows.Forms.Button btn_hourly;
        private System.Windows.Forms.Label lbl_weatherData;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_location_name;
        private System.Windows.Forms.Label lbl_dateRange;
        private System.Windows.Forms.Label lbl_dateRange_txt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btn_weekly;
        private System.Windows.Forms.Button btn_monthly;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView_event;
        private System.Windows.Forms.Button btn_downloadpdf;
    }
}

