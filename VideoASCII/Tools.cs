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
    class Tools
    {
        public static int numOfThreads = 8;

        public static int[] shareIntD = new int[numOfThreads];
        public static int[] shareIntN = new int[numOfThreads];

        public static SizeF size;

        public static void videoMaker(int start, int end, string path, int threadNumber)
        {
            for (int i = start; i <= end; i++)
            {
                int fontSize = 12;

                string inputString = File.ReadAllText(Form1.passing + @"\Video\" + i + @".txt");

                using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
                {
                    size = graphics.MeasureString(inputString, new Font("Lucida Console", fontSize, FontStyle.Regular, GraphicsUnit.Point));
                }

                Bitmap bmp = new Bitmap((int)size.Width, (int)size.Height);

                Graphics formGraphics = Graphics.FromImage(bmp);

                formGraphics.Clear(Color.White);

                formGraphics.SmoothingMode = SmoothingMode.None;
                Font drawFont = new Font("Lucida Console", fontSize);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                float x1 = 0F;
                float y1 = 0F;
                StringFormat drawFormat = new StringFormat();
                formGraphics.DrawString(inputString, drawFont, drawBrush, x1, y1, drawFormat);

                bmp.Save(path + @"\image_" + i + ".png");//save the image file

                drawFont.Dispose();
                drawBrush.Dispose();
                formGraphics.Dispose();

                shareIntD[threadNumber] = end;
                shareIntN[threadNumber] = i;
            }
        }
    }
}
