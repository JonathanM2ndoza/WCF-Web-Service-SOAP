using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOAP_Client
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
            string resultGetData = testServiceClient.GetData(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
            MessageBox.Show(resultGetData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReferenceTestService.CompositeType compositeType = new ReferenceTestService.CompositeType();
            compositeType.BoolValue = true;
            compositeType.StringValue = textBox3.Text;

            ReferenceTestService.CompositeType resultCompositeType = testServiceClient.GetDataUsingDataContract(compositeType);
            MessageBox.Show(resultCompositeType.StringValue);
        }
    }
}
