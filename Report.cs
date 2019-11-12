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
    public partial class Report : MetroFramework.Forms.MetroForm
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void addmember_Click(object sender, EventArgs e)
        {
            monthlyincome mi = new monthlyincome();
            mi.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            income_report ir = new income_report();
            ir.Show();
            this.Hide();
        }
    }
}
