namespace WinForms_SystemLayer
{
    partial class frmAllDepostsWithdraws
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            ctrlBtnClose1 = new WinForms_SystemLayer.clsUtil.ctrlBtnClose();
            ctrlCurrentTime1 = new WinForms_SystemLayer.clsUtil.ctrlCurrentTime();
            dgvDeposits = new DataGridView();
            dgvWithdraws = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDeposits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWithdraws).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 110);
            label1.Name = "label1";
            label1.Size = new Size(155, 35);
            label1.TabIndex = 16;
            label1.Text = "Deposits";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1103, 110);
            label2.Name = "label2";
            label2.Size = new Size(205, 35);
            label2.TabIndex = 17;
            label2.Text = "Withdraws";
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1564, 24);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(210, 162);
            ctrlBtnClose1.TabIndex = 18;
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(27, 24);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(249, 56);
            ctrlCurrentTime1.TabIndex = 19;
            // 
            // dgvDeposits
            // 
            dgvDeposits.AllowUserToAddRows = false;
            dgvDeposits.AllowUserToDeleteRows = false;
            dgvDeposits.AllowUserToResizeColumns = false;
            dgvDeposits.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvDeposits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDeposits.BackgroundColor = SystemColors.HotTrack;
            dgvDeposits.BorderStyle = BorderStyle.None;
            dgvDeposits.ColumnHeadersHeight = 30;
            dgvDeposits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDeposits.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvDeposits.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDeposits.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDeposits.EnableHeadersVisualStyles = false;
            dgvDeposits.GridColor = SystemColors.HotTrack;
            dgvDeposits.Location = new Point(253, 178);
            dgvDeposits.MinimumSize = new Size(100, 30);
            dgvDeposits.Name = "dgvDeposits";
            dgvDeposits.ReadOnly = true;
            dgvDeposits.RowHeadersVisible = false;
            dgvDeposits.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDeposits.Size = new Size(416, 593);
            dgvDeposits.TabIndex = 20;
            // 
            // dgvWithdraws
            // 
            dgvWithdraws.AllowUserToAddRows = false;
            dgvWithdraws.AllowUserToDeleteRows = false;
            dgvWithdraws.AllowUserToResizeColumns = false;
            dgvWithdraws.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dgvWithdraws.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvWithdraws.BackgroundColor = SystemColors.HotTrack;
            dgvWithdraws.BorderStyle = BorderStyle.None;
            dgvWithdraws.ColumnHeadersHeight = 30;
            dgvWithdraws.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvWithdraws.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle8.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvWithdraws.DefaultCellStyle = dataGridViewCellStyle8;
            dgvWithdraws.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvWithdraws.EnableHeadersVisualStyles = false;
            dgvWithdraws.GridColor = SystemColors.HotTrack;
            dgvWithdraws.Location = new Point(994, 178);
            dgvWithdraws.MinimumSize = new Size(100, 30);
            dgvWithdraws.Name = "dgvWithdraws";
            dgvWithdraws.ReadOnly = true;
            dgvWithdraws.RowHeadersVisible = false;
            dgvWithdraws.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvWithdraws.Size = new Size(416, 593);
            dgvWithdraws.TabIndex = 21;
            // 
            // frmAllDepostsWithdraws
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1786, 726);
            Controls.Add(dgvWithdraws);
            Controls.Add(dgvDeposits);
            Controls.Add(ctrlCurrentTime1);
            Controls.Add(ctrlBtnClose1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAllDepostsWithdraws";
            Text = "frmAllDepostsWithdraws";
            Load += frmAllDepostsWithdraws_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeposits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWithdraws).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private clsUtil.ctrlBtnClose ctrlBtnClose1;
        private clsUtil.ctrlCurrentTime ctrlCurrentTime1;
        private DataGridView dgvDeposits;
        private DataGridView dgvWithdraws;
    }
}