using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Translater
{
    public partial class OfflineTranslater : Form
    {
        public OfflineTranslater()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                string trlang = (this.txtTrLang.Text);
                string trinput = (this.txtSrc.Text);
                this.txtOut.Text = (LangCore.Getfileout(trlang, trinput));
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
            
        }

        private void OfflineTranslater_Load(object sender, EventArgs e)
        {

        }
    }
}
