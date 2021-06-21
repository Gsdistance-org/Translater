using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater
{
    public class LangCore
    {
        public static string Getfileout (string lang , string input)
        {
            try
            {
                string trfilepath = (@".\" + Env.trdestfolder + lang + input + Env.formatfiletype);
                string fileinput = File.ReadAllText(trfilepath).ToString();
                return fileinput;
            }
            catch(Exception ex)
            {
                string errorfile = @".\error.error";
                string error = (Convert.ToString(ex));
                File.WriteAllText(errorfile , error);
                return "ERROR" + ex;
            }
            finally
            {

            }
        }
    }
}
