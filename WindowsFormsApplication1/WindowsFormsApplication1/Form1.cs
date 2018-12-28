using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            int idx = int.Parse(tbNumber.Text.Trim());
            //ServiceReference1.WebService1SoapClient service1 = new ServiceReference1.WebService1SoapClient();
            ServiceReference2.WebService1SoapClient service1 = new ServiceReference2.WebService1SoapClient();
            try
            {
                string result = service1.ReportStatus(idx);
                lbResult.Text = result + DateTime.Now.ToString(" MM-dd HH:mm:ss");
            }
            catch (Exception ex)
            {

            }
        }
        private void btnRepair_Click(object sender, EventArgs e)
        {
            int idx = int.Parse(tbNumber.Text.Trim());
            //ServiceReference1.WebService1SoapClient service1 = new ServiceReference1.WebService1SoapClient();
            ServiceReference2.WebService1SoapClient service1 = new ServiceReference2.WebService1SoapClient();
            try
            {
                string result = service1.RepairStatus(idx);
                lbResult.Text = result + DateTime.Now.ToString(" MM-dd HH:mm:ss");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
