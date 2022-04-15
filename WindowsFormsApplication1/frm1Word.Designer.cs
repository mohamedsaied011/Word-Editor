namespace WindowsFormsApplication1
{
    partial class frm1Word
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
            this.txt = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxfont = new System.Windows.Forms.ComboBox();
            this.nudsize = new System.Windows.Forms.NumericUpDown();
            this.cbxb = new System.Windows.Forms.CheckBox();
            this.cbxu = new System.Windows.Forms.CheckBox();
            this.cbxi = new System.Windows.Forms.CheckBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.btnmore = new System.Windows.Forms.Button();
            this.rdotext = new System.Windows.Forms.RadioButton();
            this.rdoback = new System.Windows.Forms.RadioButton();
            this.pnl10 = new System.Windows.Forms.Panel();
            this.pnl9 = new System.Windows.Forms.Panel();
            this.pnl11 = new System.Windows.Forms.Panel();
            this.pnl12 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudsize)).BeginInit();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt.Location = new System.Drawing.Point(0, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(1598, 598);
            this.txt.TabIndex = 0;
            this.txt.Text = "Hello \nWelcome to my Program for notes and Editor Words\n\nMohamed Elsaied";
            this.txt.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 600);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "size";
            // 
            // cbxfont
            // 
            this.cbxfont.FormattingEnabled = true;
            this.cbxfont.Location = new System.Drawing.Point(12, 36);
            this.cbxfont.Name = "cbxfont";
            this.cbxfont.Size = new System.Drawing.Size(204, 32);
            this.cbxfont.TabIndex = 4;
            this.cbxfont.SelectedIndexChanged += new System.EventHandler(this.cbxfont_SelectedIndexChanged);
            // 
            // nudsize
            // 
            this.nudsize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudsize.Location = new System.Drawing.Point(222, 37);
            this.nudsize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudsize.Name = "nudsize";
            this.nudsize.Size = new System.Drawing.Size(49, 29);
            this.nudsize.TabIndex = 5;
            this.nudsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudsize.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nudsize.ValueChanged += new System.EventHandler(this.cbxfont_SelectedIndexChanged);
            // 
            // cbxb
            // 
            this.cbxb.AutoSize = true;
            this.cbxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxb.Location = new System.Drawing.Point(277, 36);
            this.cbxb.Name = "cbxb";
            this.cbxb.Size = new System.Drawing.Size(71, 28);
            this.cbxb.TabIndex = 6;
            this.cbxb.Text = "Bold";
            this.cbxb.UseVisualStyleBackColor = true;
            this.cbxb.CheckedChanged += new System.EventHandler(this.cbxfont_SelectedIndexChanged);
            // 
            // cbxu
            // 
            this.cbxu.AutoSize = true;
            this.cbxu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxu.Location = new System.Drawing.Point(354, 36);
            this.cbxu.Name = "cbxu";
            this.cbxu.Size = new System.Drawing.Size(111, 28);
            this.cbxu.TabIndex = 7;
            this.cbxu.Text = "Underline";
            this.cbxu.UseVisualStyleBackColor = true;
            this.cbxu.CheckedChanged += new System.EventHandler(this.cbxfont_SelectedIndexChanged);
            // 
            // cbxi
            // 
            this.cbxi.AutoSize = true;
            this.cbxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxi.Location = new System.Drawing.Point(471, 36);
            this.cbxi.Name = "cbxi";
            this.cbxi.Size = new System.Drawing.Size(65, 28);
            this.cbxi.TabIndex = 8;
            this.cbxi.Text = "Italic";
            this.cbxi.UseVisualStyleBackColor = true;
            this.cbxi.CheckedChanged += new System.EventHandler(this.cbxfont_SelectedIndexChanged);
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Red;
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl2.Location = new System.Drawing.Point(664, 42);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(27, 27);
            this.pnl2.TabIndex = 9;
            this.pnl2.Click += new System.EventHandler(this.pnl1_Click);
            this.pnl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Blue;
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl1.Location = new System.Drawing.Point(664, 9);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(27, 27);
            this.pnl1.TabIndex = 10;
            this.pnl1.Click += new System.EventHandler(this.pnl1_Click);
            this.pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.Yellow;
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl3.Location = new System.Drawing.Point(707, 10);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(27, 27);
            this.pnl3.TabIndex = 12;
            this.pnl3.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.Green;
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl4.Location = new System.Drawing.Point(707, 43);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(27, 27);
            this.pnl4.TabIndex = 11;
            this.pnl4.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl7
            // 
            this.pnl7.BackColor = System.Drawing.Color.Silver;
            this.pnl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl7.Location = new System.Drawing.Point(794, 10);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(27, 27);
            this.pnl7.TabIndex = 16;
            this.pnl7.Click += new System.EventHandler(this.pnl1_Click);
            this.pnl7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // pnl8
            // 
            this.pnl8.BackColor = System.Drawing.Color.Pink;
            this.pnl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl8.Location = new System.Drawing.Point(794, 43);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(27, 27);
            this.pnl8.TabIndex = 15;
            this.pnl8.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.Orange;
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl5.Location = new System.Drawing.Point(751, 9);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(27, 27);
            this.pnl5.TabIndex = 14;
            this.pnl5.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl6
            // 
            this.pnl6.BackColor = System.Drawing.Color.Gold;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl6.Location = new System.Drawing.Point(751, 42);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(27, 27);
            this.pnl6.TabIndex = 13;
            this.pnl6.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // btnmore
            // 
            this.btnmore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmore.ForeColor = System.Drawing.Color.White;
            this.btnmore.Location = new System.Drawing.Point(934, 10);
            this.btnmore.Name = "btnmore";
            this.btnmore.Size = new System.Drawing.Size(142, 59);
            this.btnmore.TabIndex = 21;
            this.btnmore.Text = "More Colors";
            this.btnmore.UseVisualStyleBackColor = false;
            this.btnmore.Click += new System.EventHandler(this.btnmore_Click);
            // 
            // rdotext
            // 
            this.rdotext.AutoSize = true;
            this.rdotext.Checked = true;
            this.rdotext.Location = new System.Drawing.Point(560, 9);
            this.rdotext.Name = "rdotext";
            this.rdotext.Size = new System.Drawing.Size(65, 28);
            this.rdotext.TabIndex = 22;
            this.rdotext.TabStop = true;
            this.rdotext.Text = "Text";
            this.rdotext.UseVisualStyleBackColor = true;
            // 
            // rdoback
            // 
            this.rdoback.AutoSize = true;
            this.rdoback.Location = new System.Drawing.Point(560, 40);
            this.rdoback.Name = "rdoback";
            this.rdoback.Size = new System.Drawing.Size(69, 28);
            this.rdoback.TabIndex = 23;
            this.rdoback.Text = "Back";
            this.rdoback.UseVisualStyleBackColor = true;
            // 
            // pnl10
            // 
            this.pnl10.BackColor = System.Drawing.Color.Navy;
            this.pnl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl10.Location = new System.Drawing.Point(837, 43);
            this.pnl10.Name = "pnl10";
            this.pnl10.Size = new System.Drawing.Size(27, 27);
            this.pnl10.TabIndex = 17;
            this.pnl10.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl9
            // 
            this.pnl9.BackColor = System.Drawing.Color.Fuchsia;
            this.pnl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl9.Location = new System.Drawing.Point(837, 10);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(27, 27);
            this.pnl9.TabIndex = 18;
            this.pnl9.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl11
            // 
            this.pnl11.BackColor = System.Drawing.Color.Black;
            this.pnl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl11.Location = new System.Drawing.Point(881, 12);
            this.pnl11.Name = "pnl11";
            this.pnl11.Size = new System.Drawing.Size(27, 27);
            this.pnl11.TabIndex = 24;
            this.pnl11.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl12
            // 
            this.pnl12.BackColor = System.Drawing.Color.White;
            this.pnl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl12.Location = new System.Drawing.Point(881, 45);
            this.pnl12.Name = "pnl12";
            this.pnl12.Size = new System.Drawing.Size(27, 27);
            this.pnl12.TabIndex = 25;
            this.pnl12.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // frm1Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1089, 771);
            this.Controls.Add(this.pnl12);
            this.Controls.Add(this.pnl11);
            this.Controls.Add(this.cbxfont);
            this.Controls.Add(this.rdoback);
            this.Controls.Add(this.rdotext);
            this.Controls.Add(this.btnmore);
            this.Controls.Add(this.pnl7);
            this.Controls.Add(this.pnl8);
            this.Controls.Add(this.pnl9);
            this.Controls.Add(this.pnl10);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.pnl6);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.cbxi);
            this.Controls.Add(this.cbxu);
            this.Controls.Add(this.cbxb);
            this.Controls.Add(this.nudsize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm1Word";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudsize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxfont;
        private System.Windows.Forms.NumericUpDown nudsize;
        private System.Windows.Forms.CheckBox cbxb;
        private System.Windows.Forms.CheckBox cbxu;
        private System.Windows.Forms.CheckBox cbxi;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Button btnmore;
        private System.Windows.Forms.RadioButton rdotext;
        private System.Windows.Forms.RadioButton rdoback;
        private System.Windows.Forms.Panel pnl10;
        private System.Windows.Forms.Panel pnl9;
        private System.Windows.Forms.Panel pnl11;
        private System.Windows.Forms.Panel pnl12;
    }
}

