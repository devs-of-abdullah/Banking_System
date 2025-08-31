namespace WinForms_SystemLayer
{
    partial class frmAllTransactions
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            ctrlBtnClose1 = new WinForms_SystemLayer.clsUtil.ctrlBtnClose();
            ctrlCurrentTime1 = new WinForms_SystemLayer.clsUtil.ctrlCurrentTime();
            dgvSent = new DataGridView();
            label8 = new Label();
            label1 = new Label();
            dgvRecieved = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecieved).BeginInit();
            SuspendLayout();
            // 
            // ctrlBtnClose1
            // 
            ctrlBtnClose1.BackColor = SystemColors.HotTrack;
            ctrlBtnClose1.Location = new Point(1547, 24);
            ctrlBtnClose1.Name = "ctrlBtnClose1";
            ctrlBtnClose1.Size = new Size(215, 162);
            ctrlBtnClose1.TabIndex = 0;
            // 
            // ctrlCurrentTime1
            // 
            ctrlCurrentTime1.BackColor = SystemColors.HotTrack;
            ctrlCurrentTime1.Location = new Point(53, 38);
            ctrlCurrentTime1.Name = "ctrlCurrentTime1";
            ctrlCurrentTime1.Size = new Size(359, 56);
            ctrlCurrentTime1.TabIndex = 1;
            // 
            // dgvSent
            // 
            dgvSent.AllowUserToAddRows = false;
            dgvSent.AllowUserToDeleteRows = false;
            dgvSent.AllowUserToResizeColumns = false;
            dgvSent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvSent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSent.BackgroundColor = SystemColors.HotTrack;
            dgvSent.BorderStyle = BorderStyle.None;
            dgvSent.ColumnHeadersHeight = 30;
            dgvSent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSent.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSent.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSent.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSent.EnableHeadersVisualStyles = false;
            dgvSent.GridColor = SystemColors.HotTrack;
            dgvSent.Location = new Point(1045, 183);
            dgvSent.MinimumSize = new Size(100, 30);
            dgvSent.Name = "dgvSent";
            dgvSent.ReadOnly = true;
            dgvSent.RowHeadersVisible = false;
            dgvSent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvSent.Size = new Size(416, 593);
            dgvSent.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1207, 106);
            label8.Name = "label8";
            label8.Size = new Size(85, 35);
            label8.TabIndex = 14;
            label8.Text = "Sent";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(421, 106);
            label1.Name = "label1";
            label1.Size = new Size(158, 35);
            label1.TabIndex = 15;
            label1.Text = "Recieved";
            // 
            // dgvRecieved
            // 
            dgvRecieved.AllowUserToAddRows = false;
            dgvRecieved.AllowUserToDeleteRows = false;
            dgvRecieved.AllowUserToResizeColumns = false;
            dgvRecieved.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvRecieved.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvRecieved.BackgroundColor = SystemColors.HotTrack;
            dgvRecieved.BorderStyle = BorderStyle.None;
            dgvRecieved.ColumnHeadersHeight = 30;
            dgvRecieved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecieved.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRecieved.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRecieved.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvRecieved.EnableHeadersVisualStyles = false;
            dgvRecieved.GridColor = SystemColors.HotTrack;
            dgvRecieved.Location = new Point(291, 183);
            dgvRecieved.MinimumSize = new Size(100, 30);
            dgvRecieved.Name = "dgvRecieved";
            dgvRecieved.ReadOnly = true;
            dgvRecieved.RowHeadersVisible = false;
            dgvRecieved.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvRecieved.Size = new Size(416, 593);
            dgvRecieved.TabIndex = 16;
            // 
            // frmAllTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1774, 781);
            Controls.Add(dgvRecieved);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(dgvSent);
            Controls.Add(ctrlCurrentTime1);
            Controls.Add(ctrlBtnClose1);
            Name = "frmAllTransactions";
            Text = "frmAllTransactions";
            Load += frmAllTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecieved).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private clsUtil.ctrlBtnClose ctrlBtnClose1;
        private clsUtil.ctrlCurrentTime ctrlCurrentTime1;
        private DataGridView dgvSent;
        private Label label8;
        private Label label1;
        private DataGridView dgvRecieved;
    }
}