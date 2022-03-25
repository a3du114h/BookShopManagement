using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;
using System.Data.SqlClient;

namespace BookShopManagement.UserControls
{
    public partial class UC_Invoice : UserControl
    {
        public UC_Invoice()
        {
            InitializeComponent();
        }
        SqlConnection con = globals.cnstring;
        string tbd, tru;
        double tx;
        double trx,origr;
        double instaa = 3;
        double xc=0,nont=0 ;
        double yz = 0, wz = 0, az = 0;

        double remd = 0;
        string spec;
        double agt=0;
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void UC_Sales_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            try
            {
                string q = "select top 1 invno from invoice order by [id] desc";
                SqlDataAdapter SD = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                SD.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    label3.Text = dr["invno"].ToString();
                }
                double amm, bmm;
                bmm = 1;
                string inv = label3.Text;
                if (label3.Text != "0")
                {
                    amm = Convert.ToDouble(inv);
                    amm = amm + bmm;
                }
                else
                {
                    amm = 10001;
                }
                totinv.Text = amm.ToString();
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

                cmd.CommandText = "SELECT * from [custom]";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                comcustom.Items.Clear();
                comcustom.Items.Add("--Select--");
                foreach (DataRow dr in db.Rows)
                {
                    comcustom.Items.Add(dr["nam"].ToString());
                }
                comcustom.SelectedIndex = 0;
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

