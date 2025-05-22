using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace VideoASCII
{
    public partial class Form3 : Form
    {
        public static int maximum;
        public static int now;
        public static string labelString;
        public static string timeString;
        public static int shareIntN = 0;

        public static string type;

        private double seconds = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (type.Equals("convert"))
            {
                convertButtons("stop");
            }
            else if (type.Equals("videoMaker"))
            {
                videoMakerButtons("stop");
            }

            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (type.Equals("convert")) {
                convertButtons("cancel");
            } else if (type.Equals("videoMaker")) {
                videoMakerButtons("cancel");
            }

            Close();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();

            label1.Text = labelString;
            CenterToScreen();
            Text = "Loading...";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double check = Math.Round(seconds % 1, 1, MidpointRounding.AwayFromZero);

            if (type.Equals("convert"))
            {
                convert();
            }
            else if (type.Equals("videoMaker")) {
                videoMaker();
            }
            else
            {
                maximum = 1;
                now = 0;
            }

            progressBar1.Maximum = (maximum <= 0 ? 1 : maximum);
            progressBar1.Value = (shareIntN <= 0 ? 0 : shareIntN);

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                Close();
            }

            if (seconds > 5 && (check == 1 || check == 0))
            {
                double count = ((double)maximum / (double)shareIntN) * seconds;
                count -= seconds;

                String text = "";
                if (count < 60) {
                    text = ((int)count).ToString() + " seconds";
                } else if (count > 59 && count < 3600) {
                    text = ((int)(count / 60)).ToString() + " minutes";
                    int reminder = (int)(count % 60);

                    text += (reminder > 0 ? " " + reminder + " seconds" : "");
                } else if (count > 3599) {
                    text = ((int)(count / 3600)).ToString() + " hours ";
                    int reminder = (int)((count % 3600) / 6);

                    if (reminder > 59)
                    {
                        reminder /= 60;
                        text += (reminder > 0 ? reminder + " minute" : "");
                        text += (reminder > 1 ? "s" : "");
                    }
                }

                label2.Text = "Calculated time left: " + text + ".";
            }
            seconds += 0.1;
        }

        private void convert() {
            maximum = Convert.shareIntD[Convert.shareIntD.Length - 1];

            shareIntN = Directory.GetFiles(Form1.browserText2 + @"\Storage\Video").Length;
            /*for (int i = Convert.numOfThreads - 1; i >= 0; i--) {
                shareIntN += Convert.shareIntN[i] - (i == 0 ? 0 : Convert.shareIntD[i - 1]);
            }*/
        }

        private void convertButtons(string type) {
            if (type.Equals("stop")) {
                for (int i = 0; i < Convert.numOfThreads; i++)
                {
                    Convert.t[i].Abort();
                }

                Directory.Delete(@"D:\User\Darbvisma\%TEMP-1111%", true);
            }
            else {
                for (int i = 0; i < Convert.numOfThreads; i++)
                {
                    Convert.t[i].Abort();
                }

                Directory.Delete(@"D:\User\Darbvisma\%TEMP-1111%", true);
            }
        }

        private void videoMaker() {
            try
            {
                maximum = Tools.shareIntD[Tools.numOfThreads - 1];
                shareIntN = Directory.GetFiles(Form5.videoFilePath + @"\%TEMP%").Length;
            }
            catch {
            }
        }

        private void videoMakerButtons(string type) {
            for (int i = 0; i < Tools.numOfThreads; i++) {
                Form5.t[i].Abort();
            }

            if (type.Equals("cancel"))
            {
                DirectoryInfo directory = new DirectoryInfo(Form5.videoFilePath);
                foreach (FileInfo file in directory.GetFiles())
                {
                    //file.Delete();
                }
            }
        }
    }
}
