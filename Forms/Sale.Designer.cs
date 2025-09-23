namespace HardwareRentalApp.Forms
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            btn_Close = new Button();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Nirmala UI", 8.25F);
            btn_Close.Image = (Image)resources.GetObject("btn_Close.Image");
            btn_Close.ImeMode = ImeMode.NoControl;
            btn_Close.Location = new Point(986, 2);
            btn_Close.Margin = new Padding(1);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(33, 33);
            btn_Close.TabIndex = 3;
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 1066);
            ControlBox = false;
            Controls.Add(btn_Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sale";
            Text = "Sale";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Close;
    }
}