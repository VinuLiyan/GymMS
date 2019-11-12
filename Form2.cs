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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            
            InitializeComponent();
        }

        private void member_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            m.Show();
            this.Hide();
        }

        private void instructor_Click(object sender, EventArgs e)
        {
            instructor i = new instructor();
            i.Show();
            this.Hide();
        }

        private void attendance_Click(object sender, EventArgs e)
        {
            Form3attendance at = new Form3attendance();
            at.Show();
            this.Hide();
        }

        private void payment_Click(object sender, EventArgs e)
        {
            payment p = new payment();
            p.Show();
            this.Show();
        }

        private void shedule_Click(object sender, EventArgs e)
        {
            schedule sc = new schedule();
            sc.Show();
            this.Hide();

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reception_Click(object sender, EventArgs e)
        {
            //reception r = new reception();
            //r.Show();
            //this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ownerlogin ol = new ownerlogin();
            ol.Show();
            this.Hide();
        }
    }
}
