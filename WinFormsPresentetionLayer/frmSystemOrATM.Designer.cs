namespace WinForms_SystemLayer
{
    partial class frmSystemOrATM
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
            btnSystem = new Button();
            btnAtm = new Button();
            txtBankName = new TextBox();
            ctrlBtnClose1 = new WinForms_SystemLayer.clsUtil.ctrlBtnClose();
            ctrlCurrentTime1 = new WinForms_SystemLayer.clsUtil.ctrlCurrentTime();
            label11 = new Label();
            lblAllBalanceAtSystem = new Label();
            SuspendLayout();
            // 
            // btnSystem
            // 
            btnSystem.BackColor = SystemColors.HotTrack;
            btnSystem.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSystem.Location = new Point(461, 255);
            btnSystem.Name = "btnSystem";
            btnSystem.Size = new Size(501, 172);
            btnSystem.TabIndex = 7;
            btnSystem.Text = "System";
            btnSystem.UseVisualStyleBackColor = false;
            btnSystem.Click += btnSystem_Click;
            // 
            // btnAtm
            // 
            btnAtm.BackColor = SystemColors.HotTrack;
            btnAtm.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtm.Location = new Point(1090, 255);
            btnAtm.Name = "btnAtm";
            btnAtm.Size = new Size(501, 172);
            btnAtm.TabIndex = 9;
            btnAtm.Text = "ATM";
            btnAtm.UseVisualStyleBackColor = false;
            btnAtm.Click += btnAtm_Click;
            // 
            // txtBankName
            // 
            txtBankName.BackColor = SystemColors.HotTrack;
            txtBankName.BorderStyle = BorderStyle.None;
            txtBankName.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBankName.Location = new Point(725, 78);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(559, 107);
            txtBankName.TabIndex = 11;
            txtBankName.Text = "Abdullah Bank";
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1652, 23);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(274, 162);
            ctrlBtnClose1.TabIndex = 12;
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(39, 34);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(359, 56);
            ctrlCurrentTime1.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 678);
            label11.Name = "label11";
            label11.Size = new Size(369, 35);
            label11.TabIndex = 20;
            label11.Text = "All Balance At system:";
            // 
            // lblAllBalanceAtSystem
            // 
            lblAllBalanceAtSystem.AutoSize = true;
            lblAllBalanceAtSystem.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAllBalanceAtSystem.Location = new Point(404, 678);
            lblAllBalanceAtSystem.Name = "lblAllBalanceAtSystem";
            lblAllBalanceAtSystem.Size = new Size(103, 35);
            lblAllBalanceAtSystem.TabIndex = 21;
            lblAllBalanceAtSystem.Text = "xxxx";
            // 
            // frmSystemOrATM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1833, 731);
            Controls.Add(lblAllBalanceAtSystem);
            Controls.Add(label11);
            Controls.Add(ctrlCurrentTime1);
            Controls.Add(ctrlBtnClose1);
            Controls.Add(txtBankName);
            Controls.Add(btnAtm);
            Controls.Add(btnSystem);
            Name = "frmSystemOrATM";
            Text = "System Or ATM";
            Load += frmSystemOrATM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSystem;
        private Button btnAtm;
        private TextBox txtBankName;
        private clsUtil.ctrlBtnClose ctrlBtnClose1;
        private clsUtil.ctrlCurrentTime ctrlCurrentTime1;
        private Label label11;
        private Label lblAllBalanceAtSystem;
    }
}