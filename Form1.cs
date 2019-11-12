using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymManagementSystem
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        SqlConnection cn = new SqlConnection("Data Source=MAHESHA-PC;Initial Catalog=GymManagementSystem;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (username.Text.Length == 0)
            {
                errorProvider1.SetError(username, "Enter Username");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (metroTextBox1.Text.Length== 0)
            {
                errorProvider2.SetError(metroTextBox1, "Enter Password");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (username.Text.Length!= 0 && metroTextBox1.Text.Length != 0)
            {
                try
                {


                    SqlDataAdapter da = new SqlDataAdapter("select * from Login where user_Name='" + username.Text + "'and password='" + metroTextBox1.Text + "' ", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)

                    {
                        Form2 f = new Form2(); //create second form of next to viwe
                        f.Show();
                        this.Hide(); //hide now working s creen
                    }
                    else
                    {
                        MessageBox.Show("wrong password or user name!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (metroTextBox1.Text.Length != 0 && username.Text.Length != 0)
            {

                MessageBox.Show("Password or username incorrect", " Warning !!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroTile1_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
