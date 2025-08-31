namespace WinForms_SystemLayer.clsUtil
{
    partial class ctrlCurrentTime
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCurrentTime = new TextBox();
            SuspendLayout();
            // 
            // txtCurrentTime
            // 
            txtCurrentTime.BackColor = SystemColors.HotTrack;
            txtCurrentTime.BorderStyle = BorderStyle.None;
            txtCurrentTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCurrentTime.Location = new Point(14, 19);
            txtCurrentTime.Name = "txtCurrentTime";
            txtCurrentTime.Size = new Size(253, 27);
            txtCurrentTime.TabIndex = 6;
            txtCurrentTime.TextChanged += txtCurrentTime_TextChanged;
            // 
            // ctrlCurrentTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            Controls.Add(txtCurrentTime);
            Name = "ctrlCurrentTime";
            Size = new Size(287, 45);
            Load += ctrlCurrentTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCurrentTime;
    }
}
