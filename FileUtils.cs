using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Expertsystem
{
    class FileUtils
    {
        public static string read_data(string data_path)
        {
            string text = null;
            FileStream fs = new FileStream(data_path, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            return text;
        }
    }
}
