using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace VideoASCII
{
    public partial class Form2 : Form {

        public static int type = 1;

        public Form2()
        {
            InitializeComponent();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e) {

        }

        public static int b = 1;
        public static int now;
        int v = Directory.GetFiles(Form1.passing + @"/Video").Length;
        String[] tokens = Methods.readFile(Form1.passing + "/options.txt").Split('б');

        private void Form2_Load(object sender, EventArgs e)
        {
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Maximum = v;
            trackBar1.Minimum = 1;
            stage("pc");

            CenterToScreen();
            Text = "Video ASCII - Playing";
        }

        private void stage(string type) {
            //GETS OPTIONS
            int resolutionWidth = Int32.Parse(tokens[0]);
            int resolutionHeight = Int32.Parse(tokens[1]);

            //CHANGES FONT
            double fontSizeX = 1280 / resolutionWidth;
            double fontSizeY = 720 / resolutionHeight;

            int fontSize = 0;
            if (fontSizeX == fontSizeY || fontSizeX > fontSizeY)
            {
                fontSize = (int)fontSizeX;
            }
            else if (fontSizeX < fontSizeY)
            {
                fontSize = (int)fontSizeY;
            }


            TextBox5.Font = new Font("Lucida Console", (fontSize < 1 ? 1 : fontSize));
            TextBox5.SelectionAlignment = HorizontalAlignment.Center;


            timer1.Interval = 66;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b >= v + 1|| b <= 0)
            {
                
            }else {
                displayImage(b, "pc");
                b += type;
            }
        }

        public void displayImage(int i, string type) {
            TextBox5.Text = File.ReadAllText(Form1.passing + @"\Video\" + i + @".txt");

            if (type.Equals("pc")) {
                trackBar1.Value = i;
            }

            frames.Text = i + @"/" + v;
            now = i;
        }

        private void Tools_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (Pause.Text == "Pause") {
                Pause.Text = "Resume";
                timer1.Stop();
            }else if (Pause.Text == "Resume")
            {
                Pause.Text = "Pause";
                timer1.Start();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (Pause.Text == "Pause")
            {
                b = trackBar1.Value;
            }
            else if (Pause.Text == "Resume")
            {
                b = trackBar1.Value;
                displayImage(b, "user");
            }
        }
    }
}
