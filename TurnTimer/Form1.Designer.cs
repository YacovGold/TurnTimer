namespace TurnTimer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.cb_autoRestart = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cb_ringForEver = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_15 = new System.Windows.Forms.RadioButton();
            this.rb_10 = new System.Windows.Forms.RadioButton();
            this.rb_5 = new System.Windows.Forms.RadioButton();
            this.rb_c = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.n_s = new System.Windows.Forms.NumericUpDown();
            this.n_h = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.n_m = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeSpanControl1 = new TurnTimer.TimeSpanControl();
            ((System.ComponentModel.ISupportInitialize)(this.n_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_m)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(27, 85);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "התחל";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // cb_autoRestart
            // 
            this.cb_autoRestart.AutoSize = true;
            this.cb_autoRestart.Location = new System.Drawing.Point(12, 143);
            this.cb_autoRestart.Name = "cb_autoRestart";
            this.cb_autoRestart.Size = new System.Drawing.Size(105, 17);
            this.cb_autoRestart.TabIndex = 1;
            this.cb_autoRestart.Text = "חזרה אוטומטית";
            this.cb_autoRestart.UseVisualStyleBackColor = true;
            this.cb_autoRestart.CheckedChanged += new System.EventHandler(this.cb_autoRestart_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(130, 195);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(355, 41);
            this.progressBar1.TabIndex = 4;
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(283, 19);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(60, 17);
            this.rb_3.TabIndex = 5;
            this.rb_3.Tag = "3";
            this.rb_3.Text = "3 דקות";
            this.rb_3.UseVisualStyleBackColor = true;
            this.rb_3.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Enabled = false;
            this.btn_reset.Location = new System.Drawing.Point(27, 114);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "איפוס";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // cb_ringForEver
            // 
            this.cb_ringForEver.AutoSize = true;
            this.cb_ringForEver.Location = new System.Drawing.Point(27, 166);
            this.cb_ringForEver.Name = "cb_ringForEver";
            this.cb_ringForEver.Size = new System.Drawing.Size(90, 17);
            this.cb_ringForEver.TabIndex = 7;
            this.cb_ringForEver.Text = "צלצל לעולם";
            this.cb_ringForEver.UseVisualStyleBackColor = true;
            this.cb_ringForEver.CheckedChanged += new System.EventHandler(this.cb_ringForEver_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(123, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 227);
            this.label2.TabIndex = 8;
            // 
            // rb_15
            // 
            this.rb_15.AutoSize = true;
            this.rb_15.Location = new System.Drawing.Point(73, 19);
            this.rb_15.Name = "rb_15";
            this.rb_15.Size = new System.Drawing.Size(66, 17);
            this.rb_15.TabIndex = 9;
            this.rb_15.Tag = "15";
            this.rb_15.Text = "15 דקות";
            this.rb_15.UseVisualStyleBackColor = true;
            this.rb_15.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_10
            // 
            this.rb_10.AutoSize = true;
            this.rb_10.Location = new System.Drawing.Point(145, 19);
            this.rb_10.Name = "rb_10";
            this.rb_10.Size = new System.Drawing.Size(66, 17);
            this.rb_10.TabIndex = 10;
            this.rb_10.Tag = "10";
            this.rb_10.Text = "10 דקות";
            this.rb_10.UseVisualStyleBackColor = true;
            this.rb_10.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_5
            // 
            this.rb_5.AutoSize = true;
            this.rb_5.Location = new System.Drawing.Point(217, 19);
            this.rb_5.Name = "rb_5";
            this.rb_5.Size = new System.Drawing.Size(60, 17);
            this.rb_5.TabIndex = 11;
            this.rb_5.Tag = "5";
            this.rb_5.Text = "5 דקות";
            this.rb_5.UseVisualStyleBackColor = true;
            this.rb_5.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_c
            // 
            this.rb_c.AutoSize = true;
            this.rb_c.Location = new System.Drawing.Point(8, 19);
            this.rb_c.Name = "rb_c";
            this.rb_c.Size = new System.Drawing.Size(59, 17);
            this.rb_c.TabIndex = 12;
            this.rb_c.Tag = "0";
            this.rb_c.Text = "מותאם";
            this.rb_c.UseVisualStyleBackColor = true;
            this.rb_c.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "שניות";
            // 
            // n_s
            // 
            this.n_s.Location = new System.Drawing.Point(354, 105);
            this.n_s.Name = "n_s";
            this.n_s.Size = new System.Drawing.Size(48, 20);
            this.n_s.TabIndex = 14;
            // 
            // n_h
            // 
            this.n_h.Location = new System.Drawing.Point(207, 105);
            this.n_h.Name = "n_h";
            this.n_h.Size = new System.Drawing.Size(48, 20);
            this.n_h.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "שעות";
            // 
            // n_m
            // 
            this.n_m.Location = new System.Drawing.Point(276, 105);
            this.n_m.Name = "n_m";
            this.n_m.Size = new System.Drawing.Size(48, 20);
            this.n_m.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "דקות";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_15);
            this.groupBox1.Controls.Add(this.rb_3);
            this.groupBox1.Controls.Add(this.rb_10);
            this.groupBox1.Controls.Add(this.rb_5);
            this.groupBox1.Controls.Add(this.rb_c);
            this.groupBox1.Location = new System.Drawing.Point(132, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 57);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "תבניות";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeSpanControl1
            // 
            this.timeSpanControl1.Location = new System.Drawing.Point(130, 143);
            this.timeSpanControl1.Name = "timeSpanControl1";
            this.timeSpanControl1.Size = new System.Drawing.Size(355, 46);
            this.timeSpanControl1.TabIndex = 20;
            this.timeSpanControl1.TimeSpan = System.TimeSpan.Parse("00:00:00");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 248);
            this.Controls.Add(this.timeSpanControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.n_m);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.n_h);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n_s);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_ringForEver);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cb_autoRestart);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ((System.ComponentModel.ISupportInitialize)(this.n_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_m)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.CheckBox cb_autoRestart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.CheckBox cb_ringForEver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_15;
        private System.Windows.Forms.RadioButton rb_10;
        private System.Windows.Forms.RadioButton rb_5;
        private System.Windows.Forms.RadioButton rb_c;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown n_s;
        private System.Windows.Forms.NumericUpDown n_h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown n_m;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private TimeSpanControl timeSpanControl1;
        private System.Windows.Forms.Timer timer1;
    }
}

