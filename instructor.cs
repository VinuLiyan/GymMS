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
    public partial class instructor : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=MAHESHA-PC;Initial Catalog=GymManagementSystem;Integrated Security=True");

        public instructor()
        {
            InitializeComponent();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
            metroTextBox5.Text = "";
            metroTextBox6.Text = "";
            dateTimePicker1.ResetText();
            metroComboBox1.ResetText();

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            this.Hide();
            a.Show();
        }

        private void instructor_Load(object sender, EventArgs e)
        {
            try
            {
                //display_data();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Instructor", con);
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
