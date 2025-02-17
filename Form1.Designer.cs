namespace bai8_pheptinhcoban_radiobutton
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbcong = new System.Windows.Forms.RadioButton();
            this.rdbtru = new System.Windows.Forms.RadioButton();
            this.rdbnhan = new System.Windows.Forms.RadioButton();
            this.rdbchia = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "phep tính cơ bản radioButon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "sô1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "số2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "KQ";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(257, 196);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 1;
            this.btntinh.Text = "tính ";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(245, 93);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 2;
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(245, 128);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 2;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(245, 170);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbchia);
            this.groupBox1.Controls.Add(this.rdbnhan);
            this.groupBox1.Controls.Add(this.rdbtru);
            this.groupBox1.Controls.Add(this.rdbcong);
            this.groupBox1.Location = new System.Drawing.Point(408, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "phép tính ";
            // 
            // rdbcong
            // 
            this.rdbcong.AutoSize = true;
            this.rdbcong.Location = new System.Drawing.Point(21, 29);
            this.rdbcong.Name = "rdbcong";
            this.rdbcong.Size = new System.Drawing.Size(52, 17);
            this.rdbcong.TabIndex = 0;
            this.rdbcong.TabStop = true;
            this.rdbcong.Text = "cộng ";
            this.rdbcong.UseVisualStyleBackColor = true;
            // 
            // rdbtru
            // 
            this.rdbtru.AutoSize = true;
            this.rdbtru.Location = new System.Drawing.Point(21, 57);
            this.rdbtru.Name = "rdbtru";
            this.rdbtru.Size = new System.Drawing.Size(37, 17);
            this.rdbtru.TabIndex = 0;
            this.rdbtru.TabStop = true;
            this.rdbtru.Text = "trừ";
            this.rdbtru.UseVisualStyleBackColor = true;
            // 
            // rdbnhan
            // 
            this.rdbnhan.AutoSize = true;
            this.rdbnhan.Location = new System.Drawing.Point(21, 80);
            this.rdbnhan.Name = "rdbnhan";
            this.rdbnhan.Size = new System.Drawing.Size(52, 17);
            this.rdbnhan.TabIndex = 0;
            this.rdbnhan.TabStop = true;
            this.rdbnhan.Text = "nhân ";
            this.rdbnhan.UseVisualStyleBackColor = true;
            // 
            // rdbchia
            // 
            this.rdbchia.AutoSize = true;
            this.rdbchia.Location = new System.Drawing.Point(21, 103);
            this.rdbchia.Name = "rdbchia";
            this.rdbchia.Size = new System.Drawing.Size(45, 17);
            this.rdbchia.TabIndex = 0;
            this.rdbchia.TabStop = true;
            this.rdbchia.Text = "chia";
            this.rdbchia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbchia;
        private System.Windows.Forms.RadioButton rdbnhan;
        private System.Windows.Forms.RadioButton rdbtru;
        private System.Windows.Forms.RadioButton rdbcong;
    }
}

