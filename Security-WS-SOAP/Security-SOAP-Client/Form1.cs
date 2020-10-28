using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_SOAP_Client
{
    public partial class Form1 : Form
    {

        ReferenceTestService.TestServiceClient testServiceClient = new ReferenceTestService.TestServiceClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultGetData = testServiceClient.GetData(Int32.Parse(textBox1.Text));
            MessageBox.Show(resultGetData);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Trust all certificates
            System.Net.ServicePointManager.ServerCertificateValidationCallback =
            (send, certificate, chain, sslPolicyErrors) => true;

            testServiceClient.ClientCredentials.UserName.UserName = "jmendoza";
            testServiceClient.ClientCredentials.UserName.Password = "123456";
        }
    }
}
