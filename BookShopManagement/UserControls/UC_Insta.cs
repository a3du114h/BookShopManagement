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
    public partial class UC_Insta : UserControl
    {
        public UC_Insta()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;
        double y = 0, r = 0, w = 0, a = 0;
        double yz = 0, rz = 0, wz = 0, az = 0;

        private void UC_Insta_Load(object sender, EventArgs e)
        {
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
                    yz = Convert.ToDouble(dr["balance"].ToString());
                    wz = Convert.ToDouble(dr["paid"].ToString());
                    rz = Convert.ToDouble(dr["pending"].ToString());
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void txtcre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double ins = Convert.ToDouble(pay.Text);
                    double cred = Convert.ToDouble(txtcre.Text);
                    double res = ins-cred;
                    txtdebit.Text = res.ToString();
                    //double y = Convert.ToDouble(totdebit.Text);
                    //totdebit.Text = (res + y).ToString();
                 }
                catch (Exception aa)
                {
                    MessageBox.Show("Error: " + aa.Message);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM invoice WHERE invno='" + invno.Text + "'";
            SqlDataAdapter SD = new SqlDataAdapter(q, con);
            DataTable dtt = new DataTable();
            SD.Fill(dtt);
            dataGridView1.DataSource = dtt;
         
            foreach (DataRow dr in dtt.Rows)
            {
                string x = dr["remain"].ToString();
                y = Convert.ToDouble(x);
                instat.Text = dr["instat"].ToString();
                w = Convert.ToDouble(instat.Text);
                instad.Text = (Convert.ToDouble(dr["instad"].ToString())+1).ToString();
                r = Convert.ToDouble(instad.Text);
                totpaid.Text = dr["aed"].ToString();
                tottotal.Text = dr["total"].ToString();
                comcustom.Text = dr["custom"].ToString();
                totdebit.Text= dr["debit"].ToString();
                cont.Text = dr["con"].ToString();
                disc.Text = (dr["disc"].ToString());
                double dxd = Convert.ToDouble(dr["total"].ToString()) / Convert.ToDouble(dr["instat"].ToString());
                double dx = Math.Round(dxd, 2);
                pay.Text = dx.ToString();
                txtcre.Text = pay.Text;
                txtdebit.Text = "0";
                a = r;
            }
            }

      
        private void button1_Click(object sender, EventArgs e)
        {
//,discount = '" + cw.ToString() + "',total = '" + dw.ToString() + "',credit = '" + textBox3.Text + "',debit = '" + textBox1.Text + "',usr = '" + user + "'

            try
            {
                double t = w - r;
                if (t > 0) {
                    DateTime dt = new DateTime();
                    dt = DateTime.Now.Date;
                    DateTime dt1 = new DateTime();
                    dt1 = dt.AddMonths(1);
                    double xx = Convert.ToDouble(totpaid.Text);
                    double aaa= y-Convert.ToDouble(rec.Text);
                    double bbb = Convert.ToDouble(totdebit.Text) + Convert.ToDouble(txtdebit.Text);
                    double ccc = Convert.ToDouble(tottotal.Text)-(Convert.ToDouble(totpaid.Text) + Convert.ToDouble(rec.Text));
                    double yy = xx + Convert.ToDouble(rec.Text);
                string qqq = "UPDATE Invoice set aed='" + yy.ToString() + "',instad='" + instad.Text + "" +
                    "',debit='" + bbb.ToString() + "',remain='" + ccc.ToString() + "" +
                    "',dated='" + dt1.ToString() + "',stats='pend' WHERE invno='" + invno.Text + "'";
                    SqlDataAdapter SAd = new SqlDataAdapter(qqq, con);
                    SAd.SelectCommand.ExecuteNonQuery();

                    MessageBox.Show("Invoice updated successfully");
                    az = yz + Convert.ToDouble(rec.Text);
                    string query = "UPDATE blnc SET balance='" + az.ToString() + "' WHERE id ='1'";
                    SqlDataAdapter SA = new SqlDataAdapter(query, con);
                    SA.SelectCommand.ExecuteNonQuery();

                }
                else if (t == 0)
                {
                    DateTime dt = new DateTime();
                    dt = DateTime.Now.Date;
                    double xx = Convert.ToDouble(totpaid.Text);
                    double aaa = y - Convert.ToDouble(rec.Text);
                    double bbb = Convert.ToDouble(totdebit.Text) + Convert.ToDouble(txtdebit.Text);
                    double ccc = Convert.ToDouble(tottotal.Text) - (Convert.ToDouble(totpaid.Text) + Convert.ToDouble(rec.Text));
                    double yy = xx + Convert.ToDouble(rec.Text);
                    string qqq = "UPDATE Invoice set aed='" + yy.ToString() + "',instad='" + instad.Text + "" +
                        "',debit='" + bbb.ToString() + "',remain='" + ccc.ToString() + "" +
                        "',dated='" + dt.ToString() + "',stats='done' WHERE invno='" + invno.Text + "'";
                    SqlDataAdapter SAd = new SqlDataAdapter(qqq, con);
                    SAd.SelectCommand.ExecuteNonQuery();

                    MessageBox.Show("Invoice updated successfully");
                    az = yz + Convert.ToDouble(rec.Text);
                    string query = "UPDATE blnc SET balance='" + az.ToString() + "' WHERE id ='1'";
                    SqlDataAdapter SA = new SqlDataAdapter(query, con);
                    SA.SelectCommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("There has been an error. Maybe the instalment has been paid completely.");
                }

               }
            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.Message);
            }
        }
        private void invno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button5_Click(this, new EventArgs());
            }
        }

    }
}
