﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater
{
    public class LangCore
    {
        public static string GetTranslateFileOut (string inputlang , string input , string outlang)
        {
            try
            {
                string trfilepath = (@".\" + Env.trdestfolder + @"\" + inputlang + "-" + outlang + @"\" + input + Env.formatfiletype);
                string fileinput = File.ReadAllText(trfilepath).ToString();
                return fileinput;
            }
            catch(Exception ex)
            {
                string errorfile = @".\error.error";
                string error = (Convert.ToString(ex));
                File.WriteAllText(errorfile , error);
                return "ERROR" + "/THE Exeption|" + ex;
            }
            finally
            {

            }
        }
    }
}
