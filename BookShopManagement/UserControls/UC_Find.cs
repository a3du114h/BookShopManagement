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
    public partial class UC_Find : UserControl
    {
        public UC_Find()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;

        private void UC_Find_Load(object sender, EventArgs e)
        {
            
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
                string q = "SELECT * FROM invoice where datei between'" + dateTimePicker2.Value.ToShortDateString() + "' and '" + dateTimePicker1.Value.ToShortDateString() + "'";
                SqlDataAdapter SD = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                SD.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dr["invno"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr["agent"].ToString();
                   dataGridView1.Rows[n].Cells[3].Value = dr["datei"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = dr["type"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = dr["instad"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = dr["inr"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = dr["total"].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = dr["aed"].ToString();
                    double x = Convert.ToDouble(dr["total"].ToString()) - Convert.ToDouble(dr["aed"].ToString()); 
                    dataGridView1.Rows[n].Cells[9].Value = x.ToString();
                    dataGridView1.Rows[n].Cells[10].Value = dr["prof"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dr["custom"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
