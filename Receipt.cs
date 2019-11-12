using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class Receipt :MetroFramework.Forms.MetroForm

    {
        public Receipt(string set_value, string mid, string mfname, string msname, string paymetod, string payamount, string amountreceived, string balanceam, string date1)
        {
            InitializeComponent();
            paymentid.Text = set_value;
            membernic.Text = mid;
            memberfname.Text = mfname;
            membersname.Text = msname;
            method.Text = paymetod;
            amount.Text = payamount;
            received.Text = amountreceived;
            balance.Text = balanceam;
            date.Text = date1;



        }

        private void Receipt_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            payment pa = new payment();
            pa.Show();
            this.Hide();
        }
    }
}
