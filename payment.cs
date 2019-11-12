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
    public partial class payment : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=MAHESHA-PC;Initial Catalog=GymManagementSystem;Integrated Security=True");
        SqlCommand cmd;
       // SqlDataAdapter da;
       // DataTable dt;
        public payment()
        {
            InitializeComponent();

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void payment_Load(object sender, EventArgs e)
        {
            ////combobox fill query with database [01]
            //mnic.Text = "";
            //con.Open();
            //cmd = new SqlCommand("select M_NIC from Member", con);
            //cmd.ExecuteNonQuery();
            //dt = new DataTable();
            //da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //foreach (DataRow dr1 in dt.Rows)
            //{
            //    comboBox1.Items.Add(dr1["M_NIC"]);
            //}
            //con.Close();

            

            display_data();
            con.Open();
            //// Auto increment Pid
            ////SqlDataAdapter ad = new SqlDataAdapter("select isnull(max(cast(P_ID asint)),0)+1 from Payment", con);
            ////DataTable dt = new DataTable();

            ////ad.Fill(dt);
            ////paymentid.Text = dt.Rows[0][0].ToString();
            ////con.Close();

            //auto generate and icrement PID
           
            cmd = new SqlCommand("Select Max(P_ID)+1 from Payment", con);
            var dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    paymentid.Text = dr[0].ToString();
                    if (paymentid.Text == "")
                    {
                        paymentid.Text = "1";

                    }
                }
            }
            else
            {
                paymentid.Text = "1";
                return;
            }

            con.Close();



        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
            membersname.Text = "";
            paymentid.Text = "";
            mnic.Text = "";
            memberfname.Text = "";
            paymentamount.Text = "";
            amountreceved.Text = "";
            balancepay.Text = "";
            //metroComboBox1.Items.Clear();

            //when click the refresh button auto increment the P_ID
            con.Open();
            cmd = new SqlCommand("Select Max(P_ID)+1 from Payment", con);
            var dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    paymentid.Text = dr[0].ToString();
                    if (paymentid.Text == "")
                    {
                        paymentid.Text = "1";

                    }
                }
            }
            else
            {
                paymentid.Text = "1";
                return;
            }

            con.Close();
            //finish auto increment code

        }

        private void addmember_Click(object sender, EventArgs e)
        {
            //start validation
            if (mnic.Text.Length == 0)
            {
                errorProvider1.SetError(mnic, "Enter Member NIC");
            }
            else
            {
                errorProvider1.Clear();
            }
            

            if (memberfname.Text.Length == 0)
            {
                errorProvider2.SetError(memberfname, "Enter Member First Name");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (membersname.Text.Length == 0)
            {
                errorProvider3.SetError(membersname, "Enter Member Secound Name");
            }

            else
            {
                errorProvider3.Clear();
            }

            if (paymentamount.Text.Length == 0)
            {
                errorProvider4.SetError(paymentamount, "Enter Payment amount");
            }
            else
            {
                errorProvider4.Clear();
            }

            if (amountreceved.Text.Length == 0)
            {
                errorProvider5.SetError(amountreceved, "Enter Amount Received");
            }
            else
            {
                errorProvider5.Clear();
            }

            if (balancepay.Text.Length == 0)
            {
                errorProvider6.SetError(balancepay, "Enter Balance Pay");
            }
            else
            {
                errorProvider6.Clear();
            }

            if (dateTimePicker1.Value == DateTime.Today)
            {
                errorProvider7.SetError(dateTimePicker1, "Select Birthday");
            }
            else
            {
                errorProvider7.Clear();
            }

            if (metroComboBox1.Text == "Select One")
            {
                errorProvider8.SetError(metroComboBox1, "Select Payment Type");
            }
            else
            {
                errorProvider8.Clear();
            }
             //end of validation

            if (mnic.Text.Length!=0 && memberfname.Text.Length != 0 && metroComboBox1.Text != "Select One" && dateTimePicker1.Value != DateTime.Today && membersname.Text.Length != 0 && amountreceved.Text.Length != 0 && paymentamount.Text.Length != 0 && balancepay.Text.Length != 0)
            {

                DialogResult dr = MessageBox.Show("Do you want to save your details?", " Warning !!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr.ToString() == "Yes")
                {

                    try
                    {
                        con.Open();
                        String method = Convert.ToString(metroComboBox1.SelectedItem);//convert combo box value
                        
                        string dob = dateTimePicker1.Value.ToString();
                        cmd = new SqlCommand("insert into Payment values('" + paymentid.Text + "','"+method+"','" + paymentamount.Text + "','" + dob + "','" + amountreceved.Text + "','" + balancepay.Text + "','"+mnic.Text+"')", con);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("inserted");
                        con.Close();

                        //display_data();
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter("select * from Payment", con);
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

            
        
    
        
        public void display_data()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Payment", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
           

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            //to pass the values form payment screen to Receipt screen
            Receipt Re = new Receipt(paymentid.Text, mnic.Text, memberfname.Text, membersname.Text, metroComboBox1.Text, paymentamount.Text, amountreceved.Text, balancepay.Text, dateTimePicker1.Text);
            Re.ShowDialog(); //Re.Show();not use because  if it use can not hold the page
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String method = Convert.ToString(metroComboBox1.SelectedItem);//convert combo box value
                string dob = dateTimePicker1.Value.ToString();
                cmd = new SqlCommand("update Payment set  P_Method= '" + method + "' , P_Amount= '" + paymentamount.Text + "' , P_Date= '" + dob + "' , Amount_Received= '" + amountreceved.Text + "' , Balance_Pay= '" + balancepay.Text + "' where M_NIC=  '" + mnic.Text+ "' ", con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
                con.Close();

                //display_data();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Payment", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                paymentid.Text = "";
                mnic.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            // no delete button

            //try
            //{
            //    con.Open();

            //    cmd = new SqlCommand("delete from Payment where M_NIC= '"+membernic.Text+ "' OR P_ID='" + paymentid.Text+"'",con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Deleted");
            //    con.Close();

            //    //display_data();
            //    con.Open();
            //    SqlDataAdapter da = new SqlDataAdapter("select * from Payment", con);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    con.Close();
            //    paymentid.Text = "";
            //    membernic.Text="";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void metroTile1_Click(object sender, EventArgs e)
        { 
            //need to do!!!!!!!!!!!!!!
            //if (metroTextBox1.Text.Length == 0 && metroTextBox1.Text.=M_NIC)
            //{
            //    errorProvider9.SetError(membernic, "Enter Member Nic");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}

            try
            {
                
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Payment where M_NIC= '" + metroTextBox1.Text + "' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                metroTextBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //auto generate member name when enter the member nic [03]


            //con.Open();

            //cmd = new SqlCommand("select * from Member  where M_NIC='" + metroComboBox2.Text + "'", con);
            //cmd.ExecuteNonQuery();
            //SqlDataReader sdr;
            //sdr = cmd.ExecuteReader();
            //while (sdr.Read())
            //{

            //    string Fname = (string)sdr["M_first_Name"];
            //    memberfname.Text = Fname;
            //    string sname = (string)sdr["M_Secound_Name"];
            //    membersname.Text = sname;
            //}
            //con.Close();

        }

        private void balancepay_Click(object sender, EventArgs e)
        {
            int tot;
            tot = Convert.ToInt32(amountreceved.Text) - Convert.ToInt32(paymentamount.Text);
            balancepay.Text = Convert.ToString(tot);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //auto generate member name when enter the member nic [02]
        //    con.Open();

        //    cmd = new SqlCommand("select * from Member  where M_NIC='" + comboBox1.Text + "'", con);
        //    cmd.ExecuteNonQuery();
        //    SqlDataReader sdr;
        //    sdr = cmd.ExecuteReader();
        //    while (sdr.Read())
        //    {

        //        string Fname = (string)sdr["M_first_Name"];
        //        memberfname.Text = Fname;
        //        string sname = (string)sdr["M_Secound_Name"];
        //        membersname.Text = sname;
        //    }
        //    con.Close();

        }

        private void mnic_Click(object sender, EventArgs e)
        {


        }

        private void memberfname_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("select * from Member  where M_NIC='" + mnic.Text + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                string Fname = (string)sdr["M_first_Name"];// [database colom name]
                memberfname.Text = Fname;
                string sname = (string)sdr["M_Secound_Name"];
                membersname.Text = sname;
            }
            con.Close();
        }
    }
}
