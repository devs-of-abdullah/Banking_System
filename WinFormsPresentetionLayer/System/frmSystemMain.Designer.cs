namespace WinFormsPresentetionLayer
{
    partial class frmSystemMain
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
            lblCreatedAt = new Label();
            lblBalance = new Label();
            lblEmail = new Label();
            lblfullname = new Label();
            lblAccountID = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnDeleteAccount = new Button();
            btnUpdateAccount = new Button();
            btnAllWithdrawsDeposits = new Button();
            AllTransactions = new Button();
            btnTransaction = new Button();
            SuspendLayout();
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1547, 21);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(216, 162);
            ctrlBtnClose1.TabIndex = 7;
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(28, 21);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(270, 56);
            ctrlCurrentTime1.TabIndex = 8;
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedAt.Location = new Point(376, 465);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(103, 35);
            lblCreatedAt.TabIndex = 23;
            lblCreatedAt.Text = "xxxx";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(347, 403);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(103, 35);
            lblBalance.TabIndex = 22;
            lblBalance.Text = "xxxx";
            lblBalance.Click += lblBalance_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(347, 328);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 35);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "xxxx";
            // 
            // lblfullname
            // 
            lblfullname.AutoSize = true;
            lblfullname.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfullname.Location = new Point(347, 260);
            lblfullname.Name = "lblfullname";
            lblfullname.Size = new Size(103, 35);
            lblfullname.TabIndex = 20;
            lblfullname.Text = "xxxx";
            // 
            // lblAccountID
            // 
            lblAccountID.AutoSize = true;
            lblAccountID.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountID.Location = new Point(357, 191);
            lblAccountID.Name = "lblAccountID";
            lblAccountID.Size = new Size(103, 35);
            lblAccountID.TabIndex = 19;
            lblAccountID.Text = "xxxx";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(134, 191);
            label6.Name = "label6";
            label6.Size = new Size(201, 35);
            label6.TabIndex = 18;
            label6.Text = "Account id:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(134, 465);
            label5.Name = "label5";
            label5.Size = new Size(199, 35);
            label5.TabIndex = 17;
            label5.Text = "Created at:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 403);
            label4.Name = "label4";
            label4.Size = new Size(153, 35);
            label4.TabIndex = 16;
            label4.Text = "Balance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 328);
            label3.Name = "label3";
            label3.Size = new Size(113, 35);
            label3.TabIndex = 15;
            label3.Text = "email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(134, 260);
            label7.Name = "label7";
            label7.Size = new Size(174, 35);
            label7.TabIndex = 14;
            label7.Text = "fullname:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(285, 111);
            label8.Name = "label8";
            label8.Size = new Size(225, 35);
            label8.TabIndex = 13;
            label8.Text = "Account Info";
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = SystemColors.HotTrack;
            btnDeleteAccount.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteAccount.Location = new Point(1378, 619);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(359, 54);
            btnDeleteAccount.TabIndex = 24;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.BackColor = SystemColors.HotTrack;
            btnUpdateAccount.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAccount.Location = new Point(1378, 538);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(359, 54);
            btnUpdateAccount.TabIndex = 25;
            btnUpdateAccount.Text = "Update Account";
            btnUpdateAccount.UseVisualStyleBackColor = false;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // btnAllWithdrawsDeposits
            // 
            btnAllWithdrawsDeposits.BackColor = SystemColors.HotTrack;
            btnAllWithdrawsDeposits.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAllWithdrawsDeposits.Location = new Point(1378, 403);
            btnAllWithdrawsDeposits.Name = "btnAllWithdrawsDeposits";
            btnAllWithdrawsDeposits.Size = new Size(359, 97);
            btnAllWithdrawsDeposits.TabIndex = 27;
            btnAllWithdrawsDeposits.Text = "All Deposits / Withdraws";
            btnAllWithdrawsDeposits.UseVisualStyleBackColor = false;
            btnAllWithdrawsDeposits.Click += btnAllWithdrawsDeposits_Click;
            // 
            // AllTransactions
            // 
            AllTransactions.BackColor = SystemColors.HotTrack;
            AllTransactions.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllTransactions.Location = new Point(1378, 317);
            AllTransactions.Name = "AllTransactions";
            AllTransactions.Size = new Size(359, 54);
            AllTransactions.TabIndex = 28;
            AllTransactions.Text = "All Transactions";
            AllTransactions.UseVisualStyleBackColor = false;
            AllTransactions.Click += AllTransactions_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = SystemColors.HotTrack;
            btnTransaction.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaction.Location = new Point(1378, 241);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(359, 54);
            btnTransaction.TabIndex = 29;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // frmSystemMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1775, 794);
            Controls.Add(btnTransaction);
            Controls.Add(AllTransactions);
            Controls.Add(btnAllWithdrawsDeposits);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnDeleteAccount);
            Controls.Add(lblCreatedAt);
            Controls.Add(lblBalance);
            Controls.Add(lblEmail);
            Controls.Add(lblfullname);
            Controls.Add(lblAccountID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(ctrlCurrentTime1);
            Controls.Add(ctrlBtnClose1);
            Name = "frmSystemMain";
            Text = "frmMain";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private WinForms_SystemLayer.clsUtil.ctrlBtnClose ctrlBtnClose1;
        private WinForms_SystemLayer.clsUtil.ctrlCurrentTime ctrlCurrentTime1;
        private Label lblCreatedAt;
        private Label lblBalance;
        private Label lblEmail;
        private Label lblfullname;
        private Label lblAccountID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label8;
        private Button btnDeleteAccount;
        private Button btnUpdateAccount;
        private Button btnAllWithdrawsDeposits;
        private Button AllTransactions;
        private Button btnTransaction;
    }
}