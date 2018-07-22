using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MathWeb.Models
{
    public class ReadDataBaiViet
    {
        public static String Read(string path)
        {
            
            return File.ReadAllText(path,System.Text.Encoding.Unicode);
        }
    }
}