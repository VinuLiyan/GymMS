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
    public partial class ownerlogin : MetroFramework.Forms.MetroForm
    {
        SqlConnection cn = new SqlConnection("Data Source=MAHESHA-PC;Initial Catalog=GymManagementSystem;Integrated Security=True");
        public ownerlogin()
        {
            InitializeComponent();
        }

        private void instructor_Click(object sender, EventArgs e)
        {
            try
            {


                SqlDataAdapter da = new SqlDataAdapter("select * from Login where password ='" + username.Text + "'", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)

                {
                    ownerveiw r = new ownerveiw();
                    r.Show();
                    this.Hide();
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
    }
}
