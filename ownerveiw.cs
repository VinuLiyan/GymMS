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
    public partial class ownerveiw : MetroFramework.Forms.MetroForm
    {
        public ownerveiw()
        {
            InitializeComponent();
        }

        private void reception_Click(object sender, EventArgs e)
        {
            reception re = new reception();
            re.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
            this.Hide();
        }
    }
}
