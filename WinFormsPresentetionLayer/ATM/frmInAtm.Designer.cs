namespace WinForms_SystemLayer
{
    partial class frmInAtm
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
            btnWithdraw = new Button();
            btnDeposit = new Button();
            label = new Label();
            lblID = new Label();
            label1 = new Label();
            lblName = new Label();
            label2 = new Label();
            lblBalance = new Label();
            label3 = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(60, 38);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(359, 56);
            ctrlCurrentTime1.TabIndex = 0;
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1519, 26);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(217, 162);
            ctrlBtnClose1.TabIndex = 1;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = SystemColors.HotTrack;
            btnWithdraw.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdraw.Location = new Point(950, 303);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(299, 80);
            btnWithdraw.TabIndex = 2;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = SystemColors.HotTrack;
            btnDeposit.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.Location = new Point(950, 173);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(299, 80);
            btnDeposit.TabIndex = 3;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(60, 151);
            label.Name = "label";
            label.Size = new Size(64, 37);
            label.TabIndex = 5;
            label.Text = "ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(130, 151);
            lblID.Name = "lblID";
            lblID.Size = new Size(109, 37);
            lblID.TabIndex = 6;
            lblID.Text = "xxxx";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 216);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 7;
            label1.Text = "Full Name:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(264, 216);
            lblName.Name = "lblName";
            lblName.Size = new Size(155, 37);
            lblName.TabIndex = 8;
            lblName.Text = "xxxxxx";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 355);
            label2.Name = "label2";
            label2.Size = new Size(162, 37);
            label2.TabIndex = 9;
            label2.Text = "Balance:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(239, 355);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(132, 37);
            lblBalance.TabIndex = 10;
            lblBalance.Text = "xxxxx";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 276);
            label3.Name = "label3";
            label3.Size = new Size(121, 37);
            label3.TabIndex = 11;
            label3.Text = "Email:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(187, 276);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(385, 37);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "xxxxxxxxxxxxxxxx";
            // 
            // frmInAtm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1748, 754);
            Controls.Add(lblEmail);
            Controls.Add(label3);
            Controls.Add(lblBalance);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(lblID);
            Controls.Add(label);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(ctrlBtnClose1);
            Controls.Add(ctrlCurrentTime1);
            Name = "frmInAtm";
            Text = "in ATM";
            Load += frmPerformWithdrawOrDeposit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private clsUtil.ctrlCurrentTime ctrlCurrentTime1;
        private clsUtil.ctrlBtnClose ctrlBtnClose1;
        private Button btnWithdraw;
        private Button btnDeposit;
        private Label label;
        private Label lblID;
        private Label label1;
        private Label lblName;
        private Label label2;
        private Label lblBalance;
        private Label label3;
        private Label lblEmail;
    }
}