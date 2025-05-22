using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VideoASCII
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> test = new Dictionary<string, string>();
        private Dictionary<string, string> test1 = new Dictionary<string, string>();
        private Dictionary<string, string> test2 = new Dictionary<string, string>();

        private void Form4_Load(object sender, EventArgs e)
        {
            //SETS RESOLUTION
            test.Add("1920x1080", "1920x1080");
            test.Add("1280x720", "1280x720");
            test.Add("858x480", "858x480");
            test.Add("480x360", "480x360");
            test.Add("352x240", "352x240");
            test.Add("Custom", "Custom");
            comboBox1.DataSource = new BindingSource(test, null);
            comboBox1.ValueMember = "Key";

            comboBox1.SelectedIndex = 1;
            string value = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Value;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            //SETS FPS
            test1.Add("30", "30");
            test1.Add("Custom", "Custom");
            comboBox4.DataSource = new BindingSource(test1, null);
            comboBox4.ValueMember = "Key";

            comboBox4.SelectedIndex = 0;
            string value1 = ((KeyValuePair<string, string>)comboBox4.SelectedItem).Value;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

            //SETS VIDEO FORMAT
            test2.Add("=i@BMOjEF(ULJ;,. ", "default");
            test2.Add("Custom", "Custom");
            comboBox2.DataSource = new BindingSource(test2, null);
            comboBox2.ValueMember = "Key";

            comboBox2.SelectedIndex = 0;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            //ADDS TIMER
            timer1.Start();

            //SETS TITLE
            Text = "Options";
        }

        private void Done_Click(object sender, EventArgs e)
        {
            //SAVES RESOLUTION
            if (comboBox1.Enabled)
            {
                string[] tokens = comboBox1.GetItemText(comboBox1.SelectedItem).Split('x');
                Form1.options[0] = tokens[0];
                Form1.options[1] = tokens[1];
            }
            else {
                Form1.options[0] = textBox1.Text;
                Form1.options[1] = textBox2.Text;
            }

            //SAVES VIDEO FORMAT
            if (comboBox2.Enabled)
            {
                Form1.options[3] = comboBox2.GetItemText(comboBox2.SelectedItem);
            }
            else
            {
                Form1.options[3] = textBox4.Text;
            }

            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //RESOLUTION
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Custom")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }

            //FPS
            if (comboBox4.GetItemText(comboBox4.SelectedItem) == "Custom")
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }

            //VIDEO FORMAT
            if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Custom")
            {
                textBox4.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = true;
                textBox4.Enabled = false;
            }

            //RESOLUTION
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()) && !string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                comboBox1.Enabled = false;
            }
            else {
                comboBox1.Enabled = true;
            }

            //VIDEO FORMAT
            if (!string.IsNullOrEmpty(textBox4.Text.Trim()) && !string.IsNullOrEmpty(textBox4.Text.Trim()))
            {
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
            }
        }
    }
}
