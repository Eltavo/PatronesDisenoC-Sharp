using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTavo.AdapterPattern.Adaptee
{
    public class HelperLog
    {
        public void GuardarError(Exception ex)
        {
            using (var w = File.AppendText("log.txt"))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine("  :");
                w.WriteLine("  :{0}", ex.Message);
                w.WriteLine("-------------------------------");
                w.Write("\r\nError StackTrace : {0}", ex.StackTrace);
            }
        }
    }
}
