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
    public partial class monthlyincome : MetroFramework.Forms.MetroForm
    {
        public monthlyincome()
        {
            InitializeComponent();
        }

        private void monthlyincome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.Payment' table. You can move, or remove it, as needed.
            this.PaymentTableAdapter.Fill(this.DataSet2.Payment);
            this.reportViewer1.RefreshReport();


        }
    }
}
