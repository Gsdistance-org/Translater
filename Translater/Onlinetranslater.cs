using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translater
{
    public partial class Onlinetranslater : Form
    {
        public Onlinetranslater()
        {
            InitializeComponent();
        }

        private void Onlinetranslater_Load(object sender, EventArgs e)
        {

        }

        private void btnDetectSrcLang_Click(object sender, EventArgs e)
        {
            var client = new RestClient()
            {
                BaseUrl = new Uri (string.Format(Env.UrlDetectSrcLang , Env.Apikey , txtSrc.Text))
            };
            var Request = new RestRequest()
            {
                Method = Method.GET
            };
            var Response = client.Execute.(Request);

            var Dict = JsonConvert.DeserializeObject<IDictionary>(Response.Content);

            var StatusCode = Dict["code"].ToString();
            if (StatusCode.Equals("200"))
            {
                lblSrcLang.Text = Dict["lang"].ToString();
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {

        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {

        }
    }
}
