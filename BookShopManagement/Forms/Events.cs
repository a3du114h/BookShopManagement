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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;

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

                cmd.CommandText = "SELECT * from [events] where [event] like '%"+mob1.Text+"%' dat between '" + dtfrom.Value.ToString() + "' and '" + dtto.Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                dataGridView1.Rows.Clear();
                foreach (DataRow dr in db.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dr["dat"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr["event"].ToString();
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
