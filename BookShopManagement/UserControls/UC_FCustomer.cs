using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;
using System.Data.SqlClient;

namespace BookShopManagement.UserControls
{
    public partial class UC_FCustomer : UserControl
    {
        public UC_FCustomer()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
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

                cmd.CommandText = "SELECT * from [invoice] where custom='"+comcustom.Text+"' and disc like'%"+textBox2.Text+"%' and con like '%"+textBox7.Text+"%'";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                dataGridView1.Rows.Clear();
                foreach (DataRow dr in db.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dr["invno"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr["type"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dr["inr"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = dr["total"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = dr["dater"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = dr["remain"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = dr["instat"].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = dr["credit"].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = dr["debit"].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = dr["prof"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = dr["aed"].ToString();
                }
                double b,qq=0,w=0,ww=0, r = 0, rr = 0, c = 0, cc = 0;
                string x = "0",y = "0",z = "0",xx = "0";
                int p = dataGridView1.Rows.Count - 1;
                for (int n = 0; n < p; n++)
                {
                    x = dataGridView1.Rows[n].Cells["Paid"].Value.ToString();
                    b = Convert.ToDouble(x);
                    qq = b + qq;//Price total
                    y = dataGridView1.Rows[n].Cells["INR"].Value.ToString();
                    w = Convert.ToDouble(y);
                    ww = b + ww;//Price total
                    xx = dataGridView1.Rows[n].Cells["Debit"].Value.ToString();
                    r = Convert.ToDouble(xx);
                    rr = r + rr;//Price total
                    z = dataGridView1.Rows[n].Cells["Pending"].Value.ToString();
                    c = Convert.ToDouble(z);
                    cc = c + cc;//Price total
                }
                label5.Text = qq.ToString();
                label2.Text =ww.ToString();
                label8.Text =rr.ToString();
                label4.Text =cc.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void UC_FCustomer_Load(object sender, EventArgs e)
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
                comcustom.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
    }
}
