namespace TDD_Proj
{
    partial class MenuForm
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
            components = new System.ComponentModel.Container();
            manualButton = new Button();
            autoButton = new Button();
            label1 = new Label();
            ManualToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // manualButton
            // 
            manualButton.BackColor = Color.Transparent;
            manualButton.BackgroundImage = Properties.Resources.Manual_image;
            manualButton.BackgroundImageLayout = ImageLayout.Stretch;
            manualButton.Cursor = Cursors.Hand;
            manualButton.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manualButton.Location = new Point(518, 129);
            manualButton.Name = "manualButton";
            manualButton.Size = new Size(179, 192);
            manualButton.TabIndex = 0;
            manualButton.Text = "✏️ Manual";
            manualButton.TextAlign = ContentAlignment.BottomCenter;
            ManualToolTip.SetToolTip(manualButton, "Generate by your Names and References vehicles.\r\n\r\n");
            manualButton.UseVisualStyleBackColor = false;
            manualButton.Click += manualButton_Click;
            // 
            // autoButton
            // 
            autoButton.BackColor = Color.Transparent;
            autoButton.BackgroundImage = Properties.Resources.Brain_image;
            autoButton.BackgroundImageLayout = ImageLayout.Stretch;
            autoButton.Cursor = Cursors.Hand;
            autoButton.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoButton.ImageKey = "(none)";
            autoButton.Location = new Point(103, 138);
            autoButton.Name = "autoButton";
            autoButton.Size = new Size(179, 192);
            autoButton.TabIndex = 1;
            autoButton.Text = "🚀 Auto";
            autoButton.TextAlign = ContentAlignment.BottomCenter;
            ManualToolTip.SetToolTip(autoButton, "Generate 10,000 Vehicles !\r\n");
            autoButton.UseVisualStyleBackColor = false;
            autoButton.Click += autoButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 47);
            label1.Name = "label1";
            label1.Size = new Size(293, 32);
            label1.TabIndex = 2;
            label1.Text = "🚗 Vehicle Fleet Manager";
            // 
            // ManualToolTip
            // 
            ManualToolTip.Popup += ManualToolTip_Popup;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Blue_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(autoButton);
            Controls.Add(manualButton);
            Name = "MenuForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button manualButton;
        private Button autoButton;
        private Label label1;
        private ToolTip ManualToolTip;
    }
}
