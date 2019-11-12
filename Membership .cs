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
    public partial class Membership : MetroFramework.Forms.MetroForm
    {
        public Membership(string a, string b, string c, string d ,string f, string g, string h, string i)
        {
            InitializeComponent();
            metroTextBox2.Text =a;
            metroTextBox3.Text =b;
            metroTextBox7.Text =c;
            metroTextBox4.Text =d;
            metroTextBox5.Text =f;
            metroTextBox8.Text =g;
            metroTextBox1.Text =h;
            metroTextBox6.Text =i;

                



        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Member mb = new Member();
            mb.Show();
            this.Hide();
        }
    }
}
