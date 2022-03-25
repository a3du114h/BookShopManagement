namespace BookShopManagement.UserControls
{
    partial class UC_Invoice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtinr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comtype = new System.Windows.Forms.ComboBox();
            this.comcustom = new System.Windows.Forms.ComboBox();
            this.tottime = new System.Windows.Forms.Label();
            this.comagent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totinv = new System.Windows.Forms.Label();
            this.txtprof = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtaed = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.totindadr = new System.Windows.Forms.TextBox();
            this.totadr = new System.Windows.Forms.TextBox();
            this.totdisc = new System.Windows.Forms.TextBox();
            this.totcon = new System.Windows.Forms.TextBox();
            this.totindcon = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(787, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.7F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(433, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Invoice";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount INR:";
            // 
            // txtinr
            // 
            this.txtinr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtinr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinr.Location = new System.Drawing.Point(150, 380);
            this.txtinr.Name = "txtinr";
            this.txtinr.Size = new System.Drawing.Size(179, 27);
            this.txtinr.TabIndex = 10;
            this.txtinr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtinr_KeyDown_1);
            this.txtinr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinr_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Type:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Amount AED:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Discription:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(354, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Agent:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(629, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Delivery Time:";
            this.label10.Visible = false;
            // 
            // comtype
            // 
            this.comtype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comtype.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comtype.FormattingEnabled = true;
            this.comtype.Items.AddRange(new object[] {
            "Instalment",
            "One-Time"});
            this.comtype.Location = new System.Drawing.Point(150, 325);
            this.comtype.Name = "comtype";
            this.comtype.Size = new System.Drawing.Size(179, 29);
            this.comtype.TabIndex = 8;
            this.comtype.SelectedIndexChanged += new System.EventHandler(this.comtype_SelectedIndexChanged);
            // 
            // comcustom
            // 
            this.comcustom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comcustom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comcustom.FormattingEnabled = true;
            this.comcustom.Location = new System.Drawing.Point(150, 126);
            this.comcustom.Name = "comcustom";
            this.comcustom.Size = new System.Drawing.Size(189, 29);
            this.comcustom.TabIndex = 1;
            this.comcustom.SelectedIndexChanged += new System.EventHandler(this.comcustom_SelectedIndexChanged);
            // 
            // tottime
            // 
            this.tottime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tottime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tottime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tottime.ForeColor = System.Drawing.Color.Black;
            this.tottime.Location = new System.Drawing.Point(742, 320);
            this.tottime.Name = "tottime";
            this.tottime.Size = new System.Drawing.Size(183, 28);
            this.tottime.TabIndex = 10;
            this.tottime.Visible = false;
            // 
            // comagent
            // 
            this.comagent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comagent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comagent.FormattingEnabled = true;
            this.comagent.Location = new System.Drawing.Point(429, 321);
            this.comagent.Name = "comagent";
            this.comagent.Size = new System.Drawing.Size(179, 29);
            this.comagent.TabIndex = 9;
            this.comagent.SelectedIndexChanged += new System.EventHandler(this.comagent_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(688, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Invoice No:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Contact:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(354, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 19);
            this.label15.TabIndex = 15;
            this.label15.Text = "Address:";
            // 
            // lable
            // 
            this.lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(37, 262);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(118, 19);
            this.lable.TabIndex = 17;
            this.lable.Text = "India Contact:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(354, 262);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 19);
            this.label19.TabIndex = 19;
            this.label19.Text = "India Address:";
            // 
            // txtcredit
            // 
            this.txtcredit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcredit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcredit.Location = new System.Drawing.Point(429, 377);
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(179, 27);
            this.txtcredit.TabIndex = 11;
            this.txtcredit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcredit_KeyDown);
            this.txtcredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcredit_KeyPress);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(356, 385);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 19);
            this.label20.TabIndex = 21;
            this.label20.Text = "Credit:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Invoice No:";
            this.label3.Visible = false;
            // 
            // totinv
            // 
            this.totinv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totinv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totinv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totinv.Location = new System.Drawing.Point(787, 47);
            this.totinv.Name = "totinv";
            this.totinv.Size = new System.Drawing.Size(140, 28);
            this.totinv.TabIndex = 25;
            // 
            // txtprof
            // 
            this.txtprof.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprof.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprof.Location = new System.Drawing.Point(748, 437);
            this.txtprof.Name = "txtprof";
            this.txtprof.ReadOnly = true;
            this.txtprof.Size = new System.Drawing.Size(97, 27);
            this.txtprof.TabIndex = 13;
            this.txtprof.TabStop = false;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(681, 442);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 19);
            this.label16.TabIndex = 53;
            this.label16.Text = "Profit:";
            // 
            // txtaed
            // 
            this.txtaed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtaed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtaed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaed.ForeColor = System.Drawing.Color.Black;
            this.txtaed.Location = new System.Drawing.Point(150, 428);
            this.txtaed.Name = "txtaed";
            this.txtaed.Size = new System.Drawing.Size(179, 32);
            this.txtaed.TabIndex = 57;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(585, 484);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 27);
            this.textBox2.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(434, 488);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 19);
            this.label18.TabIndex = 58;
            this.label18.Text = "Amount received:";
            // 
            // totindadr
            // 
            this.totindadr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totindadr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totindadr.Location = new System.Drawing.Point(478, 258);
            this.totindadr.Name = "totindadr";
            this.totindadr.ReadOnly = true;
            this.totindadr.Size = new System.Drawing.Size(217, 27);
            this.totindadr.TabIndex = 6;
            // 
            // totadr
            // 
            this.totadr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totadr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totadr.Location = new System.Drawing.Point(478, 203);
            this.totadr.Name = "totadr";
            this.totadr.Size = new System.Drawing.Size(449, 27);
            this.totadr.TabIndex = 4;
            // 
            // totdisc
            // 
            this.totdisc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totdisc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totdisc.Location = new System.Drawing.Point(478, 126);
            this.totdisc.Name = "totdisc";
            this.totdisc.Size = new System.Drawing.Size(449, 27);
            this.totdisc.TabIndex = 2;
            // 
            // totcon
            // 
            this.totcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totcon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totcon.Location = new System.Drawing.Point(150, 203);
            this.totcon.Name = "totcon";
            this.totcon.Size = new System.Drawing.Size(179, 27);
            this.totcon.TabIndex = 3;
            // 
            // totindcon
            // 
            this.totindcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totindcon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totindcon.Location = new System.Drawing.Point(150, 258);
            this.totindcon.Name = "totindcon";
            this.totindcon.ReadOnly = true;
            this.totindcon.Size = new System.Drawing.Size(179, 27);
            this.totindcon.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(494, 432);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 27);
            this.textBox3.TabIndex = 12;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(356, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 65;
            this.label11.Text = "Installments:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(113, 486);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 27);
            this.textBox4.TabIndex = 13;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 19);
            this.label13.TabIndex = 69;
            this.label13.Text = "Paid:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(317, 484);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(97, 27);
            this.textBox5.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(258, 488);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 19);
            this.label14.TabIndex = 67;
            this.label14.Text = "Debit:";
            // 
            // txtcity
            // 
            this.txtcity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(787, 258);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(140, 27);
            this.txtcity.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(722, 262);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 19);
            this.label17.TabIndex = 71;
            this.label17.Text = "City:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // UC_Invoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totindcon);
            this.Controls.Add(this.totcon);
            this.Controls.Add(this.totdisc);
            this.Controls.Add(this.totadr);
            this.Controls.Add(this.totindadr);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtaed);
            this.Controls.Add(this.txtprof);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.totinv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcredit);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comagent);
            this.Controls.Add(this.tottime);
            this.Controls.Add(this.comcustom);
            this.Controls.Add(this.comtype);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtinr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "UC_Invoice";
            this.Size = new System.Drawing.Size(985, 580);
            this.Load += new System.EventHandler(this.UC_Sales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtinr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comtype;
        private System.Windows.Forms.ComboBox comcustom;
        private System.Windows.Forms.Label tottime;
        private System.Windows.Forms.ComboBox comagent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtcredit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totinv;
        private System.Windows.Forms.TextBox txtprof;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txtaed;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox totindadr;
        private System.Windows.Forms.TextBox totadr;
        private System.Windows.Forms.TextBox totdisc;
        private System.Windows.Forms.TextBox totcon;
        private System.Windows.Forms.TextBox totindcon;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label label17;
    }
}
