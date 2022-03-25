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
    public partial class secret : Form
    {
        public secret()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;

        private void secret_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT name FROM sys.tables";
            cmd.ExecuteNonQuery();
            DataTable db = new DataTable();
            SqlDataAdapter dq = new SqlDataAdapter(cmd);
            comboBox1.Items.Clear();
            dq.Fill(db);
            foreach (DataRow dr in db.Rows)
            {
                comboBox1.Items.Add(dr["Name"].ToString());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string q = "SELECT * FROM [" + comboBox1.Text + "]";
                SqlDataAdapter SD = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                SD.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An error occured.");
            }

        }
    }
}
