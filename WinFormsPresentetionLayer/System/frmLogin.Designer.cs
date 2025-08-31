namespace WinFormsPresentetionLayer
{
    partial class frmLogin
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
            label1 = new Label();
            btnLogin = new Button();
            txtEmailBox = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnSignin = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ctrlBtnClose1 = new WinForms_SystemLayer.clsUtil.ctrlBtnClose();
            ctrlCurrentTime1 = new WinForms_SystemLayer.clsUtil.ctrlCurrentTime();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(653, 98);
            label1.Name = "label1";
            label1.Size = new Size(113, 35);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(917, 317);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(185, 54);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmailBox
            // 
            txtEmailBox.BackColor = SystemColors.HotTrack;
            txtEmailBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmailBox.Location = new Point(849, 100);
            txtEmailBox.Name = "txtEmailBox";
            txtEmailBox.Size = new Size(253, 34);
            txtEmailBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(653, 208);
            label2.Name = "label2";
            label2.Size = new Size(188, 35);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.HotTrack;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(849, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(253, 34);
            txtPassword.TabIndex = 5;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = SystemColors.HotTrack;
            btnSignin.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignin.Location = new Point(653, 317);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(188, 54);
            btnSignin.TabIndex = 6;
            btnSignin.Text = "Sign In";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1630, 12);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(274, 162);
            ctrlBtnClose1.TabIndex = 7;
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(33, 26);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(359, 56);
            ctrlCurrentTime1.TabIndex = 8;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1805, 703);
            Controls.Add(ctrlCurrentTime1);
            Controls.Add(ctrlBtnClose1);
            Controls.Add(btnSignin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtEmailBox);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private TextBox txtEmailBox;
        private Label label2;
        private TextBox txtPassword;
        private Button btnSignin;
        private FolderBrowserDialog folderBrowserDialog1;
        private WinForms_SystemLayer.clsUtil.ctrlBtnClose ctrlBtnClose1;
        private WinForms_SystemLayer.clsUtil.ctrlCurrentTime ctrlCurrentTime1;
    }
}