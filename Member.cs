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
    public partial class Member : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=MAHESHA-PC;Initial Catalog=GymManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        

        public Member()
        {
            InitializeComponent();
        }

        private void addmember_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String gender = Convert.ToString(metroComboBox1.SelectedItem);//convert combo box value
                //String instructor = Convert.ToString(metroComboBox2.SelectedItem);
                string dob = dateTimePicker1.Value.ToString();

                cmd = new SqlCommand("insert into Member values('" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox7.Text + "','" + metroTextBox4.Text + "','" + metroTextBox10.Text + "','" + metroTextBox5.Text + "','" + metroTextBox8.Text + "','" + gender + "','" + dob + "','" + metroTextBox6.Text + "','" + metroTextBox12.Text + "')", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted");
                con.Close();

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Member", con);
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

        private void metroTile6_Click(object sender, EventArgs e)
        {
           Form2 a = new Form2();
           this.Hide();
           a.Show();

            
            

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

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

        private void Member_Load(object sender, EventArgs e)
        {

            // display_data();
            try
            {

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Member", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Membership me = new Membership (metroTextBox2.Text,metroTextBox3.Text, metroTextBox7.Text,metroTextBox4.Text, metroTextBox5.Text,metroTextBox8.Text,metroComboBox1.Text,dateTimePicker1.Text);
            me.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("select * from Instructor  where I_NIC='" + metroTextBox12.Text + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                string Fname = (string)sdr["I_first_Name"];
                metroTextBox9.Text = Fname;
                string sname = (string)sdr["I_Secound_Name"];
                metroTextBox11.Text = sname;
            }
            con.Close();

        }

        public void display_data()
        {


            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Member", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }
    }
}
