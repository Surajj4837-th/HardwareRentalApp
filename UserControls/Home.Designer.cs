namespace HardwareRentalApp.UserControls
{
    partial class Home
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
            btn_AccountApprovalRequest = new Button();
            SuspendLayout();
            // 
            // btn_AccountApprovalRequest
            // 
            btn_AccountApprovalRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_AccountApprovalRequest.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AccountApprovalRequest.Location = new Point(131, 765);
            btn_AccountApprovalRequest.Name = "btn_AccountApprovalRequest";
            btn_AccountApprovalRequest.Size = new Size(309, 42);
            btn_AccountApprovalRequest.TabIndex = 0;
            btn_AccountApprovalRequest.Text = "Account Approval Requests";
            btn_AccountApprovalRequest.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_AccountApprovalRequest);
            Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Home";
            Size = new Size(1600, 900);
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_AccountApprovalRequest;
    }
}
