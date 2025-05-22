using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VideoASCII
{
    class Methods
    {
        public static void createFile(string path, string text) {
            try
            {
                using (var tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(text);
                    tw.Close();
                    tw.Dispose();
                }
            }
            catch {
            }
        }

        public static String readFile(string path)
        {
            String text = "";
            try
            {
                text = File.ReadAllText(path);
            }
            catch
            {
            }

            return text;
        }
    }
}
