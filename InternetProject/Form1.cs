using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string DownloadData(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Credentials = CredentialCache.DefaultCredentials;

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                Stream res = response.GetResponseStream();
                Encoding encoding = Encoding.UTF8;

                StreamReader sr = new StreamReader(res,encoding);

                string str=sr.ReadToEnd();
                sr.Close();

                res.Close();
                return str;
            }
            finally
            {

            }
            return "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.hubu.edu.cn/";
            WebClient client = new WebClient();
            byte[] pageData = client.DownloadData(url);
            string pagehtml=Encoding.UTF8.GetString(pageData);
            richTextBox2.Text = pagehtml;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
