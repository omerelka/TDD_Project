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
            manualButton = new Button();
            autoButton = new Button();
            SuspendLayout();
            // 
            // manualButton
            // 
            manualButton.Location = new Point(526, 249);
            manualButton.Name = "manualButton";
            manualButton.Size = new Size(150, 46);
            manualButton.TabIndex = 0;
            manualButton.Text = "Manual";
            manualButton.UseVisualStyleBackColor = true;
            manualButton.Click += manualButton_Click;
            // 
            // autoButton
            // 
            autoButton.Location = new Point(122, 249);
            autoButton.Name = "autoButton";
            autoButton.Size = new Size(150, 46);
            autoButton.TabIndex = 1;
            autoButton.Text = "Auto";
            autoButton.UseVisualStyleBackColor = true;
            autoButton.Click += autoButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(autoButton);
            Controls.Add(manualButton);
            Name = "MenuForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button manualButton;
        private Button autoButton;
    }
}
