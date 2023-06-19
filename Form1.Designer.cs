namespace Form1
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
            lbNumber1 = new Label();
            LbCal = new Label();
            lbNumber2 = new Label();
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            lbResult = new Label();
            lbKetQua = new Label();
            btnDong = new Button();
            SuspendLayout();
            // 
            // lbNumber1
            // 
            lbNumber1.AutoSize = true;
            lbNumber1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbNumber1.Location = new Point(87, 115);
            lbNumber1.Name = "lbNumber1";
            lbNumber1.Size = new Size(121, 24);
            lbNumber1.TabIndex = 0;
            lbNumber1.Text = "First number:";
            // 
            // LbCal
            // 
            LbCal.AutoSize = true;
            LbCal.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            LbCal.Location = new Point(313, 36);
            LbCal.Name = "LbCal";
            LbCal.Size = new Size(174, 39);
            LbCal.TabIndex = 1;
            LbCal.Text = "Calculator";
            // 
            // lbNumber2
            // 
            lbNumber2.AutoSize = true;
            lbNumber2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbNumber2.Location = new Point(425, 115);
            lbNumber2.Name = "lbNumber2";
            lbNumber2.Size = new Size(152, 24);
            lbNumber2.TabIndex = 2;
            lbNumber2.Text = "Second number:";
            // 
            // txtBox1
            // 
            txtBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox1.Location = new Point(236, 112);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(100, 31);
            txtBox1.TabIndex = 0;
            // 
            // txtBox2
            // 
            txtBox2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox2.Location = new Point(613, 112);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(100, 31);
            txtBox2.TabIndex = 1;
            // 
            // btnCong
            // 
            btnCong.BackColor = Color.FromArgb(224, 224, 224);
            btnCong.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCong.Location = new Point(135, 185);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(80, 80);
            btnCong.TabIndex = 2;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = false;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.BackColor = Color.FromArgb(224, 224, 224);
            btnTru.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnTru.Location = new Point(288, 185);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(80, 80);
            btnTru.TabIndex = 3;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = false;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.BackColor = Color.FromArgb(224, 224, 224);
            btnNhan.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhan.Location = new Point(432, 185);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(80, 80);
            btnNhan.TabIndex = 4;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = false;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.BackColor = Color.FromArgb(224, 224, 224);
            btnChia.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnChia.Location = new Point(586, 185);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(80, 80);
            btnChia.TabIndex = 5;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = false;
            btnChia.Click += btnChia_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbResult.Location = new Point(87, 345);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(79, 25);
            lbResult.TabIndex = 9;
            lbResult.Text = "Result:";
            // 
            // lbKetQua
            // 
            lbKetQua.BackColor = Color.FromArgb(255, 255, 192);
            lbKetQua.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbKetQua.Location = new Point(236, 336);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(290, 42);
            lbKetQua.TabIndex = 10;
            lbKetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(586, 336);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(98, 42);
            btnDong.TabIndex = 6;
            btnDong.Text = "Close";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnDong);
            Controls.Add(lbKetQua);
            Controls.Add(lbResult);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(lbNumber2);
            Controls.Add(LbCal);
            Controls.Add(lbNumber1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumber1;
        private Label LbCal;
        private Label lbNumber2;
        private TextBox txtBox1;
        private TextBox txtBox2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Label lbResult;
        private Label lbKetQua;
        private Button btnDong;
    }
}