using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace VideoASCII
{
    public partial class Form1 : Form
    {

        public static string passing;

        public static string browserText1;
        public static string browserText2;
        public static string browserText3_;
        public static string[] options = {"", "", "30", "=i@BMOjEF(ULJ;,. " };
        public static double divider = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void browser1(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox1.Text = fileDialog.SelectedPath;
                browserText1 = fileDialog.SelectedPath;
            }
        }

        private void browser2(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox2.Text = folderDialog.SelectedPath;
                browserText2 = folderDialog.SelectedPath;
            }
        }

        private void ViewClick(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void OpexExistingClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                BrowserText3.Text = folderDialog.SelectedPath;
                browserText3_ = folderDialog.SelectedPath; ;
                passing = folderDialog.SelectedPath + @"\Storage";
                
                Preview.Text = Methods.readFile(folderDialog.SelectedPath + @"\Storage\Video\1.txt");
            }
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConvertClick(object sender, EventArgs e)
        {
            Convert convert = new Convert();
            convert.test(TextBox1.Text, TextBox2.Text);

            Form3 form = new Form3();
            Form3.type = "convert";
            Form3.labelString = TextBox2.Text;

            form.ShowDialog();
            if (Directory.Exists(@"D:\User\Darbvisma\%TEMP-1111%")) {
                Directory.Delete(@"D:\User\Darbvisma\%TEMP-1111%", true);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox1.Text = @"D:\Stream";
            browserText1 = TextBox1.Text;
            Timer t = new Timer();
            t.Interval = 50;
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();
            Text = "Video ASCII";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text.Trim()) && !string.IsNullOrEmpty(TextBox2.Text.Trim())) {
                Convert.Enabled = true;
                Options.Enabled = true;
            }

            if (!string.IsNullOrEmpty(BrowserText3.Text.Trim())) {
                View.Enabled = true;
            }
        }

        private void Options_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            browserText1 = TextBox1.Text;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            browserText2 = TextBox2.Text;
        }
    }
}
