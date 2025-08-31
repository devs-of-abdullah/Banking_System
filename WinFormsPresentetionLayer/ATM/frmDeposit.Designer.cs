namespace WinForms_SystemLayer
{
    partial class frmDeposit
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
            txtAmount = new TextBox();
            label = new Label();
            btnDeposit = new Button();
            SuspendLayout();
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(12, 12);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(248, 56);
            ctrlCurrentTime1.TabIndex = 0;
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1558, 12);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(209, 162);
            ctrlBtnClose1.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.HotTrack;
            txtAmount.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(748, 253);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(208, 45);
            txtAmount.TabIndex = 8;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(558, 256);
            label.Name = "label";
            label.Size = new Size(158, 37);
            label.TabIndex = 9;
            label.Text = "AMount:";
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = SystemColors.HotTrack;
            btnDeposit.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.Location = new Point(639, 423);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(299, 80);
            btnDeposit.TabIndex = 10;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // frmDeposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1779, 751);
            Controls.Add(btnDeposit);
            Controls.Add(label);
            Controls.Add(txtAmount);
            Controls.Add(ctrlBtnClose1);
            Controls.Add(ctrlCurrentTime1);
            Name = "frmDeposit";
            Text = "frmDeposit";
            Load += frmDeposit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private clsUtil.ctrlCurrentTime ctrlCurrentTime1;
        private clsUtil.ctrlBtnClose ctrlBtnClose1;
        private TextBox txtAmount;
        private Label label;
        private Button btnDeposit;
    }
}