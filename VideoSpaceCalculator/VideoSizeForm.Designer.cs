namespace VideoSpaceCalculator
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
            this.cmbVideoType = new System.Windows.Forms.ComboBox();
            this.cmbFrame = new System.Windows.Forms.ComboBox();
            this.cmbAudioChannel = new System.Windows.Forms.ComboBox();
            this.cmbHertz = new System.Windows.Forms.ComboBox();
            this.cmbAudioBitRate = new System.Windows.Forms.ComboBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.MB = new System.Windows.Forms.RadioButton();
            this.GB = new System.Windows.Forms.RadioButton();
            this.TB = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbVideoType
            // 
            this.cmbVideoType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cmbVideoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVideoType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbVideoType.ForeColor = System.Drawing.Color.White;
            this.cmbVideoType.FormattingEnabled = true;
            this.cmbVideoType.Items.AddRange(new object[] {
            "XDCAM HD 18 Mbps",
            "XDCAM HD 25 Mbps",
            "XDCAM HD 35 Mbps",
            "XDCAM HD 50 Mbps",
            "IMX 30 Mbps",
            "IMX 40 Mbps",
            "IMX 50 Mbps",
            "HDV 1080i"});
            this.cmbVideoType.Location = new System.Drawing.Point(109, 40);
            this.cmbVideoType.Name = "cmbVideoType";
            this.cmbVideoType.Size = new System.Drawing.Size(164, 25);
            this.cmbVideoType.TabIndex = 0;
            this.cmbVideoType.SelectedIndexChanged += new System.EventHandler(this.cmbVideoType_SelectedIndexChanged);
            // 
            // cmbFrame
            // 
            this.cmbFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cmbFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFrame.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbFrame.ForeColor = System.Drawing.Color.White;
            this.cmbFrame.FormattingEnabled = true;
            this.cmbFrame.Items.AddRange(new object[] {
            "---",
            "23.98 fps",
            "24 fps ",
            "25 fps",
            "29.97 fps",
            "30 fps",
            "50 fps",
            "59.94 fps",
            "60 fps"});
            this.cmbFrame.Location = new System.Drawing.Point(600, 39);
            this.cmbFrame.Name = "cmbFrame";
            this.cmbFrame.Size = new System.Drawing.Size(119, 25);
            this.cmbFrame.TabIndex = 1;
            // 
            // cmbAudioChannel
            // 
            this.cmbAudioChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cmbAudioChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudioChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAudioChannel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbAudioChannel.ForeColor = System.Drawing.Color.White;
            this.cmbAudioChannel.FormattingEnabled = true;
            this.cmbAudioChannel.Items.AddRange(new object[] {
            "No Audio",
            "2 channels",
            "4 channels",
            "6 channels",
            "8 channels"});
            this.cmbAudioChannel.Location = new System.Drawing.Point(109, 113);
            this.cmbAudioChannel.Name = "cmbAudioChannel";
            this.cmbAudioChannel.Size = new System.Drawing.Size(164, 25);
            this.cmbAudioChannel.TabIndex = 2;
            this.cmbAudioChannel.SelectedIndexChanged += new System.EventHandler(this.cmbAudioChannel_SelectedIndexChanged);
            // 
            // cmbHertz
            // 
            this.cmbHertz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cmbHertz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHertz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHertz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbHertz.ForeColor = System.Drawing.Color.White;
            this.cmbHertz.FormattingEnabled = true;
            this.cmbHertz.Items.AddRange(new object[] {
            "32 kHz",
            "48 kHz",
            "96 kHz"});
            this.cmbHertz.Location = new System.Drawing.Point(363, 113);
            this.cmbHertz.Name = "cmbHertz";
            this.cmbHertz.Size = new System.Drawing.Size(132, 25);
            this.cmbHertz.TabIndex = 3;
            // 
            // cmbAudioBitRate
            // 
            this.cmbAudioBitRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cmbAudioBitRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudioBitRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAudioBitRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbAudioBitRate.ForeColor = System.Drawing.Color.White;
            this.cmbAudioBitRate.FormattingEnabled = true;
            this.cmbAudioBitRate.Items.AddRange(new object[] {
            "16 bit",
            "24 bit"});
            this.cmbAudioBitRate.Location = new System.Drawing.Point(600, 113);
            this.cmbAudioBitRate.Name = "cmbAudioBitRate";
            this.cmbAudioBitRate.Size = new System.Drawing.Size(119, 25);
            this.cmbAudioBitRate.TabIndex = 4;
            // 
            // txtHour
            // 
            this.txtHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.txtHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.ForeColor = System.Drawing.Color.White;
            this.txtHour.Location = new System.Drawing.Point(315, 195);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(53, 25);
            this.txtHour.TabIndex = 5;
            this.txtHour.Text = "00";
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinute
            // 
            this.txtMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.txtMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinute.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.ForeColor = System.Drawing.Color.White;
            this.txtMinute.Location = new System.Drawing.Point(439, 195);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(50, 25);
            this.txtMinute.TabIndex = 6;
            this.txtMinute.Text = "00";
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSec
            // 
            this.txtSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.txtSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSec.ForeColor = System.Drawing.Color.White;
            this.txtSec.Location = new System.Drawing.Point(552, 195);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(42, 25);
            this.txtSec.TabIndex = 7;
            this.txtSec.Text = "00";
            this.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.ForeColor = System.Drawing.Color.White;
            this.txtDay.Location = new System.Drawing.Point(204, 195);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(52, 25);
            this.txtDay.TabIndex = 8;
            this.txtDay.Text = "00";
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15F);
            this.label1.Location = new System.Drawing.Point(278, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.25F);
            this.label2.Location = new System.Drawing.Point(398, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.25F);
            this.label3.Location = new System.Drawing.Point(514, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.result.ForeColor = System.Drawing.Color.Firebrick;
            this.result.Location = new System.Drawing.Point(323, 276);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(40, 21);
            this.result.TabIndex = 13;
            this.result.Text = "null";
            // 
            // MB
            // 
            this.MB.AutoSize = true;
            this.MB.Checked = true;
            this.MB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.MB.ForeColor = System.Drawing.Color.White;
            this.MB.Location = new System.Drawing.Point(270, 244);
            this.MB.Name = "MB";
            this.MB.Size = new System.Drawing.Size(46, 21);
            this.MB.TabIndex = 14;
            this.MB.TabStop = true;
            this.MB.Text = "MB";
            this.MB.UseVisualStyleBackColor = true;
            // 
            // GB
            // 
            this.GB.AutoSize = true;
            this.GB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.GB.ForeColor = System.Drawing.Color.White;
            this.GB.Location = new System.Drawing.Point(348, 244);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(43, 21);
            this.GB.TabIndex = 15;
            this.GB.TabStop = true;
            this.GB.Text = "GB";
            this.GB.UseVisualStyleBackColor = true;
            // 
            // TB
            // 
            this.TB.AutoSize = true;
            this.TB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TB.ForeColor = System.Drawing.Color.White;
            this.TB.Location = new System.Drawing.Point(419, 244);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(42, 21);
            this.TB.TabIndex = 16;
            this.TB.TabStop = true;
            this.TB.Text = "TB";
            this.TB.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(363, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Enable FPS -->";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(670, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(319, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(535, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "FPS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Video Format :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Audio Channels:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(280, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Sample Rate :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(529, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Bit Depth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(216, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(378, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Day               :               Hour               :             Minute        " +
    "     :         Second";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(235, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Video Size --> ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(773, 361);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.MB);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.cmbAudioBitRate);
            this.Controls.Add(this.cmbHertz);
            this.Controls.Add(this.cmbAudioChannel);
            this.Controls.Add(this.cmbFrame);
            this.Controls.Add(this.cmbVideoType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bit Depth:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVideoType;
        private System.Windows.Forms.ComboBox cmbFrame;
        private System.Windows.Forms.ComboBox cmbAudioChannel;
        private System.Windows.Forms.ComboBox cmbHertz;
        private System.Windows.Forms.ComboBox cmbAudioBitRate;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.RadioButton MB;
        private System.Windows.Forms.RadioButton GB;
        private System.Windows.Forms.RadioButton TB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

