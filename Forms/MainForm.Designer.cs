namespace HardwareRentalApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_navigation = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pnl_navigation.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_navigation
            // 
            pnl_navigation.BackColor = SystemColors.GradientActiveCaption;
            pnl_navigation.Controls.Add(button5);
            pnl_navigation.Controls.Add(button4);
            pnl_navigation.Controls.Add(button3);
            pnl_navigation.Controls.Add(button2);
            pnl_navigation.Controls.Add(button1);
            pnl_navigation.Location = new Point(0, 0);
            pnl_navigation.Margin = new Padding(1);
            pnl_navigation.Name = "pnl_navigation";
            pnl_navigation.Size = new Size(200, 768);
            pnl_navigation.TabIndex = 0;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Bottom;
            button5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            button5.Location = new Point(0, 724);
            button5.Name = "button5";
            button5.Size = new Size(200, 44);
            button5.TabIndex = 5;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            button4.Location = new Point(0, 132);
            button4.Name = "button4";
            button4.Size = new Size(200, 44);
            button4.TabIndex = 4;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            button3.Location = new Point(0, 88);
            button3.Name = "button3";
            button3.Size = new Size(200, 44);
            button3.TabIndex = 3;
            button3.Text = "Customer";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            button2.Location = new Point(0, 44);
            button2.Name = "button2";
            button2.Size = new Size(200, 44);
            button2.TabIndex = 2;
            button2.Text = "Inventory";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 44);
            button1.TabIndex = 1;
            button1.Text = "Sale";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 768);
            Controls.Add(pnl_navigation);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "Hardware Rental App";
            pnl_navigation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_navigation;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
