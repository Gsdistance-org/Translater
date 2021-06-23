using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater
{
    class Testfor
    {
        public static string Testforfile (string path)
        {
            try
            {
                File.ReadAllText(path);
                return "exists";
            }
            catch (Exception ex)
            {
                return "dont exists";
            }
            finally
            {

            }
        }
    }
}
