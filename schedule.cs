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
    public partial class schedule : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=MAHESHA-PC;Initial Catalog=GymManagementSystem;Integrated Security=True");
        
        public schedule()
        {
            InitializeComponent();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Form2  f =new Form2();
            f.Show();
            this.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void schedule_Load(object sender, EventArgs e)
        {

            try
            {
                //display_data();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Schedule", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
    }
}
