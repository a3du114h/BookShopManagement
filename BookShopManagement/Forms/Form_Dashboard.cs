using BookShopManagement.UserControls;
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
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }
        SqlConnection con = globals.cnstring;

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            label5.Text = globals.nam;
            label7.Text = globals.tp;
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

                    cmd.CommandText = "SELECT * from [setting]";
                    cmd.ExecuteNonQuery();
                    DataTable db = new DataTable();
                    SqlDataAdapter dq = new SqlDataAdapter(cmd);
                    dq.Fill(db);
                    foreach (DataRow dr in db.Rows)
                    {
                    tag.Text = (dr["tag"].ToString());
                    mob1.Text = (dr["mob1"].ToString());
                    mail.Text = (dr["mail"].ToString());
                    mob2.Text = (dr["mob2"].ToString());
                    tel.Text= (dr["tel"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("There has been an error.");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 50;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                
                panelLeft.Width = panelLeft.Width - 40;
                if (panelLeft.Width <= 63)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSaleBooks);
            UC_Invoice us = new UC_Invoice();
            AddControlsToPanel(us);
        }


        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
            UC_Custom um = new UC_Custom();
            AddControlsToPanel(um);
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnViewSales);
            UC_Record vs = new UC_Record();
            AddControlsToPanel(vs);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSettings);
            UC_Settings us = new UC_Settings();
            AddControlsToPanel(us);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
       }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAgent);
            UC_Agent us = new UC_Agent();
            AddControlsToPanel(us);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnFind);
            UC_Find us = new UC_Find();
            AddControlsToPanel(us);

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(button1);
            UC_Insta us = new UC_Insta();
            AddControlsToPanel(us);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(button2);
            UC_FCustomer us = new UC_FCustomer();
            AddControlsToPanel(us);

        }
    }
}
