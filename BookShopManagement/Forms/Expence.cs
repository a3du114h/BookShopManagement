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
    public partial class Expence : Form
    {
        public Expence()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;
      
        private void Expence_Load(object sender, EventArgs e)
        {

        }

        double yz = 0, rz = 0, wz = 0, az = 0;

        private void button1_Click(object sender, EventArgs e)
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

                az = wz + Convert.ToDouble(pay.Text);
                string query = "UPDATE blnc SET balance='" + az.ToString() + "' WHERE id ='1'";
                SqlDataAdapter SA = new SqlDataAdapter(query, con);
                SA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Insert Successful.");
                string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Expence of " + pay.Text + " was created with discription "+pend.Text+"')";
                SqlDataAdapter SDa = new SqlDataAdapter(que, con);
                SDa.SelectCommand.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
}
    }
}
