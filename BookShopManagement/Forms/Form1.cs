using BookShopManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookShopManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            try
            {
                string query = "SELECT count(*) FROM data WHERE usr='" + txtusr.Text + "' and pas= '" + txtpas.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    globals.score = txtusr.Text;
                    SqlCommand cmd;
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT * from [data] WHERE usr='" + txtusr.Text + "' and pas= '" + txtpas.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
                    cmd.ExecuteNonQuery();
                    DataTable db = new DataTable();
                    SqlDataAdapter dq = new SqlDataAdapter(cmd);
                    dq.Fill(db);
                   foreach (DataRow dr in db.Rows)
                    {
                        globals.nam = (dr["name"].ToString());
                        globals.tp = (dr["type"].ToString());
                    }

                    using (Form_Dashboard fd = new Form_Dashboard())
                    {
                        fd.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect");
                }
            }
            catch
            {
                MessageBox.Show("Please enter correct alphabets and numbers.");
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            }

        private void txtpas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
            else
            {
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
public static class globals
{
    public static string score;
    // public static SqlConnection cnstring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\new.mdf;Integrated Security=True;Connect Timeout=30");
    public static SqlConnection cnstring = new SqlConnection(@"Data Source=LAPTOP-HHCL09E9\SQLEXPRESS;Initial Catalog=csnap;User id=sa;Password=aAa@121s;Integrated Security=False;Connect Timeout=30");
    public static string tp;
    public static string nam;

}

