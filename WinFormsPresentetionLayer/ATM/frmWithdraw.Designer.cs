namespace WinForms_SystemLayer.ATM
{
    partial class frmWithdraw
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
            btnWithdraw = new Button();
            label = new Label();
            txtAmount = new TextBox();
            SuspendLayout();
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1503, 29);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(225, 134);
            ctrlBtnClose1.TabIndex = 0;
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(37, 40);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(269, 56);
            ctrlCurrentTime1.TabIndex = 1;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = SystemColors.HotTrack;
            btnWithdraw.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdraw.Location = new Point(689, 393);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(299, 80);
            btnWithdraw.TabIndex = 4;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(618, 209);
            label.Name = "label";
            label.Size = new Size(158, 37);
            label.TabIndex = 6;
            label.Text = "AMount:";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.HotTrack;
            txtAmount.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(801, 206);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(208, 45);
            txtAmount.TabIndex = 7;
            // 
            // frmWithdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1759, 743);
            Controls.Add(txtAmount);
            Controls.Add(label);
            Controls.Add(btnWithdraw);
            Controls.Add(ctrlCurrentTime1);
            Controls.Add(ctrlBtnClose1);
            Name = "frmWithdraw";
            Text = "Withdraw";
            Load += frmWithdraw_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private clsUtil.ctrlBtnClose ctrlBtnClose1;
        private clsUtil.ctrlCurrentTime ctrlCurrentTime1;
        private Button btnWithdraw;
        private Label label;
        private TextBox txtAmount;
    }
}