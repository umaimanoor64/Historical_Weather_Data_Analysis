using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        Label label = new Label();
        string selectedItemFromComboBox;
        // Define your list of allowed items
        string[] allowedItems = { "Islamabad", "Lahore", "Peshawar", "Quetta", "Karachi" };

        public Form1()
        {
            InitializeComponent();
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            // Populate the combo box with allowed items
            foreach (var item in allowedItems)
            {
                ComboBox.Items.Add(item);
            }

            // Set the combo box style to DropDown to prevent typing
            ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // Set the background color of the combo box to black
            ComboBox.BackColor = Color.Black;

            // Set the text color of the combo box to white
            ComboBox.ForeColor = Color.White;
            // Add initial label over the combo box
            
            label.Text = "Enter your location";
            label.ForeColor = Color.Gray;
            label.BackColor = Color.Transparent;
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Size = new Size(ComboBox.Width-20, ComboBox.Height);
            ComboBox.Controls.Add(label);
            label.BringToFront();

            // Attach GotFocus event handler to the combo box
            //comboBox1.GotFocus += ComboBox1_GotFocus;

            // Attach SelectedIndexChanged event handler to the combo box
            ComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label.Visible = false;

            //ComboBox comboBox = sender as ComboBox;
            //ComboBox.Controls[0].Visible = false;

            //// Validate the selected item against the list of allowed items
            //if (comboBox.SelectedIndex != -1 && !allowedItems.Contains(comboBox.SelectedItem.ToString()))
            //{
            //    MessageBox.Show("Please select a valid item.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    // Optionally, reset the combo box selection to the default value
            //    comboBox.SelectedIndex = -1;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ComboBox != null && ComboBox.SelectedItem != null)
            {
                // Access the selected item as a string
                selectedItemFromComboBox = ComboBox.SelectedItem.ToString();

                // You can then use the selectedItemFromComboBox variable to store or process the selected item
            }
            else
            {
                // If ComboBox is empty, show a message box
                MessageBox.Show("Please select an item from the ComboBox.", "Empty ComboBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Close Form1
            this.Close();

            // Open Form2
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
