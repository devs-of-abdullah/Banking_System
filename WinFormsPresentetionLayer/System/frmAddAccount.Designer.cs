namespace WinForms_SystemLayer
{
    partial class frmAddAccount
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
            ctrlBtnClose1 = new WinForms_SystemLayer.clsUtil.ctrlBtnClose();
            ctrlCurrentTime1 = new WinForms_SystemLayer.clsUtil.ctrlCurrentTime();
            txtfullname = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            txtEmail = new TextBox();
            txtPin = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1555, 31);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(218, 162);
            ctrlBtnClose1.TabIndex = 0;
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(62, 31);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(359, 56);
            ctrlCurrentTime1.TabIndex = 1;
            // 
            // txtfullname
            // 
            txtfullname.BackColor = SystemColors.HotTrack;
            txtfullname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtfullname.Location = new Point(746, 123);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(253, 34);
            txtfullname.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(536, 121);
            label1.Name = "label1";
            label1.Size = new Size(174, 35);
            label1.TabIndex = 5;
            label1.Text = "fullname:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(666, 465);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 54);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.HotTrack;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(746, 197);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 34);
            txtEmail.TabIndex = 8;
            // 
            // txtPin
            // 
            txtPin.BackColor = SystemColors.HotTrack;
            txtPin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPin.Location = new Point(746, 279);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(253, 34);
            txtPin.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.HotTrack;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(746, 347);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(253, 34);
            txtPassword.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(536, 197);
            label2.Name = "label2";
            label2.Size = new Size(113, 35);
            label2.TabIndex = 11;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(536, 279);
            label3.Name = "label3";
            label3.Size = new Size(78, 35);
            label3.TabIndex = 12;
            label3.Text = "PIN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(536, 347);
            label4.Name = "label4";
            label4.Size = new Size(188, 35);
            label4.TabIndex = 13;
            label4.Text = "Password:";
            // 
            // frmAddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1785, 686);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtPin);
            Controls.Add(txtEmail);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtfullname);
            Controls.Add(ctrlCurrentTime1);
            Controls.Add(ctrlBtnClose1);
            Name = "frmAddAccount";
            Text = "Sign Up";
            Load += frmAddAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private clsUtil.ctrlBtnClose ctrlBtnClose1;
        private clsUtil.ctrlCurrentTime ctrlCurrentTime1;
        private TextBox txtfullname;
        private Label label1;
        private Button btnAdd;
        private TextBox txtEmail;
        private TextBox txtPin;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}