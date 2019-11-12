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
    public partial class reception :MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=MAHESHA-PC;Initial Catalog=GymManagementSystem;Integrated Security=True");
        
        public reception()
        {
            InitializeComponent();
        }

        private void reception_Load(object sender, EventArgs e)
        {
            try
            {
                //display_data();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Manager", con);
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

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
            metroTextBox5.Text = "";
            metroTextBox6.Text = "";
        }

        private void addmember_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
