namespace SystemC
{
    partial class Form4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbroom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbposition = new System.Windows.Forms.TextBox();
            this.rcash = new System.Windows.Forms.RadioButton();
            this.rbank = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rPenbank = new System.Windows.Forms.RadioButton();
            this.rBDO = new System.Windows.Forms.RadioButton();
            this.rmc = new System.Windows.Forms.RadioButton();
            this.pMode = new System.Windows.Forms.Panel();
            this.tbmode = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbnum1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbmonth = new System.Windows.Forms.ComboBox();
            this.tbdayIn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbdayOut = new System.Windows.Forms.TextBox();
            this.cmbmonthOut = new System.Windows.Forms.ComboBox();
            this.tbmonthin = new System.Windows.Forms.TextBox();
            this.tbmonthsout = new System.Windows.Forms.TextBox();
            this.tbrooms = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblPending = new System.Windows.Forms.Label();
            this.pMode.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbroom
            // 
            this.cmbroom.FormattingEnabled = true;
            this.cmbroom.Items.AddRange(new object[] {
            "Single",
            "Double Room",
            "Tripple Room",
            "Quad Bedroom"});
            this.cmbroom.Location = new System.Drawing.Point(81, 139);
            this.cmbroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbroom.Name = "cmbroom";
            this.cmbroom.Size = new System.Drawing.Size(184, 24);
            this.cmbroom.TabIndex = 0;
            this.cmbroom.SelectedIndexChanged += new System.EventHandler(this.cmbroom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rooms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Check In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Check Out";
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(178, 331);
            this.tbfname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(238, 22);
            this.tbfname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Full name";
            // 
            // tbposition
            // 
            this.tbposition.Location = new System.Drawing.Point(178, 374);
            this.tbposition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbposition.Name = "tbposition";
            this.tbposition.Size = new System.Drawing.Size(238, 22);
            this.tbposition.TabIndex = 8;
            // 
            // rcash
            // 
            this.rcash.AutoSize = true;
            this.rcash.Location = new System.Drawing.Point(120, 48);
            this.rcash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcash.Name = "rcash";
            this.rcash.Size = new System.Drawing.Size(59, 20);
            this.rcash.TabIndex = 10;
            this.rcash.TabStop = true;
            this.rcash.Text = "Cash";
            this.rcash.UseVisualStyleBackColor = true;
            this.rcash.CheckedChanged += new System.EventHandler(this.rcash_CheckedChanged);
            // 
            // rbank
            // 
            this.rbank.AutoSize = true;
            this.rbank.Location = new System.Drawing.Point(235, 48);
            this.rbank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbank.Name = "rbank";
            this.rbank.Size = new System.Drawing.Size(59, 20);
            this.rbank.TabIndex = 11;
            this.rbank.TabStop = true;
            this.rbank.Text = "Bank";
            this.rbank.UseVisualStyleBackColor = true;
            this.rbank.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mode Of Payment";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rPenbank
            // 
            this.rPenbank.AutoSize = true;
            this.rPenbank.Location = new System.Drawing.Point(20, 13);
            this.rPenbank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rPenbank.Name = "rPenbank";
            this.rPenbank.Size = new System.Drawing.Size(83, 20);
            this.rPenbank.TabIndex = 14;
            this.rPenbank.TabStop = true;
            this.rPenbank.Text = "PenBank";
            this.rPenbank.UseVisualStyleBackColor = true;
            this.rPenbank.CheckedChanged += new System.EventHandler(this.rPenbank_CheckedChanged);
            // 
            // rBDO
            // 
            this.rBDO.AutoSize = true;
            this.rBDO.Location = new System.Drawing.Point(129, 13);
            this.rBDO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBDO.Name = "rBDO";
            this.rBDO.Size = new System.Drawing.Size(57, 20);
            this.rBDO.TabIndex = 15;
            this.rBDO.TabStop = true;
            this.rBDO.Text = "BDO";
            this.rBDO.UseVisualStyleBackColor = true;
            this.rBDO.CheckedChanged += new System.EventHandler(this.rBDO_CheckedChanged);
            // 
            // rmc
            // 
            this.rmc.AutoSize = true;
            this.rmc.Location = new System.Drawing.Point(235, 13);
            this.rmc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rmc.Name = "rmc";
            this.rmc.Size = new System.Drawing.Size(101, 20);
            this.rmc.TabIndex = 16;
            this.rmc.TabStop = true;
            this.rmc.Text = "Master Card";
            this.rmc.UseVisualStyleBackColor = true;
            this.rmc.CheckedChanged += new System.EventHandler(this.rmc_CheckedChanged);
            // 
            // pMode
            // 
            this.pMode.Controls.Add(this.rmc);
            this.pMode.Controls.Add(this.rBDO);
            this.pMode.Controls.Add(this.rPenbank);
            this.pMode.Location = new System.Drawing.Point(76, 502);
            this.pMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pMode.Name = "pMode";
            this.pMode.Size = new System.Drawing.Size(367, 83);
            this.pMode.TabIndex = 17;
            this.pMode.Visible = false;
            // 
            // tbmode
            // 
            this.tbmode.Location = new System.Drawing.Point(137, 12);
            this.tbmode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmode.Name = "tbmode";
            this.tbmode.Size = new System.Drawing.Size(135, 22);
            this.tbmode.TabIndex = 23;
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(323, 141);
            this.tbprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(96, 22);
            this.tbprice.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbmode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rbank);
            this.panel1.Controls.Add(this.rcash);
            this.panel1.Location = new System.Drawing.Point(96, 408);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 84);
            this.panel1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(516, 198);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.Size = new System.Drawing.Size(539, 240);
            this.dgvStock.TabIndex = 27;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 464);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(558, 464);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 28);
            this.button4.TabIndex = 23;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbnum1
            // 
            this.tbnum1.Location = new System.Drawing.Point(54, 89);
            this.tbnum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbnum1.Name = "tbnum1";
            this.tbnum1.Size = new System.Drawing.Size(135, 22);
            this.tbnum1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Number ";
            // 
            // cmbmonth
            // 
            this.cmbmonth.FormattingEnabled = true;
            this.cmbmonth.Items.AddRange(new object[] {
            "january",
            "febuary",
            "march",
            "april",
            "may",
            "june",
            "july",
            "august",
            "september",
            "october",
            "november",
            "december"});
            this.cmbmonth.Location = new System.Drawing.Point(167, 207);
            this.cmbmonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(190, 24);
            this.cmbmonth.TabIndex = 32;
            this.cmbmonth.SelectedIndexChanged += new System.EventHandler(this.cmbmonth_SelectedIndexChanged);
            // 
            // tbdayIn
            // 
            this.tbdayIn.Location = new System.Drawing.Point(372, 209);
            this.tbdayIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbdayIn.Name = "tbdayIn";
            this.tbdayIn.Size = new System.Drawing.Size(78, 22);
            this.tbdayIn.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Days";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Months";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "Months";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(400, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Days";
            // 
            // tbdayOut
            // 
            this.tbdayOut.Location = new System.Drawing.Point(382, 278);
            this.tbdayOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbdayOut.Name = "tbdayOut";
            this.tbdayOut.Size = new System.Drawing.Size(78, 22);
            this.tbdayOut.TabIndex = 38;
            // 
            // cmbmonthOut
            // 
            this.cmbmonthOut.FormattingEnabled = true;
            this.cmbmonthOut.Items.AddRange(new object[] {
            "january",
            "febuary",
            "march",
            "april",
            "may",
            "june",
            "july",
            "august",
            "september",
            "october",
            "november",
            "december"});
            this.cmbmonthOut.Location = new System.Drawing.Point(178, 277);
            this.cmbmonthOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbmonthOut.Name = "cmbmonthOut";
            this.cmbmonthOut.Size = new System.Drawing.Size(190, 24);
            this.cmbmonthOut.TabIndex = 37;
            this.cmbmonthOut.SelectedIndexChanged += new System.EventHandler(this.cmbmonthOut_SelectedIndexChanged);
            // 
            // tbmonthin
            // 
            this.tbmonthin.Location = new System.Drawing.Point(172, 234);
            this.tbmonthin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmonthin.Name = "tbmonthin";
            this.tbmonthin.Size = new System.Drawing.Size(135, 22);
            this.tbmonthin.TabIndex = 41;
            // 
            // tbmonthsout
            // 
            this.tbmonthsout.Location = new System.Drawing.Point(178, 304);
            this.tbmonthsout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmonthsout.Name = "tbmonthsout";
            this.tbmonthsout.Size = new System.Drawing.Size(135, 22);
            this.tbmonthsout.TabIndex = 42;
            // 
            // tbrooms
            // 
            this.tbrooms.Location = new System.Drawing.Point(81, 166);
            this.tbrooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbrooms.Name = "tbrooms";
            this.tbrooms.Size = new System.Drawing.Size(135, 22);
            this.tbrooms.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(91, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "Position";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(33, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 16);
            this.linkLabel1.TabIndex = 47;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log OUT";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Location = new System.Drawing.Point(174, 356);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(55, 16);
            this.lblPending.TabIndex = 46;
            this.lblPending.Text = "Position";
            this.lblPending.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1240, 611);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbrooms);
            this.Controls.Add(this.tbmonthsout);
            this.Controls.Add(this.tbmonthin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbdayOut);
            this.Controls.Add(this.cmbmonthOut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbdayIn);
            this.Controls.Add(this.cmbmonth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbnum1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pMode);
            this.Controls.Add(this.tbposition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbroom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.pMode.ResumeLayout(false);
            this.pMode.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbposition;
        private System.Windows.Forms.RadioButton rcash;
        private System.Windows.Forms.RadioButton rbank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rPenbank;
        private System.Windows.Forms.RadioButton rBDO;
        private System.Windows.Forms.RadioButton rmc;
        private System.Windows.Forms.Panel pMode;
        private System.Windows.Forms.TextBox tbmode;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbnum1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbmonth;
        private System.Windows.Forms.TextBox tbdayIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbdayOut;
        private System.Windows.Forms.ComboBox cmbmonthOut;
        private System.Windows.Forms.TextBox tbmonthin;
        private System.Windows.Forms.TextBox tbmonthsout;
        private System.Windows.Forms.TextBox tbrooms;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblPending;
    }
}