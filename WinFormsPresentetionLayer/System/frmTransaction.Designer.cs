namespace WinForms_SystemLayer
{
    partial class frmTransaction
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
            label6 = new Label();
            btnSend = new Button();
            txtRecieverID = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            SuspendLayout();
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(32, 28);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(291, 75);
            ctrlCurrentTime1.TabIndex = 0;
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1542, 23);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(216, 162);
            ctrlBtnClose1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(663, 150);
            label6.Name = "label6";
            label6.Size = new Size(201, 35);
            label6.TabIndex = 19;
            label6.Text = "Account id:";
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.HotTrack;
            btnSend.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(818, 502);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(199, 54);
            btnSend.TabIndex = 30;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtRecieverID
            // 
            txtRecieverID.BackColor = SystemColors.HotTrack;
            txtRecieverID.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRecieverID.Location = new Point(927, 140);
            txtRecieverID.Name = "txtRecieverID";
            txtRecieverID.Size = new Size(125, 45);
            txtRecieverID.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(663, 230);
            label3.Name = "label3";
            label3.Size = new Size(148, 35);
            label3.TabIndex = 32;
            label3.Text = "AMount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(663, 333);
            label1.Name = "label1";
            label1.Size = new Size(221, 35);
            label1.TabIndex = 33;
            label1.Text = "Description:";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.HotTrack;
            txtAmount.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(927, 224);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 45);
            txtAmount.TabIndex = 34;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.HotTrack;
            txtDescription.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(927, 323);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(469, 45);
            txtDescription.TabIndex = 35;
            // 
            // frmTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1781, 737);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtRecieverID);
            Controls.Add(btnSend);
            Controls.Add(label6);
            Controls.Add(ctrlBtnClose1);
            Controls.Add(ctrlCurrentTime1);
            Name = "frmTransaction";
            Text = "Transaction";
            Load += frmTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private clsUtil.ctrlCurrentTime ctrlCurrentTime1;
        private clsUtil.ctrlBtnClose ctrlBtnClose1;
        private Label label6;
        private Button btnSend;
        private TextBox txtRecieverID;
        private Label label3;
        private Label label1;
        private TextBox txtAmount;
        private TextBox txtDescription;
    }
}