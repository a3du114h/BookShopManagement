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
using BookShopManagement.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            if (globals.tp == "su")
            {
                button6.Visible = true;

                SqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * from [setting] where id='1'";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                foreach (DataRow dr in db.Rows)
                {
                    tag.Text = (dr["tag"].ToString());
                    mob1.Text = (dr["mob1"].ToString());
                    mob2.Text = (dr["mob2"].ToString());
                    tel.Text = (dr["tel"].ToString());
                    mail.Text = (dr["mail"].ToString());
                }

            }
            else
            {
                button6.Visible = false;

                SqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * from [setting] where id='1'";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                foreach (DataRow dr in db.Rows)
                {
                    tag.Text = (dr["tag"].ToString());
                    mob1.Text = (dr["mob1"].ToString());
                    mob2.Text = (dr["mob2"].ToString());
                    tel.Text = (dr["tel"].ToString());
                    mail.Text = (dr["mail"].ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE setting SET tag='" + tag.Text + "',mob1='" + mob1.Text + "',mob2='" + mob2.Text + "',tel='" + tel.Text + "',mail='" + mail.Text + "' WHERE id ='1'";
                SqlDataAdapter SA = new SqlDataAdapter(query, con);
                SA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Updated successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomBuy main = new CustomBuy();
            main.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgentPay main = new AgentPay();
            main.ShowDialog();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Expence main = new Expence();
            main.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Events main = new Events();
            main.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * from [blnc] where id='1'";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                foreach (DataRow dr in db.Rows)
                {
                    textBox1.Text = dr["balance"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