                cmd.CommandText = "SELECT * from [agent]";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                comagent.Items.Clear();
                comagent.Items.Add("--Select--");
                foreach (DataRow dr in db.Rows)
                {
                    comagent.Items.Add(dr["name"].ToString());
                }
                comagent.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comcustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comcustom.Text != "--Select--")
            {
                SqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * from [custom] where nam='" + comcustom.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable db = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(cmd);
                dq.Fill(db);
                
                foreach (DataRow dr in db.Rows)
                {
                    totadr.Text = (dr["adrs"].ToString());
                    totcon.Text = (dr["con"].ToString());
                    totdisc.Text = (dr["disc"].ToString());
                    totindcon.Text = (dr["indcon"].ToString());
                    txtcity.Text = (dr["city"].ToString());
                    totindadr.Text = dr["indadrs"].ToString();
                    spec = dr["special"].ToString();
                }
                if (spec == "true")
                {
                    totindadr.ReadOnly =false;
                    totindcon.ReadOnly = false;
                }
                else
                {
                    totindadr.ReadOnly = true;
                    totindcon.ReadOnly = true;
                }

            }
            else
            {
                totadr.Text = "";
                totcon.Text = "";
                totdisc.Text = "";
                totindadr.Text = "";
                totindcon.Text = "";
            }
            comtype.SelectedIndex = 0;

        }

        private void comagent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comagent.Text != "--Select--")
            {
                try
                {
                    SqlCommand cmd;
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * from [agent] where name ='" + comagent.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable db = new DataTable();
                    SqlDataAdapter dq = new SqlDataAdapter(cmd);
                    dq.Fill(db);
                    foreach (DataRow dr in db.Rows)
                    {
                        tottime.Text = (dr["speed"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void txtinr_KeyDown(object sender, KeyEventArgs e)
        {



        }

        private void txtinr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtinr.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtinr_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    tx = 0;
                    tx = Convert.ToDouble(txtinr.Text);
                    if (tx > 1000)
                    {
                        tx = tx / 1000;
                    }

                    if (comtype.Text == "One-Time")
                    {
                        if (txtcity.Text == "Malappuram")
                        {
                            SqlCommand cmd;
                            cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT * from [" + comagent.Text + "] where frm >= " + tx + " and too <= " + tx + " and nam like'%orignal_MPM%'";
                            cmd.ExecuteNonQuery();
                            DataTable dbd = new DataTable();
                            SqlDataAdapter dqd = new SqlDataAdapter(cmd);
                            dqd.Fill(dbd);
                            foreach (DataRow drd in dbd.Rows)
                            {
                                tru = drd["rate"].ToString();
                            }
                            double non = Convert.ToDouble(tru);
                            nont = Math.Round(non, 2);
                            trx = nont * tx;
                            cmd.CommandText = "SELECT * from [" + comagent.Text + "] where frm >= " + tx + " and too <= " + tx + " and nam like'%alappuram%'";
                            cmd.ExecuteNonQuery();
                            DataTable db = new DataTable();
                            SqlDataAdapter dq = new SqlDataAdapter(cmd);
                            dq.Fill(db);
                            foreach (DataRow dr in db.Rows)
                            {
                                tbd = dr["rate"].ToString();
                            }

                            double aedt = Convert.ToDouble(tbd);
                            origr = aedt;
                            double cret = (aedt - nont) * tx;
                            int crec = (int)Math.Ceiling(cret);
                            double tot = tx * aedt;
                            txtprof.Text = crec.ToString();
                            txtaed.Text = tot.ToString();
                            textBox2.Text = txtaed.Text;
                            textBox4.Text = txtaed.Text;
                            textBox5.Text = "0";
                        }
                        else if (txtcity.Text == "Others")
                        {
                            SqlCommand cmd;
                            cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT * from [" + comagent.Text + "] where frm >= " + tx + " and too <= " + tx + " and nam like '%orignal_Oth%'";
                            cmd.ExecuteNonQuery();
                            DataTable dbd = new DataTable();
                            SqlDataAdapter dqd = new SqlDataAdapter(cmd);
                            dqd.Fill(dbd);
                            foreach (DataRow drd in dbd.Rows)
                            {
                                tru = drd["rate"].ToString();
                            }
                            double non = Convert.ToDouble(tru);
                            nont = Math.Round(non, 2);
                            trx = nont * tx;
                            cmd.CommandText = "SELECT * from [" + comagent.Text + "] where frm >= " + tx + " and too <= " + tx + " and nam like'%other%'";
                            cmd.ExecuteNonQuery();
                            DataTable db = new DataTable();
                            SqlDataAdapter dq = new SqlDataAdapter(cmd);
                            dq.Fill(db);
                            foreach (DataRow dr in db.Rows)
                            {
                                tbd = dr["rate"].ToString();
                            }

                            double aedt = Convert.ToDouble(tbd);
                            origr = aedt;
                            double cret = (aedt - nont) * tx;
                            int crec = (int)Math.Ceiling(cret);
                            double tot = tx * aedt;
                            txtprof.Text = crec.ToString();
                            txtaed.Text = tot.ToString();
                            textBox2.Text = txtaed.Text;
                            textBox4.Text = txtaed.Text;
                            textBox5.Text = "0";
                        }
                    }
                    else if (comtype.Text == "Instalment")
                    {
                        return;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void comtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comtype.Text == "Instalment")
            {
                label7.Text = "Instalment Size:";
                label11.Visible = true;
                textBox3.Visible = true;
                 
            }
            else if (comtype.Text == "One-Time")
            {
                label11.Visible = false;
                textBox3.Visible = false;

                label7.Text = "Amount AED:";
               }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comtype.Text == "Instalment")
                {
                    DateTime dt = new DateTime();
                    dt = DateTime.Now.Date;
                    DateTime dt1 = new DateTime();
                    dt1 = dt.AddMonths(1);
                    DateTime dt2 = new DateTime();
                    dt2 = dt.AddMonths(Convert.ToInt32(instaa));

                    string qqq = "INSERT INTO invoice(custom,con,inr,aed,type,dated,dater,instat,remain,agent,prof,invno,usr" +
                        ",instad,datei,credit,debit,total,disc,stats,siz,rat,orig) VALUES" +
                        " ('" + comcustom.Text + "', '" + totcon.Text + "', '" + txtinr.Text + "', '" + textBox2.Text + "'," +
                        " '" + comtype.Text + "', '" + dt1.ToString() + "', '" + dt2.ToString() + "'" +
                        ", '" + instaa.ToString() + "', '" + (xc - Convert.ToDouble(textBox2.Text)).ToString() + "','" + comagent.Text + "','" + txtprof.Text + "'," +
                        "'" + totinv.Text + "','" + globals.nam + "', '1','" + dt.ToString() + "'" +
                        ",'" + textBox4.Text + "','" + textBox5.Text + "','" + xc.ToString() + "','" + totdisc.Text + "','pend','" + txtaed.Text + "','" + origr.ToString() + "','" + nont.ToString() + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(qqq, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    double tota = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(txtprof.Text);

                    string qq = "INSERT INTO record(agent,custom,dat,inr,aed,type,pending,paid,inst,prof) VALUES ('" + comagent.Text + "', '" + comcustom.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + txtinr.Text + "', '" + tota.ToString() + "', '" + comtype.Text + "', '" + (xc - Convert.ToDouble(textBox2.Text)).ToString().ToString() + "', '" + textBox2.Text + "', '" + "1st" + "','" + txtprof.Text + "')";
                    SqlDataAdapter SA = new SqlDataAdapter(qq, con);
                    SA.SelectCommand.ExecuteNonQuery();

                    string uery = "SELECT count(*) FROM " + comagent.Text + "_Record WHERE dat = '" + DateTime.Now.ToShortDateString() + "'";
                    SqlDataAdapter DA = new SqlDataAdapter(uery, con);
                    DataTable dtd = new DataTable();
                    DA.Fill(dtd);
                    if (dtd.Rows[0][0].ToString() == "1")
                    {
                        string q = "SELECT * FROM " + comagent.Text + "_Record WHERE dat='" + DateTime.Now.ToShortDateString() + "'";
                        SqlDataAdapter SD = new SqlDataAdapter(q, con);
                        DataTable dtt = new DataTable();
                        SD.Fill(dtt);
                        double y = 0;
                        double yy = 0;
                        double zxz = 0;
                        foreach (DataRow dr in dtt.Rows)
                        {
                            string x = dr["remain"].ToString();
                            string zza = dr["inr"].ToString();
                            zxz = Convert.ToDouble(zza) + Convert.ToDouble(tx);
                            y = Convert.ToDouble(x);
                            yy = trx + y;
                        }

                        string qqs = "Update " + comagent.Text + "_Record set remain='" + yy.ToString() + "', inr='" + zxz.ToString() + "' where dat='" + DateTime.Now.ToShortDateString() + "'";
                        SqlDataAdapter SAs = new SqlDataAdapter(qqs, con);
                        SAs.SelectCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        string qqs = "INSERT INTO " + comagent.Text + "_Record (dat,paid,remain,inr) VALUES ('" + DateTime.Now.ToShortDateString() + "', '0', '" + trx.ToString() + "', '" + tx.ToString() + "')";
                        SqlDataAdapter SAs = new SqlDataAdapter(qqs, con);
                        SAs.SelectCommand.ExecuteNonQuery();
                    }
                    string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Invoice number " + totinv.Text + " for customer " + comcustom.Text + " was created')";
                    SqlDataAdapter SDa = new SqlDataAdapter(que, con);
                    SDa.SelectCommand.ExecuteNonQuery();

                    MessageBox.Show("Invoice posted successfully");
                }
                else if (comtype.Text == "One-Time")
                {
                    DateTime dt = new DateTime();
                    dt = DateTime.Now.Date;

                    string qqq = "INSERT INTO invoice(custom,con,inr,aed,type,dated,dater,instat,remain,agent,prof,invno,usr" +
                        ",instad,datei,credit,debit,total,disc,stats,siz,rat,orig) VALUES (" +
                        "'" + comcustom.Text + "', '" + totcon.Text + "', '" + txtinr.Text + "', '" + textBox2.Text + "', '" +
                        "" + comtype.Text + "', '" + dt.ToShortDateString() + "'" +
                        ", '01/01/1980', '1','0','" + comagent.Text + "','" + txtprof.Text + "','" + totinv.Text + "','" +
                        "" + globals.nam + "', '0','" + dt.ToShortDateString() + "','" + textBox4.Text + "','" + textBox5.Text + "" +
                        "','" + txtaed.Text + "','" + totdisc.Text + "','done','" + txtaed.Text + "','" + origr.ToString() + "','" + nont.ToString() + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(qqq, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    double tota = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(txtprof.Text);

                    string qq = "INSERT INTO record(agent,custom,dat,inr,aed,type,paid,pending,inst,prof) VALUES ('" + comagent.Text + "', '" + comcustom.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + txtinr.Text + "', '" + tota.ToString() + "', '" + comtype.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "', '0 ','" + txtprof.Text + "')";
                    SqlDataAdapter SA = new SqlDataAdapter(qq, con);
                    SA.SelectCommand.ExecuteNonQuery();


                    string uery = "SELECT count(*) FROM " + comagent.Text + "_Record WHERE dat = '" + DateTime.Now.ToShortDateString() + "'";
                    SqlDataAdapter DA = new SqlDataAdapter(uery, con);
                    DataTable dtd = new DataTable();
                    DA.Fill(dtd);
                    if (dtd.Rows[0][0].ToString() == "1")
                    {
                        string q = "SELECT * FROM " + comagent.Text + "_Record WHERE dat='" + DateTime.Now.ToShortDateString() + "'";
                        SqlDataAdapter SD = new SqlDataAdapter(q, con);
                        DataTable dtt = new DataTable();
                        SD.Fill(dtt);
                        double y = 0;
                        double yy = 0;
                        double zxz = 0;
                        foreach (DataRow dr in dtt.Rows)
                        {
                            string x = dr["remain"].ToString();
                            string zza = dr["inr"].ToString();
                            zxz = Convert.ToDouble(zza) + Convert.ToDouble(tx);
                            y = Convert.ToDouble(x);
                            yy = trx + y;
                        }

                        string qqs = "Update " + comagent.Text + "_Record set remain='" + yy.ToString() + "', inr='" + zxz.ToString() + "' where dat='" + DateTime.Now.ToShortDateString() + "'";
                        SqlDataAdapter SAs = new SqlDataAdapter(qqs, con);
                        SAs.SelectCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        string qqs = "INSERT INTO " + comagent.Text + "_Record (dat,paid,remain,inr) VALUES ('" + DateTime.Now.ToShortDateString() + "', '0', '" + trx.ToString() + "', '" + tx.ToString() + "')";
                        SqlDataAdapter SAs = new SqlDataAdapter(qqs, con);
                        SAs.SelectCommand.ExecuteNonQuery();
                    }
                    string que = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Invoice number " + totinv.Text + " for customer " + comcustom.Text + " was created')";
                    SqlDataAdapter SDa = new SqlDataAdapter(que, con);
                    SDa.SelectCommand.ExecuteNonQuery();
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
                        }

                        az = wz + Convert.ToDouble(textBox2.Text);
                        string query = "UPDATE blnc SET balance='" + wz.ToString() + "' WHERE id ='1'";
                        SqlDataAdapter SAb = new SqlDataAdapter(query, con);
                        SAb.SelectCommand.ExecuteNonQuery();
                        string queb = "INSERT INTO [events] (dat,event) VALUES ('" + DateTime.Now.ToString() + "','Invoice of " + totinv.Text + " added balance " + textBox2.Text + "')";
                        SqlDataAdapter SDab = new SqlDataAdapter(queb, con);
                        SDab.SelectCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    MessageBox.Show("Invoice posted successfully");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double ins = Convert.ToDouble(textBox3.Text);                    
                    double aed = Convert.ToDouble(tbd);
                    double cred = Convert.ToDouble(txtcredit.Text);

                    double xcc = (aed + cred) * tx;
                    xc = Math.Ceiling(xcc);
                    double inst = xc / ins;
                    agt = aed * ins;
                    textBox3.Text = ins.ToString();
                    instaa = ins;
                    remd = xc - inst;


                    txtaed.Text = inst.ToString();
                    textBox2.Text = txtaed.Text;
                    textBox4.Text = textBox2.Text;
                    textBox5.Text = "0";
                    txtcredit.ReadOnly = true;
                }
                catch (Exception aa)
                {
                    MessageBox.Show("Error: " + aa.Message);
                }
            }

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double ins = Convert.ToDouble(textBox4.Text);
                    double cred = Convert.ToDouble(textBox2.Text);
                    double res = cred - ins;
                     textBox5.Text = res.ToString();
                }
                catch (Exception aa)
                {
                    MessageBox.Show("Error: " + aa.Message);
                }
            }

            }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtcredit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comtype.Text == "One-Time")
                    {
                        double crep = Convert.ToDouble(txtcredit.Text);
                        double pro = Convert.ToDouble(txtprof.Text);
                        double cre = Convert.ToDouble(txtaed.Text);
                        double fina = cre + crep;
                        double proo = pro + crep;
                        txtprof.Text = proo.ToString();
                        txtaed.Text = fina.ToString();
                        textBox2.Text = txtaed.Text;
                        textBox4.Text = txtaed.Text;
                        textBox5.Text = "0";

                    }
                    else if (comtype.Text == "Instalment")
                    {
                        if (txtcity.Text == "Malappuram")
                        {
                            SqlCommand cmd;
                            cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT * from [" + comagent.Text + "] where frm >= " + tx + " and too <= " + tx + " and nam like'%orignal_MPM%'";
                            cmd.ExecuteNonQuery();
                            DataTable dbd = new DataTable();
                            SqlDataAdapter dqd = new SqlDataAdapter(cmd);
                            dqd.Fill(dbd);
                            foreach (DataRow drd in dbd.Rows)
                            {
                                tru = drd["rate"].ToString();
                            }
                            double non = Convert.ToDouble(tru);
                            nont = Math.Round(non, 2);
                            trx = nont * tx;

                            cmd.CommandText = "SELECT * from [" + comagent.Text + "] where frm >= " + tx + " and too <= " + tx + " and nam like'%alappuram%'";
                            cmd.ExecuteNonQuery();
                            DataTable db = new DataTable();
                            SqlDataAdapter dq = new SqlDataAdapter(cmd);
                            dq.Fill(db);
                            foreach (DataRow dr in db.Rows)
                            {
                                tbd = dr["rate"].ToString();
                            }


                            double aedt = Convert.ToDouble(tbd);
                            double cred = Convert.ToDouble(txtcredit.Text);
                            origr = (aedt + cred);
                            double xcc = (origr * tx);
                            xc = Math.Round(xcc, 2);

                            double proff = xc-trx;
                            double prof = Math.Round(proff, 2);

                            double inst = xc / 3;
                            double xcz = Math.Round(inst, 2);
                            textBox3.Text="3";
                            txtaed.Text = xcz.ToString();
                            textBox2.Text = txtaed.Text;
                            textBox4.Text = txtaed.Text;
                            textBox5.Text = "0";
                            txtprof.Text = prof.ToString();

                        }
                        else if (txtcity.Text == "Others")
                        {
                            SqlCommand cmd;
                            cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT * from [" + comagent.Text + "] where frm >= " + tx + " and too <= " + tx + " and nam like '%orignal_Oth%'";
                            cmd.ExecuteNonQuery();
                            DataTable dbd = new DataTable();
                            SqlDataAdapter dqd = new SqlDataAdapter(cmd);
                            dqd.Fill(dbd);
                            foreach (DataRow drd in dbd.Rows)
                            {
                                tru = drd["rate"].ToString();
                            }
                            double non = Convert.ToDouble(tru);
                            nont = Math.Round(non, 2);
                            trx = nont * tx;
                            cmd.CommandText = "SELECT * from [" + comagent.Text + "] where frm >= " + tx + " and too <= " + tx + " and nam like'%other%'";
                            cmd.ExecuteNonQuery();
                            DataTable db = new DataTable();
                            SqlDataAdapter dq = new SqlDataAdapter(cmd);
                            dq.Fill(db);
                            foreach (DataRow dr in db.Rows)
                            {
                                tbd = dr["rate"].ToString();
                            }
                            double aedt = Convert.ToDouble(tbd);
                            double cred = Convert.ToDouble(txtcredit.Text);
                            origr = (aedt + cred);
                            double xcc = (origr * tx);
                            xc = Math.Round(xcc, 2);

                            double proff = xc - trx;
                            double prof = Math.Round(proff, 2);

                            double inst = xc / 3;
                            double xcz = Math.Round(inst, 2);
                            textBox3.Text = "3";
                            txtaed.Text = xcz.ToString();
                            textBox2.Text = txtaed.Text;
                            textBox4.Text = txtaed.Text;
                            textBox5.Text = "0";
                            txtprof.Text = prof.ToString();
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtcredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtcredit.Text.IndexOf('.') != -1)
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
