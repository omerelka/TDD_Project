namespace TDD_Proj
{
    partial class PresenationForm
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
            vehicleGrid = new DataGridView();
            AnaliticsButton = new Button();
            DoneButton = new Button();
            ((System.ComponentModel.ISupportInitialize)vehicleGrid).BeginInit();
            SuspendLayout();
            // 
            // vehicleGrid
            // 
            vehicleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehicleGrid.Location = new Point(35, 110);
            vehicleGrid.Name = "vehicleGrid";
            vehicleGrid.RowHeadersWidth = 82;
            vehicleGrid.Size = new Size(1613, 906);
            vehicleGrid.TabIndex = 0;
            // 
            // AnaliticsButton
            // 
            AnaliticsButton.Location = new Point(35, 1068);
            AnaliticsButton.Name = "AnaliticsButton";
            AnaliticsButton.Size = new Size(165, 54);
            AnaliticsButton.TabIndex = 2;
            AnaliticsButton.Text = "Analytics";
            AnaliticsButton.UseVisualStyleBackColor = true;
            AnaliticsButton.Click += AnaliticsButton_Click;
            // 
            // DoneButton
            // 
            DoneButton.Location = new Point(1483, 1068);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(165, 54);
            DoneButton.TabIndex = 3;
            DoneButton.Text = "Done";
            DoneButton.UseVisualStyleBackColor = true;
            DoneButton.Click += DoneButton_Click;
            // 
            // AutoForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1692, 1164);
            Controls.Add(DoneButton);
            Controls.Add(AnaliticsButton);
            Controls.Add(vehicleGrid);
            Name = "AutoForm";
            Text = "AutoForm";
            ((System.ComponentModel.ISupportInitialize)vehicleGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView vehicleGrid;
        private Button AnaliticsButton;
        private Button DoneButton;
    }
}