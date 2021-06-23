using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translater
{
    class Forms
    {
        public static void opensettings()
        {
            try
            {
                Application.Run(new Settingsform());
            }
            catch(Exception ex)
            {
                File.WriteAllText(@".\error.error", Convert.ToString(ex));
            }
            finally
            {

            }
        }
    }
}
