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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            vehicleGrid = new DataGridView();
            AnaliticsButton = new Button();
            DoneButton = new Button();
            ((System.ComponentModel.ISupportInitialize)vehicleGrid).BeginInit();
            SuspendLayout();
            // 
            // vehicleGrid
            // 
            vehicleGrid.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            vehicleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            vehicleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            vehicleGrid.DefaultCellStyle = dataGridViewCellStyle4;
            vehicleGrid.EnableHeadersVisualStyles = false;
            vehicleGrid.GridColor = Color.Gainsboro;
            vehicleGrid.Location = new Point(35, 110);
            vehicleGrid.Name = "vehicleGrid";
            vehicleGrid.RowHeadersWidth = 82;
            vehicleGrid.RowTemplate.Height = 35;
            vehicleGrid.Size = new Size(1613, 906);
            vehicleGrid.TabIndex = 0;
            // 
            // AnaliticsButton
            // 
            AnaliticsButton.BackColor = Color.FromArgb(52, 152, 219);
            AnaliticsButton.Cursor = Cursors.Hand;
            AnaliticsButton.FlatStyle = FlatStyle.Flat;
            AnaliticsButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AnaliticsButton.ForeColor = Color.White;
            AnaliticsButton.Location = new Point(35, 1068);
            AnaliticsButton.Name = "AnaliticsButton";
            AnaliticsButton.RightToLeft = RightToLeft.No;
            AnaliticsButton.Size = new Size(165, 54);
            AnaliticsButton.TabIndex = 2;
            AnaliticsButton.Text = "Analytics";
            AnaliticsButton.UseVisualStyleBackColor = false;
            AnaliticsButton.Click += AnalyticsButton_Click;
            // 
            // DoneButton
            // 
            DoneButton.BackColor = Color.FromArgb(46, 204, 113);
            DoneButton.Cursor = Cursors.Hand;
            DoneButton.FlatStyle = FlatStyle.Flat;
            DoneButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DoneButton.ForeColor = Color.White;
            DoneButton.Location = new Point(1483, 1068);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(165, 54);
            DoneButton.TabIndex = 3;
            DoneButton.Text = "Done";
            DoneButton.UseVisualStyleBackColor = false;
            DoneButton.Click += DoneButton_Click;
            // 
            // PresenationForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Blue_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1692, 1164);
            Controls.Add(DoneButton);
            Controls.Add(AnaliticsButton);
            Controls.Add(vehicleGrid);
            Font = new Font("Segoe UI", 10F);
            Name = "PresenationForm";
            Text = "Vehicle Presentation";
            ((System.ComponentModel.ISupportInitialize)vehicleGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView vehicleGrid;
        private Button AnaliticsButton;
        private Button DoneButton;
    }
}
