
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.Calculator = new System.Windows.Forms.Label();
            this.cbbDepTrai = new System.Windows.Forms.ComboBox();
            this.lblDepTrai = new System.Windows.Forms.Label();
            this.btnMoForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(436, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTen.Location = new System.Drawing.Point(204, 38);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(186, 34);
            this.txtTen.TabIndex = 3;
            this.txtTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btExit.Location = new System.Drawing.Point(548, 28);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(80, 58);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(445, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(35, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập Họ Và Tên";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(445, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhập số 2";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(537, 200);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(91, 25);
            this.txtSo1.TabIndex = 9;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(537, 273);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(91, 25);
            this.txtSo2.TabIndex = 10;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCong.Location = new System.Drawing.Point(445, 320);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(57, 51);
            this.btCong.TabIndex = 11;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTru.Location = new System.Drawing.Point(445, 377);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(57, 54);
            this.btTru.TabIndex = 12;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // btNhan
            // 
            this.btNhan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNhan.Location = new System.Drawing.Point(508, 320);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(61, 51);
            this.btNhan.TabIndex = 13;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btChia
            // 
            this.btChia.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btChia.Location = new System.Drawing.Point(508, 377);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(61, 54);
            this.btChia.TabIndex = 14;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.BackColor = System.Drawing.Color.Transparent;
            this.lblKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKetQua.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKetQua.Location = new System.Drawing.Point(684, 248);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 28);
            this.lblKetQua.TabIndex = 15;
            // 
            // Calculator
            // 
            this.Calculator.AutoSize = true;
            this.Calculator.BackColor = System.Drawing.Color.Transparent;
            this.Calculator.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.ForeColor = System.Drawing.Color.White;
            this.Calculator.Location = new System.Drawing.Point(739, 164);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(109, 30);
            this.Calculator.TabIndex = 16;
            this.Calculator.Text = "Calculator";
            // 
            // cbbDepTrai
            // 
            this.cbbDepTrai.FormattingEnabled = true;
            this.cbbDepTrai.Items.AddRange(new object[] {
            "Không",
            "Đéo",
            "Đẹp thua Trần Hữu Toàn",
            "Cón\'t",
            "No",
            "Yesn\'t",
            "Tôi nghĩ là không",
            "Sure đéo",
            "Dảk",
            "Chắc chắn là không",
            "Nếu đẹp trai là cái tội thì tôi vô tội",
            "Đẹp ở mức tạm chấp nhận"});
            this.cbbDepTrai.Location = new System.Drawing.Point(35, 200);
            this.cbbDepTrai.Name = "cbbDepTrai";
            this.cbbDepTrai.Size = new System.Drawing.Size(204, 25);
            this.cbbDepTrai.TabIndex = 17;
            this.cbbDepTrai.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDepTrai
            // 
            this.lblDepTrai.AutoSize = true;
            this.lblDepTrai.BackColor = System.Drawing.Color.Transparent;
            this.lblDepTrai.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepTrai.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDepTrai.Location = new System.Drawing.Point(35, 169);
            this.lblDepTrai.Name = "lblDepTrai";
            this.lblDepTrai.Size = new System.Drawing.Size(0, 28);
            this.lblDepTrai.TabIndex = 18;
            this.lblDepTrai.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnMoForm
            // 
            this.btnMoForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMoForm.Location = new System.Drawing.Point(661, 29);
            this.btnMoForm.Name = "btnMoForm";
            this.btnMoForm.Size = new System.Drawing.Size(81, 58);
            this.btnMoForm.TabIndex = 19;
            this.btnMoForm.Text = "Don\'t Click";
            this.btnMoForm.UseVisualStyleBackColor = false;
            this.btnMoForm.Click += new System.EventHandler(this.btnMoForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(436, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bạn không biết 1 + 1 = ? Hãy thử với";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 495);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMoForm);
            this.Controls.Add(this.lblDepTrai);
            this.Controls.Add(this.cbbDepTrai);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trần Hữu Toàn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label Calculator;
        private System.Windows.Forms.ComboBox cbbDepTrai;
        private System.Windows.Forms.Label lblDepTrai;
        private System.Windows.Forms.Button btnMoForm;
        private System.Windows.Forms.Label label4;
    }
}

