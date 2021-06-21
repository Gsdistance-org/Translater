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
            string trlang = (this.txtTrLang.Text);
            string trinput = (this.txtSrc.Text);
            string trfilepath = (@".\" + trlang + trinput);
            string fileinput = File.ReadAllText(trfilepath);
            this.txtOut.Text = (fileinput);
        }

        private void OfflineTranslater_Load(object sender, EventArgs e)
        {

        }
    }
}
