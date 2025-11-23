namespace check
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbl_currentDate = new System.Windows.Forms.Label();
            this.lbl_currentTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_radio_validation = new System.Windows.Forms.Label();
            this.lbl_endTime_validation = new System.Windows.Forms.Label();
            this.lbl_startTime_validation = new System.Windows.Forms.Label();
            this.lbl_datePicker_endDate_validation = new System.Windows.Forms.Label();
            this.lbl_location_validation = new System.Windows.Forms.Label();
            this.lbl_datePicker_startDate_validation = new System.Windows.Forms.Label();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.TimePicker_endTime = new System.Windows.Forms.DateTimePicker();
            this.TimePicker_startTime = new System.Windows.Forms.DateTimePicker();
            this.datePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.datePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.radioButton_weekly = new System.Windows.Forms.RadioButton();
            this.radioButton_monthly = new System.Windows.Forms.RadioButton();
            this.radioButton_daily = new System.Windows.Forms.RadioButton();
            this.radioButton_hourly = new System.Windows.Forms.RadioButton();
            this.lbl_endTime = new System.Windows.Forms.Label();
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_weatherApp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(189, 400);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 34);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbl_currentDate
            // 
            this.lbl_currentDate.AutoSize = true;
            this.lbl_currentDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentDate.ForeColor = System.Drawing.Color.White;
            this.lbl_currentDate.Location = new System.Drawing.Point(98, 187);
            this.lbl_currentDate.Name = "lbl_currentDate";
            this.lbl_currentDate.Size = new System.Drawing.Size(224, 26);
            this.lbl_currentDate.TabIndex = 4;
            this.lbl_currentDate.Text = "Thursday, 2 may 2024";
            // 
            // lbl_currentTime
            // 
            this.lbl_currentTime.AutoSize = true;
            this.lbl_currentTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentTime.ForeColor = System.Drawing.Color.White;
            this.lbl_currentTime.Location = new System.Drawing.Point(75, 101);
            this.lbl_currentTime.Name = "lbl_currentTime";
            this.lbl_currentTime.Size = new System.Drawing.Size(335, 86);
            this.lbl_currentTime.TabIndex = 3;
            this.lbl_currentTime.Text = "12:30 Pm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.lbl_radio_validation);
            this.panel1.Controls.Add(this.lbl_endTime_validation);
            this.panel1.Controls.Add(this.lbl_startTime_validation);
            this.panel1.Controls.Add(this.lbl_datePicker_endDate_validation);
            this.panel1.Controls.Add(this.lbl_location_validation);
            this.panel1.Controls.Add(this.lbl_datePicker_startDate_validation);
            this.panel1.Controls.Add(this.locationComboBox);
            this.panel1.Controls.Add(this.TimePicker_endTime);
            this.panel1.Controls.Add(this.TimePicker_startTime);
            this.panel1.Controls.Add(this.datePicker_endDate);
            this.panel1.Controls.Add(this.datePicker_startDate);
            this.panel1.Controls.Add(this.lbl_location);
            this.panel1.Controls.Add(this.lbl_endDate);
            this.panel1.Controls.Add(this.radioButton_weekly);
            this.panel1.Controls.Add(this.radioButton_monthly);
            this.panel1.Controls.Add(this.radioButton_daily);
            this.panel1.Controls.Add(this.radioButton_hourly);
            this.panel1.Controls.Add(this.lbl_endTime);
            this.panel1.Controls.Add(this.lbl_startTime);
            this.panel1.Controls.Add(this.lbl_startDate);
            this.panel1.Controls.Add(this.lbl_weatherApp);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lbl_currentDate);
            this.panel1.Controls.Add(this.lbl_currentTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 485);
            this.panel1.TabIndex = 1;
            // 
            // lbl_radio_validation
            // 
            this.lbl_radio_validation.AutoSize = true;
            this.lbl_radio_validation.BackColor = System.Drawing.Color.Transparent;
            this.lbl_radio_validation.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_radio_validation.ForeColor = System.Drawing.Color.Red;
            this.lbl_radio_validation.Location = new System.Drawing.Point(142, 365);
            this.lbl_radio_validation.Name = "lbl_radio_validation";
            this.lbl_radio_validation.Size = new System.Drawing.Size(0, 16);
            this.lbl_radio_validation.TabIndex = 43;
            this.lbl_radio_validation.Visible = false;
            // 
            // lbl_endTime_validation
            // 
            this.lbl_endTime_validation.AutoSize = true;
            this.lbl_endTime_validation.BackColor = System.Drawing.Color.Transparent;
            this.lbl_endTime_validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endTime_validation.ForeColor = System.Drawing.Color.Red;
            this.lbl_endTime_validation.Location = new System.Drawing.Point(684, 455);
            this.lbl_endTime_validation.Name = "lbl_endTime_validation";
            this.lbl_endTime_validation.Size = new System.Drawing.Size(0, 15);
            this.lbl_endTime_validation.TabIndex = 42;
            this.lbl_endTime_validation.Visible = false;
            // 
            // lbl_startTime_validation
            // 
            this.lbl_startTime_validation.AutoSize = true;
            this.lbl_startTime_validation.BackColor = System.Drawing.Color.Transparent;
            this.lbl_startTime_validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_startTime_validation.ForeColor = System.Drawing.Color.Red;
            this.lbl_startTime_validation.Location = new System.Drawing.Point(684, 396);
            this.lbl_startTime_validation.Name = "lbl_startTime_validation";
            this.lbl_startTime_validation.Size = new System.Drawing.Size(0, 15);
            this.lbl_startTime_validation.TabIndex = 41;
            this.lbl_startTime_validation.Visible = false;
            // 
            // lbl_datePicker_endDate_validation
            // 
            this.lbl_datePicker_endDate_validation.AutoSize = true;
            this.lbl_datePicker_endDate_validation.BackColor = System.Drawing.Color.Transparent;
            this.lbl_datePicker_endDate_validation.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datePicker_endDate_validation.ForeColor = System.Drawing.Color.Red;
            this.lbl_datePicker_endDate_validation.Location = new System.Drawing.Point(684, 339);
            this.lbl_datePicker_endDate_validation.Name = "lbl_datePicker_endDate_validation";
            this.lbl_datePicker_endDate_validation.Size = new System.Drawing.Size(0, 16);
            this.lbl_datePicker_endDate_validation.TabIndex = 40;
            this.lbl_datePicker_endDate_validation.Visible = false;
            // 
            // lbl_location_validation
            // 
            this.lbl_location_validation.AutoSize = true;
            this.lbl_location_validation.BackColor = System.Drawing.Color.Transparent;
            this.lbl_location_validation.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location_validation.ForeColor = System.Drawing.Color.Red;
            this.lbl_location_validation.Location = new System.Drawing.Point(580, 185);
            this.lbl_location_validation.Name = "lbl_location_validation";
            this.lbl_location_validation.Size = new System.Drawing.Size(0, 16);
            this.lbl_location_validation.TabIndex = 39;
            this.lbl_location_validation.Visible = false;
            // 
            // lbl_datePicker_startDate_validation
            // 
            this.lbl_datePicker_startDate_validation.AutoSize = true;
            this.lbl_datePicker_startDate_validation.BackColor = System.Drawing.Color.Transparent;
            this.lbl_datePicker_startDate_validation.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datePicker_startDate_validation.ForeColor = System.Drawing.Color.Red;
            this.lbl_datePicker_startDate_validation.Location = new System.Drawing.Point(684, 277);
            this.lbl_datePicker_startDate_validation.Name = "lbl_datePicker_startDate_validation";
            this.lbl_datePicker_startDate_validation.Size = new System.Drawing.Size(0, 16);
            this.lbl_datePicker_startDate_validation.TabIndex = 38;
            this.lbl_datePicker_startDate_validation.Visible = false;
            // 
            // locationComboBox
            // 
            this.locationComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(581, 153);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(215, 29);
            this.locationComboBox.TabIndex = 37;
            // 
            // TimePicker_endTime
            // 
            this.TimePicker_endTime.CustomFormat = "HH:mm:ss";
            this.TimePicker_endTime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker_endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_endTime.Location = new System.Drawing.Point(684, 424);
            this.TimePicker_endTime.Name = "TimePicker_endTime";
            this.TimePicker_endTime.ShowUpDown = true;
            this.TimePicker_endTime.Size = new System.Drawing.Size(181, 28);
            this.TimePicker_endTime.TabIndex = 36;
            // 
            // TimePicker_startTime
            // 
            this.TimePicker_startTime.CustomFormat = "HH:mm:ss";
            this.TimePicker_startTime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_startTime.Location = new System.Drawing.Point(684, 365);
            this.TimePicker_startTime.Name = "TimePicker_startTime";
            this.TimePicker_startTime.ShowUpDown = true;
            this.TimePicker_startTime.Size = new System.Drawing.Size(181, 28);
            this.TimePicker_startTime.TabIndex = 35;
            // 
            // datePicker_endDate
            // 
            this.datePicker_endDate.CustomFormat = "";
            this.datePicker_endDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_endDate.Location = new System.Drawing.Point(682, 308);
            this.datePicker_endDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.datePicker_endDate.MinDate = new System.DateTime(2024, 2, 1, 0, 0, 0, 0);
            this.datePicker_endDate.Name = "datePicker_endDate";
            this.datePicker_endDate.Size = new System.Drawing.Size(181, 28);
            this.datePicker_endDate.TabIndex = 34;
            // 
            // datePicker_startDate
            // 
            this.datePicker_startDate.CustomFormat = "";
            this.datePicker_startDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_startDate.Location = new System.Drawing.Point(682, 246);
            this.datePicker_startDate.MaxDate = new System.DateTime(2024, 12, 25, 0, 0, 0, 0);
            this.datePicker_startDate.MinDate = new System.DateTime(2024, 2, 1, 0, 0, 0, 0);
            this.datePicker_startDate.Name = "datePicker_startDate";
            this.datePicker_startDate.Size = new System.Drawing.Size(181, 28);
            this.datePicker_startDate.TabIndex = 33;
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.BackColor = System.Drawing.Color.Transparent;
            this.lbl_location.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.ForeColor = System.Drawing.Color.White;
            this.lbl_location.Location = new System.Drawing.Point(577, 127);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(114, 21);
            this.lbl_location.TabIndex = 32;
            this.lbl_location.Text = "Select Location";
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_endDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endDate.ForeColor = System.Drawing.Color.White;
            this.lbl_endDate.Location = new System.Drawing.Point(579, 315);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(72, 21);
            this.lbl_endDate.TabIndex = 30;
            this.lbl_endDate.Text = "End Date";
            // 
            // radioButton_weekly
            // 
            this.radioButton_weekly.AutoSize = true;
            this.radioButton_weekly.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_weekly.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_weekly.ForeColor = System.Drawing.Color.White;
            this.radioButton_weekly.Location = new System.Drawing.Point(145, 335);
            this.radioButton_weekly.Name = "radioButton_weekly";
            this.radioButton_weekly.Size = new System.Drawing.Size(79, 25);
            this.radioButton_weekly.TabIndex = 29;
            this.radioButton_weekly.TabStop = true;
            this.radioButton_weekly.Text = "Weekly";
            this.radioButton_weekly.UseVisualStyleBackColor = false;
            this.radioButton_weekly.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton_monthly
            // 
            this.radioButton_monthly.AutoSize = true;
            this.radioButton_monthly.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_monthly.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_monthly.ForeColor = System.Drawing.Color.White;
            this.radioButton_monthly.Location = new System.Drawing.Point(251, 335);
            this.radioButton_monthly.Name = "radioButton_monthly";
            this.radioButton_monthly.Size = new System.Drawing.Size(86, 25);
            this.radioButton_monthly.TabIndex = 28;
            this.radioButton_monthly.TabStop = true;
            this.radioButton_monthly.Text = "Monthly";
            this.radioButton_monthly.UseVisualStyleBackColor = false;
            this.radioButton_monthly.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton_daily
            // 
            this.radioButton_daily.AutoSize = true;
            this.radioButton_daily.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_daily.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_daily.ForeColor = System.Drawing.Color.White;
            this.radioButton_daily.Location = new System.Drawing.Point(251, 292);
            this.radioButton_daily.Name = "radioButton_daily";
            this.radioButton_daily.Size = new System.Drawing.Size(63, 25);
            this.radioButton_daily.TabIndex = 27;
            this.radioButton_daily.TabStop = true;
            this.radioButton_daily.Text = "Daily";
            this.radioButton_daily.UseVisualStyleBackColor = false;
            this.radioButton_daily.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton_hourly
            // 
            this.radioButton_hourly.AutoSize = true;
            this.radioButton_hourly.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_hourly.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_hourly.ForeColor = System.Drawing.Color.White;
            this.radioButton_hourly.Location = new System.Drawing.Point(145, 292);
            this.radioButton_hourly.Name = "radioButton_hourly";
            this.radioButton_hourly.Size = new System.Drawing.Size(75, 25);
            this.radioButton_hourly.TabIndex = 26;
            this.radioButton_hourly.TabStop = true;
            this.radioButton_hourly.Text = "Hourly";
            this.radioButton_hourly.UseVisualStyleBackColor = false;
            this.radioButton_hourly.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbl_endTime
            // 
            this.lbl_endTime.AutoSize = true;
            this.lbl_endTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_endTime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endTime.ForeColor = System.Drawing.Color.White;
            this.lbl_endTime.Location = new System.Drawing.Point(577, 431);
            this.lbl_endTime.Name = "lbl_endTime";
            this.lbl_endTime.Size = new System.Drawing.Size(74, 21);
            this.lbl_endTime.TabIndex = 21;
            this.lbl_endTime.Text = "End Time";
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.AutoSize = true;
            this.lbl_startTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_startTime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_startTime.ForeColor = System.Drawing.Color.White;
            this.lbl_startTime.Location = new System.Drawing.Point(577, 372);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(81, 21);
            this.lbl_startTime.TabIndex = 20;
            this.lbl_startTime.Text = "Start Time";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_startDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_startDate.ForeColor = System.Drawing.Color.White;
            this.lbl_startDate.Location = new System.Drawing.Point(579, 253);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(79, 21);
            this.lbl_startDate.TabIndex = 19;
            this.lbl_startDate.Text = "Start Date";
            // 
            // lbl_weatherApp
            // 
            this.lbl_weatherApp.AutoSize = true;
            this.lbl_weatherApp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_weatherApp.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weatherApp.ForeColor = System.Drawing.Color.White;
            this.lbl_weatherApp.Location = new System.Drawing.Point(345, 19);
            this.lbl_weatherApp.Name = "lbl_weatherApp";
            this.lbl_weatherApp.Size = new System.Drawing.Size(250, 48);
            this.lbl_weatherApp.TabIndex = 18;
            this.lbl_weatherApp.Text = "Weather App";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 485);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbl_currentDate;
        private System.Windows.Forms.Label lbl_currentTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.RadioButton radioButton_weekly;
        private System.Windows.Forms.RadioButton radioButton_monthly;
        private System.Windows.Forms.RadioButton radioButton_daily;
        private System.Windows.Forms.RadioButton radioButton_hourly;
        private System.Windows.Forms.Label lbl_endTime;
        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.Label lbl_weatherApp;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.DateTimePicker TimePicker_endTime;
        private System.Windows.Forms.DateTimePicker TimePicker_startTime;
        private System.Windows.Forms.DateTimePicker datePicker_endDate;
        private System.Windows.Forms.DateTimePicker datePicker_startDate;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.Label lbl_datePicker_startDate_validation;
        private System.Windows.Forms.Label lbl_datePicker_endDate_validation;
        private System.Windows.Forms.Label lbl_location_validation;
        private System.Windows.Forms.Label lbl_startTime_validation;
        private System.Windows.Forms.Label lbl_endTime_validation;
        private System.Windows.Forms.Label lbl_radio_validation;
    }
}