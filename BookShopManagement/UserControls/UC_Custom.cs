using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookShopManagement.UserControls
{
    public partial class UC_Custom : UserControl
    {
        public UC_Custom()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;

        private void UC_Custom_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            SqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * from [custom]";
            cmd.ExecuteNonQuery();
            DataTable db = new DataTable();
            SqlDataAdapter dq = new SqlDataAdapter(cmd);
            dq.Fill(db);
           comcustom.Items.Clear();
            comcustom.Items.Add("--Select--");
            foreach (DataRow dr in db.Rows)
            {
                comcustom.Items.Add(dr["nam"].ToString());
            }
            comcustom.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;

        }

        private void comcustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comcustom.Text != "--Select--")
            {
                SqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * from [custom] where nam='"+comcustom.Text+"'";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                foreach (DataRow dr in db.Rows)
                {
                    txtadr.Text = (dr["adrs"].ToString());
                    txtcon.Text = (dr["con"].ToString());
                    txtdisc.Text = (dr["disc"].ToString());
                    txtinrname.Text = (dr["indnam"].ToString());
                    txtinrcon.Text = (dr["indcon"].ToString());
                    txtinradr.Text = (dr["indadrs"].ToString());
                    string spee = (dr["special"].ToString());
                    checkBox1.Checked = Convert.ToBoolean(spee);
                    comboBox1.Text = (dr["city"].ToString());
                }
            }
            else
            {
                txtadr.Clear();
                txtcon.Clear();
                txtdisc.Clear();
                txtinradr.Clear();
                txtinrcon.Clear();
                txtinrname.Clear();
                
            }
        }

        private void txtcon_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    SqlCommand cmd;
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT * from [custom] where con='" + txtcon.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable db = new DataTable();
                    SqlDataAdapter dq = new SqlDataAdapter(cmd);
                    dq.Fill(db);
                    foreach (DataRow dr in db.Rows)
                    {
                        txtadr.Text = (dr["adrs"].ToString());
                        comcustom.Text = (dr["nam"].ToString());
                        txtdisc.Text = (dr["disc"].ToString());
                        txtinrname.Text = (dr["indnam"].ToString());
                        txtinrcon.Text = (dr["indcon"].ToString());
                        txtinradr.Text = (dr["indadrs"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        private void btncr_Click(object sender, EventArgs e)
        {
            try
            {
                bool spe = checkBox1.Checked;
                string uery = "SELECT count(*) FROM custom WHERE nam = '" + comcustom.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(uery, con);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Customer already exists. Please update the customer or create a new one with different name.");
                }
                else { 
                string quer = "INSERT INTO [custom] (nam,con,adrs,indcon,indadrs,indnam,disc,city,special) VALUES ('" + comcustom.Text + "','" + txtcon.Text + "','" + txtadr.Text + "','" + txtinrcon.Text + "','" + txtinradr.Text + "','" + txtinrname.Text + "','" + txtdisc.Text + "','" + comboBox1.Text + "','" + spe.ToString() + "')";
                SqlDataAdapter SD = new SqlDataAdapter(quer, con);
                SD.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted successfully.");
                    string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Customer named " + comcustom.Text + " was created')";
                    SqlDataAdapter SDa = new SqlDataAdapter(que, con);
                    SDa.SelectCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE custom SET adrs='" + txtadr.Text + "',indnam='" + txtinrname.Text + "',indadrs='" + txtinradr.Text + "',disc='" + txtdisc.Text + "',nam='" + comcustom.Text + "' WHERE con ='" + txtcon.Text + "'";
                SqlDataAdapter SA = new SqlDataAdapter(query, con);
                SA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Updated successfully");
                string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Customer named " + comcustom.Text + " was updated')";
                SqlDataAdapter SD = new SqlDataAdapter(que, con);
                SD.SelectCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM custom WHERE nam ='" + comcustom.Text + "' AND con='" + txtcon.Text + "'";
                SqlDataAdapter SA = new SqlDataAdapter(query, con);
                SA.SelectCommand.ExecuteNonQuery();
                string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Customer named " + comcustom.Text + " was deleted')";
                SqlDataAdapter SD = new SqlDataAdapter(que, con);
                SD.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Deleted successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "SELECT * FROM custom";
                SqlDataAdapter SD = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                SD.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtcon.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtinrcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtinrcon.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
