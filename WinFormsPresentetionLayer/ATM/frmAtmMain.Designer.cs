namespace WinForms_SystemLayer.ATM
{
    partial class frmAtmMain
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
            ctrlpin1 = new ctrlPIN();
            ctrlCurrentTime1 = new WinForms_SystemLayer.clsUtil.ctrlCurrentTime();
            ctrlBtnClose1 = new WinForms_SystemLayer.clsUtil.ctrlBtnClose();
            label1 = new Label();
            label2 = new Label();
            lblPin = new Label();
            txtID = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // ctrlpin1
            // 
            ctrlpin1.BackColor = SystemColors.HotTrack;
            ctrlpin1.Location = new Point(1026, 173);
            ctrlpin1.Name = "ctrlpin1";
            ctrlpin1.Size = new Size(387, 474);
            ctrlpin1.TabIndex = 0;
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(38, 27);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(304, 56);
            ctrlCurrentTime1.TabIndex = 1;
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1551, 27);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(222, 130);
            ctrlBtnClose1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(531, 249);
            label1.Name = "label1";
            label1.Size = new Size(96, 59);
            label1.TabIndex = 3;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(520, 370);
            label2.Name = "label2";
            label2.Size = new Size(125, 59);
            label2.TabIndex = 4;
            label2.Text = "PIN:";
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPin.Location = new Point(670, 370);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(169, 59);
            lblPin.TabIndex = 5;
            lblPin.Text = "xxxx";
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.HotTrack;
            txtID.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.Location = new Point(670, 253);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 57);
            txtID.TabIndex = 6;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = SystemColors.HotTrack;
            btnEnter.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(591, 530);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(204, 70);
            btnEnter.TabIndex = 7;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // frmAtmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1774, 716);
            Controls.Add(btnEnter);
            Controls.Add(txtID);
            Controls.Add(lblPin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ctrlBtnClose1);
            Controls.Add(ctrlCurrentTime1);
            Controls.Add(ctrlpin1);
            Name = "frmAtmMain";
            Text = "frmAtmMain";
            Load += frmAtmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlPIN ctrlpin1;
        private clsUtil.ctrlCurrentTime ctrlCurrentTime1;
        private clsUtil.ctrlBtnClose ctrlBtnClose1;
        private Label label1;
        private Label label2;
        private Label lblPin;
        private TextBox txtID;
        private Button btnEnter;
    }
}