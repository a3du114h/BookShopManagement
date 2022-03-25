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
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;

   
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            try
            {
                string query = "SELECT count(*) FROM custom ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                if (dt.Rows[0][0].ToString() != "0")
                {
                    label7.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    label7.Text = "00";
                }
                SqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * from invoice";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                double xxx=0;
                foreach (DataRow dr in db.Rows)
                {
                    xxx =Convert.ToDouble(dr["debit"].ToString())+xxx;
                }
                dbt.Text = xxx.ToString();
                cmd.CommandText = "SELECT * from [blnc] where id='1'";
                cmd.ExecuteNonQuery();
                DataTable dbd = new DataTable();
                SqlDataAdapter dqd = new SqlDataAdapter(cmd);
                dqd.Fill(dbd);
                foreach (DataRow dr in dbd.Rows)
                {
                    blnc.Text = dr["balance"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            try
            {
                string q1 = "SELECT * FROM invoice where type='instalment' and stats='pend' and dated='"+DateTime.Now.Date+"'";
                SqlDataAdapter SD1 = new SqlDataAdapter(q1, con);
                DataTable dt1 = new DataTable();
                SD1.Fill(dt1);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                int n1 = 0;
                foreach (DataRow dr1 in dt1.Rows)
                {
                    n1 = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n1].Cells[0].Value = dr1["invno"].ToString();
                    dataGridView1.Rows[n1].Cells[1].Value = dr1["custom"].ToString();
                    dataGridView1.Rows[n1].Cells[2].Value = dr1["con"].ToString();
                    dataGridView1.Rows[n1].Cells[3].Value = dr1["instad"].ToString();
                    dataGridView1.Rows[n1].Cells[4].Value = dr1["total"].ToString();
                    dataGridView1.Rows[n1].Cells[5].Value = dr1["siz"].ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }
    }
}
