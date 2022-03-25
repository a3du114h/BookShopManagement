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
    public partial class UC_Record : UserControl
    {
        public UC_Record()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Record_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            SqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * from [agent]";
            cmd.ExecuteNonQuery();
            DataTable db = new DataTable();
            SqlDataAdapter dq = new SqlDataAdapter(cmd);
            dq.Fill(db);
            comagent.Items.Clear();
            foreach (DataRow dr in db.Rows)
            {
                comagent.Items.Add(dr["name"].ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
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

                cmd.CommandText = "SELECT * from [invoice] where agent='" + comagent.Text + "' and type='" + comtype.Text + "' and datei between '" + dtfrom.Value.ToString() + "' and '" + dtto.Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                dataGridView1.Rows.Clear();
                foreach (DataRow dr in db.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dr["invno"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr["custom"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dr["inr"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = dr["rat"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = dr["orig"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = dr["prof"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = dr["debit"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = dr["total"].ToString();
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

                cmd.CommandText = "SELECT * from [" + comagent.Text + "_Record] where dat between '" + dtfrom.Value.ToString() + "' and '" + dtto.Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                double ss = 0, tt = 0, uu = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    ss = Convert.ToDouble(dr["paid"].ToString()) + ss;
                    tt = Convert.ToDouble(dr["remain"].ToString()) + tt;
                    uu = Convert.ToDouble(dr["inr"].ToString()) + uu;
                }
                lblinr.Text = uu.ToString();
                lblpaid.Text = ss.ToString();
                lblpend.Text = tt.ToString();
                lbltot.Text = (ss + tt).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
