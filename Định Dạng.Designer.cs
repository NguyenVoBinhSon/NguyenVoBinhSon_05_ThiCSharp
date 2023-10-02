namespace NguyenVoBinhSon_05_ThiCSharp
{
    partial class Định_Dạng
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
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.txtLapTrinh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBlod = new System.Windows.Forms.CheckBox();
            this.chkNghieng = new System.Windows.Forms.CheckBox();
            this.chkUnderLine = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapTen.Location = new System.Drawing.Point(12, 20);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(168, 33);
            this.lblNhapTen.TabIndex = 0;
            this.lblNhapTen.Text = "Nhập Tên :";
            this.lblNhapTen.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTen.ForeColor = System.Drawing.Color.Red;
            this.txtNhapTen.Location = new System.Drawing.Point(212, 20);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(547, 38);
            this.txtNhapTen.TabIndex = 1;
            this.txtNhapTen.Text = "Đề Thi CShap C#";
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtNhapTen_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.radBlack);
            this.groupBox1.Controls.Add(this.radBlue);
            this.groupBox1.Controls.Add(this.radGreen);
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 293);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Location = new System.Drawing.Point(15, 220);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(104, 35);
            this.radBlack.TabIndex = 6;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(15, 161);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(90, 35);
            this.radBlue.TabIndex = 5;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(15, 104);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(112, 35);
            this.radGreen.TabIndex = 4;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(15, 47);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(85, 35);
            this.radRed.TabIndex = 3;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.AutoSize = true;
            this.lblLapTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapTrinh.Location = new System.Drawing.Point(12, 438);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(219, 33);
            this.lblLapTrinh.TabIndex = 3;
            this.lblLapTrinh.Text = "Lập Trình Bởi :";
            // 
            // txtLapTrinh
            // 
            this.txtLapTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLapTrinh.ForeColor = System.Drawing.Color.Red;
            this.txtLapTrinh.Location = new System.Drawing.Point(241, 438);
            this.txtLapTrinh.Name = "txtLapTrinh";
            this.txtLapTrinh.ReadOnly = true;
            this.txtLapTrinh.Size = new System.Drawing.Size(547, 38);
            this.txtLapTrinh.TabIndex = 4;
            this.txtLapTrinh.Text = "Đề Thi CShap C#";
            this.txtLapTrinh.TextChanged += new System.EventHandler(this.txtLapTrinh_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.chkUnderLine);
            this.groupBox2.Controls.Add(this.chkNghieng);
            this.groupBox2.Controls.Add(this.chkBlod);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(498, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 293);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // chkBlod
            // 
            this.chkBlod.AutoSize = true;
            this.chkBlod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkBlod.Location = new System.Drawing.Point(25, 47);
            this.chkBlod.Name = "chkBlod";
            this.chkBlod.Size = new System.Drawing.Size(159, 35);
            this.chkBlod.TabIndex = 0;
            this.chkBlod.Text = "Đậm Blod";
            this.chkBlod.UseVisualStyleBackColor = true;
            this.chkBlod.CheckedChanged += new System.EventHandler(this.chkBlod_CheckedChanged);
            // 
            // chkNghieng
            // 
            this.chkNghieng.AutoSize = true;
            this.chkNghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNghieng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkNghieng.Location = new System.Drawing.Point(25, 133);
            this.chkNghieng.Name = "chkNghieng";
            this.chkNghieng.Size = new System.Drawing.Size(212, 35);
            this.chkNghieng.TabIndex = 1;
            this.chkNghieng.Text = "Nghiêng Italic";
            this.chkNghieng.UseVisualStyleBackColor = true;
            // 
            // chkUnderLine
            // 
            this.chkUnderLine.AutoSize = true;
            this.chkUnderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.chkUnderLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkUnderLine.Location = new System.Drawing.Point(25, 220);
            this.chkUnderLine.Name = "chkUnderLine";
            this.chkUnderLine.Size = new System.Drawing.Size(179, 35);
            this.chkUnderLine.TabIndex = 2;
            this.chkUnderLine.Text = "Gạch Chân";
            this.chkUnderLine.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(18, 532);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(770, 82);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Định_Dạng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtLapTrinh);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.lblNhapTen);
            this.Name = "Định_Dạng";
            this.Text = "Định_Dạng";
            this.Load += new System.EventHandler(this.Định_Dạng_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.Label lblLapTrinh;
        private System.Windows.Forms.TextBox txtLapTrinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkUnderLine;
        private System.Windows.Forms.CheckBox chkNghieng;
        private System.Windows.Forms.CheckBox chkBlod;
        private System.Windows.Forms.Button btnThoat;
    }
}