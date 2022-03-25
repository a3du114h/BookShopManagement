using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class AgentPay : Form
    {
        public AgentPay()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;
        string a, b, x,dt;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = pend.Text;
            b = paid.Text;
            x = pay.Text;
            y = Convert.ToDouble(a)- Convert.ToDouble(x);
            f = Convert.ToDouble(x)+Convert.ToDouble(b);
            
            string query = "UPDATE ["+comcustom.Text+ "_Record] SET paid='" + f.ToString() + "' ,remain='" + y.ToString() + "' where dat = '" + DateTime.Parse(dt) + "'";
            SqlDataAdapter SA = new SqlDataAdapter(query, con);
            SA.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Paid Successfully.");

        }

        private void comcustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            try
            {
                SqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                dt = dateTimePicker1.Value.ToShortDateString();
                cmd.CommandText = "SELECT * from ["+comcustom.Text+"_Record] where dat = '"+DateTime.Parse(dt)+"'";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                foreach (DataRow dr in db.Rows)
                {
                   paid.Text= dr["paid"].ToString();
                    pend.Text = dr["remain"].ToString();
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        double f = 0, y = 0;

        private void AgentPay_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            try
            {
                SqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * from [agent]";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                comcustom.Items.Clear();
                comcustom.Items.Add("--Select--");
                foreach (DataRow dr in db.Rows)
                {
                    comcustom.Items.Add(dr["name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
