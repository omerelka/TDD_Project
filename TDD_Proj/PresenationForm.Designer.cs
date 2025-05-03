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
            vehicleGrid.BackgroundColor = Color.WhiteSmoke;
            vehicleGrid.GridColor = Color.Gainsboro;
            vehicleGrid.DefaultCellStyle.BackColor = Color.White;
            vehicleGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            vehicleGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            vehicleGrid.EnableHeadersVisualStyles = false;
            vehicleGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            vehicleGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            vehicleGrid.RowTemplate.Height = 35;
            // 
            // AnaliticsButton
            // 
            AnaliticsButton.Location = new Point(35, 1068);
            AnaliticsButton.Name = "AnaliticsButton";
            AnaliticsButton.Size = new Size(165, 54);
            AnaliticsButton.TabIndex = 2;
            AnaliticsButton.Text = "Analytics";
            AnaliticsButton.BackColor = Color.FromArgb(52, 152, 219); // כחול מודרני
            AnaliticsButton.ForeColor = Color.White;
            AnaliticsButton.FlatStyle = FlatStyle.Flat;
            AnaliticsButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AnaliticsButton.Click += AnaliticsButton_Click;
            // 
            // DoneButton
            // 
            DoneButton.Location = new Point(1483, 1068);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(165, 54);
            DoneButton.TabIndex = 3;
            DoneButton.Text = "Done";
            DoneButton.BackColor = Color.FromArgb(46, 204, 113); // ירוק מודרני
            DoneButton.ForeColor = Color.White;
            DoneButton.FlatStyle = FlatStyle.Flat;
            DoneButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DoneButton.Click += DoneButton_Click;
            // 
            // PresenationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1692, 1164);
            BackColor = Color.White;
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
