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
    public partial class usr : Form
    {
        public usr()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;

        private void usr_Load(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * from [data]";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                textBox1.Items.Clear();
                textBox1.Items.Add("--Select--");
                foreach (DataRow dr in db.Rows)
                {
                    textBox1.Items.Add(dr["name"].ToString());
                }
                textBox1.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Please enter only alphabets and digits or some special characters");
            }
            con.Close();

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string query = "INSERT INTO data (usr,pas,name,type) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted successfully");
            }
            catch
            {
                MessageBox.Show("Please enter only alphabets and digits or some special characters");
            }
            con.Close();

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM data WHERE Username='" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted successfully");

            }
            catch
            {
                MessageBox.Show("It seems that the given Item does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
