namespace check
{
    partial class Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Periodicity = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Periodicity
            // 
            this.Periodicity.AutoSize = true;
            this.Periodicity.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Periodicity.Location = new System.Drawing.Point(334, 229);
            this.Periodicity.Name = "Periodicity";
            this.Periodicity.Size = new System.Drawing.Size(74, 26);
            this.Periodicity.TabIndex = 17;
            this.Periodicity.Text = "Report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 39);
            this.panel2.TabIndex = 19;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Periodicity);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(776, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Periodicity;
        private System.Windows.Forms.Panel panel2;
    }
}
