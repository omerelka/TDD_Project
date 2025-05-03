namespace TDD_PROJ
{
    partial class ManualForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            buttonSubmit = new Button();
            labelVehicleNumber = new Label();
            labelType = new Label();
            labelMaintenance = new Label();
            labelYear = new Label();
            labelManufacturer = new Label();
            labelModel = new Label();
            textBoxVehicleNumber = new TextBox();
            textBoxModel = new TextBox();
            textBoxManufacturer = new TextBox();
            comboBoxType = new ComboBox();
            comboBoxMaintenance = new ComboBox();
            numericUpDownYear = new NumericUpDown();
            buttonFinish = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Cursor = Cursors.Hand;
            buttonSubmit.Location = new Point(117, 622);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(150, 46);
            buttonSubmit.TabIndex = 0;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelVehicleNumber
            // 
            labelVehicleNumber.AutoSize = true;
            labelVehicleNumber.BackColor = Color.Transparent;
            labelVehicleNumber.Location = new Point(79, 72);
            labelVehicleNumber.Name = "labelVehicleNumber";
            labelVehicleNumber.Size = new Size(144, 32);
            labelVehicleNumber.TabIndex = 1;
            labelVehicleNumber.Text = "Car Number";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.BackColor = Color.Transparent;
            labelType.Location = new Point(79, 484);
            labelType.Name = "labelType";
            labelType.Size = new Size(65, 32);
            labelType.TabIndex = 6;
            labelType.Text = "Type";
            // 
            // labelMaintenance
            // 
            labelMaintenance.AutoSize = true;
            labelMaintenance.BackColor = Color.Transparent;
            labelMaintenance.Location = new Point(79, 400);
            labelMaintenance.Name = "labelMaintenance";
            labelMaintenance.Size = new Size(153, 32);
            labelMaintenance.TabIndex = 5;
            labelMaintenance.Text = "Maintenance";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.BackColor = Color.Transparent;
            labelYear.Location = new Point(79, 317);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(58, 32);
            labelYear.TabIndex = 4;
            labelYear.Text = "Year";
            // 
            // labelManufacturer
            // 
            labelManufacturer.AutoSize = true;
            labelManufacturer.BackColor = Color.Transparent;
            labelManufacturer.Location = new Point(79, 235);
            labelManufacturer.Name = "labelManufacturer";
            labelManufacturer.Size = new Size(158, 32);
            labelManufacturer.TabIndex = 3;
            labelManufacturer.Text = "Manufacturer";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.BackColor = Color.Transparent;
            labelModel.Location = new Point(79, 154);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(83, 32);
            labelModel.TabIndex = 2;
            labelModel.Text = "Model";
            // 
            // textBoxVehicleNumber
            // 
            textBoxVehicleNumber.Cursor = Cursors.IBeam;
            textBoxVehicleNumber.Location = new Point(358, 72);
            textBoxVehicleNumber.Name = "textBoxVehicleNumber";
            textBoxVehicleNumber.Size = new Size(200, 39);
            textBoxVehicleNumber.TabIndex = 7;
            // 
            // textBoxModel
            // 
            textBoxModel.Cursor = Cursors.IBeam;
            textBoxModel.Location = new Point(358, 154);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(200, 39);
            textBoxModel.TabIndex = 8;
            // 
            // textBoxManufacturer
            // 
            textBoxManufacturer.Cursor = Cursors.IBeam;
            textBoxManufacturer.Location = new Point(358, 235);
            textBoxManufacturer.Name = "textBoxManufacturer";
            textBoxManufacturer.Size = new Size(200, 39);
            textBoxManufacturer.TabIndex = 9;
            // 
            // comboBoxType
            // 
            comboBoxType.Cursor = Cursors.Hand;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(340, 484);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(242, 40);
            comboBoxType.TabIndex = 11;
            // 
            // comboBoxMaintenance
            // 
            comboBoxMaintenance.Cursor = Cursors.Hand;
            comboBoxMaintenance.FormattingEnabled = true;
            comboBoxMaintenance.Location = new Point(340, 400);
            comboBoxMaintenance.Name = "comboBoxMaintenance";
            comboBoxMaintenance.Size = new Size(242, 40);
            comboBoxMaintenance.TabIndex = 10;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Cursor = Cursors.Hand;
            numericUpDownYear.Location = new Point(342, 317);
            numericUpDownYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(240, 39);
            numericUpDownYear.TabIndex = 12;
            numericUpDownYear.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // buttonFinish
            // 
            buttonFinish.BackColor = Color.Transparent;
            buttonFinish.Cursor = Cursors.Hand;
            buttonFinish.Location = new Point(486, 622);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(150, 46);
            buttonFinish.TabIndex = 13;
            buttonFinish.Text = "Finish";
            buttonFinish.UseVisualStyleBackColor = false;
            buttonFinish.Click += buttonFinish_Click;
            // 
            // ManualForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = TDD_Proj.Properties.Resources.Blue_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(823, 1021);
            Controls.Add(buttonFinish);
            Controls.Add(buttonSubmit);
            Controls.Add(labelVehicleNumber);
            Controls.Add(labelModel);
            Controls.Add(labelManufacturer);
            Controls.Add(labelYear);
            Controls.Add(labelMaintenance);
            Controls.Add(labelType);
            Controls.Add(textBoxVehicleNumber);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxManufacturer);
            Controls.Add(comboBoxMaintenance);
            Controls.Add(comboBoxType);
            Controls.Add(numericUpDownYear);
            Name = "ManualForm";
            Text = "Vehicle Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSubmit;
        private Label labelVehicleNumber;
        private Label labelModel;
        private Label labelManufacturer;
        private Label labelYear;
        private Label labelMaintenance;
        private Label labelType;
        private TextBox textBoxVehicleNumber;
        private TextBox textBoxModel;
        private TextBox textBoxManufacturer;
        private ComboBox comboBoxMaintenance;
        private ComboBox comboBoxType;
        private NumericUpDown numericUpDownYear;
        private Button buttonFinish;

    }
}