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
    public partial class CustomBuy : Form
    {
        public CustomBuy()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;
        string a, b, c, d, x;
        bool spe;

        private void comcustom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            spe = checkBox1.Checked;
            if (spe == true)
            {
                label6.Visible = false;
                pay.Visible = false;
                label5.Visible = true;
                pur.Visible = true;

            }
            else if (spe == false)
            {
                label6.Visible = true;
                pay.Visible = true;
                label5.Visible = false;
                pur.Visible = false;
            }
        }

        double f = 0, g = 0, h = 0, i = 0, y = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

             if (spe == true)
            {
                    a = blnce.Text;
                    b = paid.Text;
                    c = pend.Text;
                    d = pur.Text;
                    f = Convert.ToDouble(a);
                    g = Convert.ToDouble(b);
                    h = Convert.ToDouble(c);
                    i = Convert.ToDouble(d);

                    double p = f + i;

                string query = "UPDATE blnc SET balance='" + p.ToString() + "' WHERE id ='1'";
                SqlDataAdapter SA = new SqlDataAdapter(query, con);
                SA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Insert Successful.");
                    string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Balance updated by " + comcustom.Text + "')";
                    SqlDataAdapter SDa = new SqlDataAdapter(que, con);
                    SDa.SelectCommand.ExecuteNonQuery();

                }
                else if (spe == false)
            {
                    a = blnce.Text;
                    b = paid.Text;
                    c = pend.Text;
                    x = pay.Text;
                    y = Convert.ToDouble(x);
                    f = Convert.ToDouble(a);
                    g = Convert.ToDouble(b);
                    h = Convert.ToDouble(c);
                   
                    double s = f - y;

                string query = "UPDATE blnc SET balance='" + s.ToString() + "' WHERE id ='1'";
                SqlDataAdapter SA = new SqlDataAdapter(query, con);
                MessageBox.Show("Insert Successful.");
                    string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Balance degraded by " + comcustom.Text + "')";
                    SqlDataAdapter SDa = new SqlDataAdapter(que, con);
                    SDa.SelectCommand.ExecuteNonQuery();

                }
            }
            catch(Exception ex){
                MessageBox.Show("Error: "+ex.Message);    
        }
        }

        private void CustomBuy_Load(object sender, EventArgs e)
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

                cmd.CommandText = "SELECT * from [custom] where special='true'";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
                    blnce.Text = dr["balance"].ToString();
                    paid.Text = dr["paid"].ToString();
                    pend.Text = dr["pending"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
