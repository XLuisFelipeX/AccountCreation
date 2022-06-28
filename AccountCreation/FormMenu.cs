using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountCreation
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnCreation_Click(object sender, EventArgs e)
        {
           string strURL = "https://dev.idez.com.br/api/smart-signup";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync("https://dev.idez.com.br/api/smart-signup", content);
            }
        }
    }
}
