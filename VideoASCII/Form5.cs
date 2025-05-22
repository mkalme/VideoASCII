using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace VideoASCII
{
    public partial class Form5 : Form
    {
        public static string videoFilePath;
        public static string screenshotFilePath;

        public static Thread[] t = new Thread[Tools.numOfThreads];

        public Form5()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();

            //SETS LOCAL VARIABLE'S PATH
            textBox1.Text = Form1.browserText3_ + @"\Video";
            textBox3.Text = Form1.browserText3_ + @"\Screenshots";

            //SETS TITLE
            Text = "Options";
        }

        private void Video_Click(object sender, EventArgs e)
        {
            //THREADS

            if (Directory.GetFiles(Form1.browserText3_ + @"\Storage\Video").Length < Tools.numOfThreads)
            {
                Tools.numOfThreads = Directory.GetFiles(Form1.browserText3_ + @"\Storage\Video").Length;
            }

            int directoryLength = Directory.GetFiles(Form1.browserText3_ + @"\Storage\Video").Length / Tools.numOfThreads;
            directoryLength *= Tools.numOfThreads;

            for (int i = 0; i < Tools.numOfThreads; i++)
            {
                Tools.shareIntD[i] = (directoryLength / Tools.numOfThreads * (i + 1)) + (i == Tools.numOfThreads - 1 ? Directory.GetFiles(Form1.browserText3_ + @"\Storage\Video").Length % Tools.numOfThreads : 0);
            }

            Convert convert = new Convert();
            for (int b = 0; b < Tools.numOfThreads; b++)
            {
                int i = b;
                Task.Factory.StartNew(() =>
                {
                    t[i] = Thread.CurrentThread;
                    Tools.videoMaker((i == 0 ? 1 : Tools.shareIntD[i- 1]), Tools.shareIntD[i], textBox1.Text + @"\%TEMP%", i);
                });
            }

            Directory.CreateDirectory(textBox1.Text + @"\%TEMP%");

            Form3 form = new Form3();
            Form3.labelString = "Making a video file";
            Form3.type = "videoMaker";
            form.ShowDialog();

        }

        private void BrowseVideo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderDialog.SelectedPath;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            videoFilePath = textBox1.Text;
            screenshotFilePath = textBox3.Text;
        }

        private void Browse2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = folderDialog.SelectedPath;
            }
        }

        private void Screenshot_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            Tools.videoMaker(Form2.now, Form2.now, textBox3.Text, 0);
        }
    }
}
