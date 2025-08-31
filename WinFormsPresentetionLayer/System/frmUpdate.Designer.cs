namespace WinForms_SystemLayer
{
    partial class frmUpdate
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
            ctrlCurrentTime1 = new WinForms_SystemLayer.clsUtil.ctrlCurrentTime();
            ctrlBtnClose1 = new WinForms_SystemLayer.clsUtil.ctrlBtnClose();
            txtOldPin = new TextBox();
            txtOldPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnChangePin = new Button();
            txtNewPin = new TextBox();
            txtNewPassword = new TextBox();
            btnChangePassword = new Button();
            label3 = new Label();
            label4 = new Label();
            txtNewFullname = new TextBox();
            txtNewEmail = new TextBox();
            btnChangeFullname = new Button();
            btnChangeEmail = new Button();
            labe11 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(49, 34);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(359, 56);
            ctrlCurrentTime1.TabIndex = 0;
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1626, 33);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(212, 162);
            ctrlBtnClose1.TabIndex = 1;
            // 
            // txtOldPin
            // 
            txtOldPin.BackColor = SystemColors.HotTrack;
            txtOldPin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOldPin.Location = new Point(264, 208);
            txtOldPin.Name = "txtOldPin";
            txtOldPin.Size = new Size(253, 34);
            txtOldPin.TabIndex = 5;
            // 
            // txtOldPassword
            // 
            txtOldPassword.BackColor = SystemColors.HotTrack;
            txtOldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOldPassword.Location = new Point(264, 333);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(253, 34);
            txtOldPassword.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 199);
            label1.Name = "label1";
            label1.Size = new Size(78, 35);
            label1.TabIndex = 7;
            label1.Text = "pin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 332);
            label2.Name = "label2";
            label2.Size = new Size(188, 35);
            label2.TabIndex = 8;
            label2.Text = "password:";
            // 
            // btnChangePin
            // 
            btnChangePin.BackColor = SystemColors.HotTrack;
            btnChangePin.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePin.Location = new Point(988, 195);
            btnChangePin.Name = "btnChangePin";
            btnChangePin.Size = new Size(223, 54);
            btnChangePin.TabIndex = 9;
            btnChangePin.Text = "change pin";
            btnChangePin.UseVisualStyleBackColor = false;
            btnChangePin.Click += btnChangePin_Click;
            // 
            // txtNewPin
            // 
            txtNewPin.BackColor = SystemColors.HotTrack;
            txtNewPin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewPin.Location = new Point(560, 208);
            txtNewPin.Name = "txtNewPin";
            txtNewPin.Size = new Size(253, 34);
            txtNewPin.TabIndex = 10;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = SystemColors.HotTrack;
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(560, 332);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(253, 34);
            txtNewPassword.TabIndex = 11;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = SystemColors.HotTrack;
            btnChangePassword.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.Location = new Point(940, 319);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(349, 54);
            btnChangePassword.TabIndex = 12;
            btnChangePassword.Text = "change password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(343, 109);
            label3.Name = "label3";
            label3.Size = new Size(74, 35);
            label3.TabIndex = 13;
            label3.Text = "OLD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(629, 109);
            label4.Name = "label4";
            label4.Size = new Size(83, 35);
            label4.TabIndex = 14;
            label4.Text = "new";
            // 
            // txtNewFullname
            // 
            txtNewFullname.BackColor = SystemColors.HotTrack;
            txtNewFullname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewFullname.Location = new Point(560, 453);
            txtNewFullname.Name = "txtNewFullname";
            txtNewFullname.Size = new Size(253, 34);
            txtNewFullname.TabIndex = 15;
            // 
            // txtNewEmail
            // 
            txtNewEmail.BackColor = SystemColors.HotTrack;
            txtNewEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewEmail.Location = new Point(560, 559);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.Size = new Size(253, 34);
            txtNewEmail.TabIndex = 16;
            // 
            // btnChangeFullname
            // 
            btnChangeFullname.BackColor = SystemColors.HotTrack;
            btnChangeFullname.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeFullname.Location = new Point(940, 440);
            btnChangeFullname.Name = "btnChangeFullname";
            btnChangeFullname.Size = new Size(349, 54);
            btnChangeFullname.TabIndex = 17;
            btnChangeFullname.Text = "change fullname";
            btnChangeFullname.UseVisualStyleBackColor = false;
            btnChangeFullname.Click += btnChangeFullname_Click;
            // 
            // btnChangeEmail
            // 
            btnChangeEmail.BackColor = SystemColors.HotTrack;
            btnChangeEmail.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeEmail.Location = new Point(940, 539);
            btnChangeEmail.Name = "btnChangeEmail";
            btnChangeEmail.Size = new Size(349, 54);
            btnChangeEmail.TabIndex = 18;
            btnChangeEmail.Text = "change Email";
            btnChangeEmail.UseVisualStyleBackColor = false;
            btnChangeEmail.Click += btnChangeEmail_Click;
            // 
            // labe11
            // 
            labe11.AutoSize = true;
            labe11.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labe11.Location = new Point(300, 453);
            labe11.Name = "labe11";
            labe11.Size = new Size(174, 35);
            labe11.TabIndex = 19;
            labe11.Text = "Fullname:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(300, 558);
            label6.Name = "label6";
            label6.Size = new Size(113, 35);
            label6.TabIndex = 20;
            label6.Text = "Email:";
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1831, 689);
            Controls.Add(label6);
            Controls.Add(labe11);
            Controls.Add(btnChangeEmail);
            Controls.Add(btnChangeFullname);
            Controls.Add(txtNewEmail);
            Controls.Add(txtNewFullname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnChangePassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewPin);
            Controls.Add(btnChangePin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOldPassword);
            Controls.Add(txtOldPin);
            Controls.Add(ctrlBtnClose1);
            Controls.Add(ctrlCurrentTime1);
            Name = "frmUpdate";
            Text = "Update Account";
            Load += frmUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private clsUtil.ctrlCurrentTime ctrlCurrentTime1;
        private clsUtil.ctrlBtnClose ctrlBtnClose1;
        private TextBox txtOldPin;
        private TextBox txtOldPassword;
        private Label label1;
        private Label label2;
        private Button btnChangePin;
        private TextBox txtNewPin;
        private TextBox txtNewPassword;
        private Button btnChangePassword;
        private Label label3;
        private Label label4;
        private TextBox txtNewFullname;
        private TextBox txtNewEmail;
        private Button btnChangeFullname;
        private Button btnChangeEmail;
        private Label labe11;
        private Label label6;
    }
}