using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace VideoASCII
{
    class Convert
    {
        public static int numOfThreads = 8;
        public static Thread[] t = new Thread[numOfThreads];

        public static int[] shareIntD = new int[numOfThreads];
        public static int[] shareIntN = new int[numOfThreads];

        public static String value = Form1.options[3];

        public void test(String path, String path1) {
            //CREATES DIRECTORY
            Directory.CreateDirectory(path1 + @"\Storage\Video");
            Directory.CreateDirectory(path1 + @"\Video");
            Directory.CreateDirectory(path1 + @"\Screenshots");

            //CREATES AN IMAGE TO SET THE RESOLUTION FOR
            var image = Image.FromFile(path + @"\" + "scene00001.jpg");

            //SETS RESOLUTION IN OPTIONS
            if (string.IsNullOrEmpty(Form1.options[0].Trim())) { Form1.options[0] = ((int)(image.Width / 1.5)).ToString(); }
            if (string.IsNullOrEmpty(Form1.options[1].Trim())) { Form1.options[1] = ((int)(image.Height / 1.5)).ToString(); }

            //CREATES OPTIONS FILE
            Methods.createFile(path1 + @"\Storage\options.txt", Form1.options[0] + "б" + Form1.options[1] + "б" + Form1.options[2] + "б" + Form1.options[3]);

            path1 = path1 + @"\Storage\Video";

            //THREADS
            if (Directory.GetFiles(@path).Length < numOfThreads) {
                numOfThreads = Directory.GetFiles(@path).Length;
            }

            int directoryLength = Directory.GetFiles(@path).Length / numOfThreads;
            directoryLength *= numOfThreads;

            for (int i = 0; i < numOfThreads; i++) {
                shareIntD[i] = (directoryLength / numOfThreads * (i + 1)) + (i == numOfThreads - 1 ? Directory.GetFiles(@path).Length % numOfThreads : 0);
            }

            Convert convert = new Convert();
            for (int b = 0; b < numOfThreads; b++) {
                int i = b;
                Task.Factory.StartNew(() =>
                {
                    t[i] = Thread.CurrentThread;
                    convert.task(shareIntD[i], path, path1, (i == 0 ? 0 : shareIntD[i - 1]), i);
                });
            }
        }

        public void task(int count, string path, string path1, int b, int threadNumber) {
                for (int i = 1 + b; i <= count; i++)
                {
                    String path2 = i.ToString();
                    if (path2.Length == 1)
                    {
                        path2 = "scene0000" + i.ToString();
                    }
                    else if (path2.Length == 2)
                    {
                        path2 = "scene000" + i.ToString();
                    }
                    else if (path2.Length == 3)
                    {
                        path2 = "scene00" + i.ToString();
                    }
                    if (path2.Length == 4)
                    {
                        path2 = "scene0" + i.ToString();
                    }

                    Methods.createFile(path1 + @"\" + i + ".txt", show(images((int)(Double.Parse(Form1.options[0])), (int)(Double.Parse(Form1.options[1]) / Form1.divider), path + @"\" + path2 + ".jpg", i)));

                    shareIntN[threadNumber] = i;
            }
        }

       private String[] images(int width, int height, String path, int c)
        {
            String[] text = new String[height];
            String newImagePath = @"D:\User\Darbvisma\%TEMP-1111%";
            createFolder(newImagePath);

            using (Bitmap bitmap = (Bitmap)Image.FromFile(@path))
            {
                using (Bitmap newBitmap = new Bitmap(bitmap, width, height))
                {
                    newBitmap.SetResolution(width, height);
                    newBitmap.Save(newImagePath + @"\" + c + ".jpg", ImageFormat.Jpeg);

                    newBitmap.Dispose();
                }
                bitmap.Dispose();
            }

            Bitmap image = (Bitmap)FromFile(newImagePath + @"\" + c + ".jpg");

            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    Color color = image.GetPixel(b, i);
                    int myInt = (int)Math.Ceiling(Math.Round((Decimal)color.GetBrightness() * (value.Length - 1), 0, MidpointRounding.AwayFromZero));

                    text[i] += value[myInt];
                }

            }

            image.Dispose();

            return text;
        }

        public static Image FromFile(string path)
        {
            var bytes = File.ReadAllBytes(path);
            var ms = new MemoryStream(bytes);
            var img = Image.FromStream(ms);
            return img;
        }

        public static void createFolder(String path)
        {
            Directory.CreateDirectory(@path);
        }

        private String show(String[] array)
        {
            String text = "";
            for (int i = 0; i < array.Length; i++)
            {
                text += array[i] + (i == array.Length - 1 ? "" : "\r\n");
            }

            return text;
        }
    }
}
