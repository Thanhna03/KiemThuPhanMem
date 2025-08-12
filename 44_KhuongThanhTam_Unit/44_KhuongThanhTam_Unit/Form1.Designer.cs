namespace _44_KhuongThanhTam_Unit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnum = new TextBox();
            txtresult = new TextBox();
            btnh = new Button();
            btTh_Nh = new Button();
            btDel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 38);
            label1.Name = "label1";
            label1.Size = new Size(376, 36);
            label1.TabIndex = 0;
            label1.Text = "CHUYỂN ĐỔI NHỊ PHÂN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(32, 111);
            label2.Name = "label2";
            label2.Size = new Size(272, 27);
            label2.TabIndex = 1;
            label2.Text = "Nhập số cần chuyển đổi";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F);
            label3.Location = new Point(32, 154);
            label3.Name = "label3";
            label3.Size = new Size(96, 27);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtnum
            // 
            txtnum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnum.Location = new Point(310, 109);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(262, 33);
            txtnum.TabIndex = 3;
            // 
            // txtresult
            // 
            txtresult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtresult.Location = new Point(310, 170);
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(262, 33);
            txtresult.TabIndex = 4;
            // 
            // btnh
            // 
            btnh.BackColor = SystemColors.InactiveCaption;
            btnh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnh.Location = new Point(13, 308);
            btnh.Name = "btnh";
            btnh.Size = new Size(230, 64);
            btnh.TabIndex = 5;
            btnh.Text = "Nhị phân -> Thập phân";
            btnh.UseVisualStyleBackColor = false;
            btnh.Click += btnh_Click;
            // 
            // btTh_Nh
            // 
            btTh_Nh.BackColor = SystemColors.InactiveCaption;
            btTh_Nh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTh_Nh.Location = new Point(277, 308);
            btTh_Nh.Name = "btTh_Nh";
            btTh_Nh.Size = new Size(230, 64);
            btTh_Nh.TabIndex = 6;
            btTh_Nh.Text = "Thập phân -> Nhị phân";
            btTh_Nh.UseVisualStyleBackColor = false;
            btTh_Nh.Click += btTh_Nh_Click;
            // 
            // btDel
            // 
            btDel.BackColor = SystemColors.InactiveCaption;
            btDel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDel.Location = new Point(549, 307);
            btDel.Name = "btDel";
            btDel.Size = new Size(102, 65);
            btDel.TabIndex = 7;
            btDel.Text = "Xóa";
            btDel.UseVisualStyleBackColor = false;
            btDel.Click += btDel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(737, 450);
            Controls.Add(btDel);
            Controls.Add(btTh_Nh);
            Controls.Add(btnh);
            Controls.Add(txtresult);
            Controls.Add(txtnum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Chuyển đổi nhị phân";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnum;
        private TextBox txtresult;
        private Button btnh;
        private Button btTh_Nh;
        private Button btDel;
    }
}
