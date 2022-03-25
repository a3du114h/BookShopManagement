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
    public partial class UC_Agent : UserControl
    {
        public UC_Agent()
        {
            InitializeComponent();
        }
        int a, b, c,d;
        string g,h, ee, f;
        SqlConnection con = globals.cnstring;

        private void UC_Agent_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            try
            {
                string name = comboBox3.Text;
                g = origmal.Text;
                h = origoth.Text;
                ee = youmal.Text;
                f = youoth.Text;
                a = Convert.ToInt32(g.ToString());
                b = Convert.ToInt32(h.ToString());
                c = Convert.ToInt32(ee.ToString());
                d = Convert.ToInt32(f.ToString());

                string query = "CREATE TABLE " + name + "( [id] [int] IDENTITY(1,1) NOT NULL, [nam] [varchar](255),[rate] [varchar](255),[frm] [varchar](255),[too] [varchar](255))";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                int i;
                for (i = 1; i <a+1 ; i++)
                {
                    string quer = "INSERT INTO [" + name + "] ([nam]) VALUES ('orignal_MPM" + i + "')";
                    SqlDataAdapter SD = new SqlDataAdapter(quer, con);
                    SD.SelectCommand.ExecuteNonQuery();
                }
                for (i = 1; i <b+1 ; i++)
                {
                    string quer = "INSERT INTO [" + name + "] ([nam]) VALUES ('orignal_Oth" + i + "')";
                    SqlDataAdapter SD = new SqlDataAdapter(quer, con);
                    SD.SelectCommand.ExecuteNonQuery();
                }
                for (i = 1; i <d+1 ; i++)
                {
                    string quer = "INSERT INTO [" + name + "] ([nam]) VALUES ('other" + i + "')";
                    SqlDataAdapter SD = new SqlDataAdapter(quer, con);
                    SD.SelectCommand.ExecuteNonQuery();
                }
                for (i = 1; i < c+1; i++)
                {
                    string quer = "INSERT INTO [" + name + "] ([nam]) VALUES ('Malappuram" + i + "')";
                    SqlDataAdapter SD = new SqlDataAdapter(quer, con);
                    SD.SelectCommand.ExecuteNonQuery();
                }
                SqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * from ["+name+"]";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                comboBox1.Items.Clear();
                comboBox1.Items.Add("--Select--");
                foreach (DataRow dr in db.Rows)
                {
                    comboBox1.Items.Add(dr["nam"].ToString());

                }
                comboBox1.SelectedIndex = 0;
                string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Rate list for agent " + comboBox3.Text + " was created')";
                SqlDataAdapter SDa = new SqlDataAdapter(que, con);
                SDa.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Rate list created for agent " + comboBox3.Text);

                label12.Visible = true;
                comboBox1.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please create the agent first or type in the number of list items correctly.");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label12.Visible = true;
            comboBox1.Visible = true;
            origmal.Visible = false;
            origoth.Visible = false;
            youmal.Visible = false;
            youoth.Visible = false;
            label11.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label13.Visible = false;

            button4.Text = "Update Rate";
            button3.Visible = false;
            button5.Visible = false;
            label3.Visible = false;
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            try { 
            SqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from [agent]";
            cmd.ExecuteNonQuery();
            DataTable db = new DataTable();
            SqlDataAdapter dq = new SqlDataAdapter(cmd);
            dq.Fill(db);
                comboBox3.Items.Clear();
                comboBox3.Items.Add("--Select--");
            foreach (DataRow dr in db.Rows)
            {
                comboBox3.Items.Add(dr["name"].ToString());

            }
            comboBox3.SelectedIndex = 0;
            }catch(Exception ex){
                MessageBox.Show("Error: "+ex.Message);
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Text = "Enter Rate";
            button3.Visible = true;
            button5.Visible = true;
            label3.Visible = true;
            label12.Visible = false;
            comboBox1.Visible = false;
            origmal.Visible = true;
            origoth.Visible = true;
            youmal.Visible = true;
            youoth.Visible = true;
            label11.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label13.Visible = true;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            if (comboBox3.Text!="--Select--") {
                try
                {
                    string q = "SELECT * FROM [agent] WHERE name='" + comboBox3.Text + "'";
                    SqlDataAdapter SD = new SqlDataAdapter(q, con);
                    DataTable dt = new DataTable();
                    SD.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        textBox5.Text = (dr["speed"]).ToString();
                    }
                    SqlCommand cmd;
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * from [" + comboBox3.Text + "]";
                    cmd.ExecuteNonQuery();
                    DataTable db = new DataTable();
                    SqlDataAdapter dq = new SqlDataAdapter(cmd);
                    dq.Fill(db);
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("--Select--");
                    foreach (DataRow dr in db.Rows)
                    {
                        comboBox1.Items.Add(dr["nam"].ToString());

                    }
                    comboBox1.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message );
                }
            }
            else {
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            SqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from [" + comboBox3.Text + "] where nam='"+comboBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable db = new DataTable();
            SqlDataAdapter dq = new SqlDataAdapter(cmd);
            dq.Fill(db);
            foreach (DataRow dr in db.Rows)
            {
                textBox1.Text = (dr["frm"].ToString());
                textBox2.Text = (dr["too"].ToString());
                textBox3.Text = (dr["rate"].ToString());
            }
        }

        private void origmal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && origmal.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void origoth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && origoth.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void youmal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && youmal.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void youoth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && youoth.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            try
            {
                string quer = "INSERT INTO ["+comboBox3.Text+ "_Record] ([dat],[paid],[remain]) VALUES ('" + DateTime.Now.ToShortDateString() + "','" + paid.Text + "','" + rem.Text + "')";
                SqlDataAdapter SD = new SqlDataAdapter(quer, con);
                SD.SelectCommand.ExecuteNonQuery();
                string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Amount for Agent " + comboBox3.Text + " was inserted')";
                SqlDataAdapter SDa = new SqlDataAdapter(que, con);
                SDa.SelectCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            }

        private void del_Click(object sender, EventArgs e)
        {
         try{
                string quer = "Drop table [" + comboBox3.Text + "_Record]";
                SqlDataAdapter SD = new SqlDataAdapter(quer, con);
                SD.SelectCommand.ExecuteNonQuery();
                string querq = "Drop table [" + comboBox3.Text + "]";
                SqlDataAdapter SDq = new SqlDataAdapter(querq, con);
                SDq.SelectCommand.ExecuteNonQuery();
                string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Agent named " + comboBox3.Text + " was deleted')";
            SqlDataAdapter SDa = new SqlDataAdapter(que, con);
            SDa.SelectCommand.ExecuteNonQuery();
                string query = "DELETE FROM agent WHERE name ='" + comboBox3.Text + "'";
                SqlDataAdapter SA = new SqlDataAdapter(query, con);
                SA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Agent was deleted successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

                string query = "UPDATE "+comboBox3.Text+" SET frm='" + textBox1.Text + "',too='" + textBox2.Text + "',rate='" +textBox3.Text + "' WHERE nam ='" + comboBox1.Text + "'";
                SqlDataAdapter SA = new SqlDataAdapter(query, con);
                SA.SelectCommand.ExecuteNonQuery();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            try
            { 
            string quer = "INSERT INTO [agent] ([name],[speed]) VALUES ('" + comboBox3.Text + "','" + textBox5.Text + "')";
            SqlDataAdapter SD = new SqlDataAdapter(quer, con);
            SD.SelectCommand.ExecuteNonQuery();
                SqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string query = "CREATE TABLE [" + comboBox3.Text + "_Record]( [id] [int] IDENTITY(1,1) NOT NULL, [dat] [date],[paid] [varchar](255),[remain] [varchar](255),[inr] [varchar](255))";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                string nam;
                nam = comboBox3.Text;
                cmd.CommandText = "SELECT * from [agent]";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                comboBox3.Items.Clear();
                comboBox3.Items.Add("--Select--");
                foreach (DataRow dr in db.Rows)
                {
                    comboBox3.Items.Add(dr["name"].ToString());
                }
                textBox5.Clear();
                string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Agent named " + comboBox3.Text + " was created')";
                SqlDataAdapter SDa = new SqlDataAdapter(que, con);
                SDa.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Agent " + comboBox3.Text+" was created");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is: "+ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBox1.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBox2.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBox3.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
