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
                string trinlang = (this.txtTrInputLang.Text);
                string troutlang = (this.txtTrOutLang.Text);
                string trinput = (this.txtSrc.Text);
                this.txtOut.Text = (LangCore.GetTranslateFileOut(trinlang, trinput , troutlang));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
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
