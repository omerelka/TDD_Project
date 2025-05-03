using TDD_Proj;
using TDD_Proj.Models;
using TDD_Proj.Services;
using System.ComponentModel;

namespace TDD_PROJ
{
    public partial class ManualForm : Form
    {
        private BindingList<Vehicle> vehicles;
        public ManualForm(BindingList<Vehicle> _vehicles)
        {
            InitializeComponent();
            vehicles = _vehicles;
        }
        public ManualForm() : this(new BindingList<Vehicle>()) { }
        

        private int nextVehicleId = 1;



        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string model = textBoxModel.Text;
            string manufacturer = textBoxManufacturer.Text;
            int year = (int)numericUpDownYear.Value;
            string typeStr = comboBoxType.SelectedItem.ToString();
            string statusStr = comboBoxMaintenance.SelectedItem.ToString();

            VehicleType type = Enum.Parse<VehicleType>(typeStr);
            MaintenanceStatus status = Enum.Parse<MaintenanceStatus>(statusStr);

            //Vehicle vehicle = new Vehicle(nextVehicleId, model, manufacturer, year, type, status);
            Vehicle vehicle = VehicleFactory.Create(nextVehicleId, model, manufacturer, year, typeStr, statusStr);
            vehicles.Add(vehicle);

            nextVehicleId++;

            MessageBox.Show(vehicle.ToString(), "Vehicle Created");
            ClearFormFields();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxType.Items.AddRange(new string[] { "Private", "Commercial", "Truck", "Bus" }); 
            comboBoxMaintenance.Items.AddRange(new string[] { "RequiresMaintenance", "OK" });
            comboBoxType.SelectedIndex = 0;
            comboBoxMaintenance.SelectedIndex = 0;
            numericUpDownYear.Minimum = 2000;
            numericUpDownYear.Maximum = 2025;
            numericUpDownYear.Value = 2025;

        }


        private void buttonFinish_Click(object sender, EventArgs e)
        {
            ClearFormFields();

            MessageBox.Show("Vehicle form completed.", "Finished");

            vehicles = VehicleServices.SortByYearDescending(vehicles);
            PresenationForm presentationform = new PresenationForm(vehicles);
            presentationform.Show();
            this.Close();

 
        }

        private void ClearFormFields()
        {
            textBoxModel.Text = "";
            textBoxManufacturer.Text = "";
            textBoxVehicleNumber.Text = "";
            comboBoxType.SelectedIndex = 0;
            comboBoxMaintenance.SelectedIndex = 0;
            numericUpDownYear.Value = 2025;
        }

        public static class VehicleFactory
        {
            public static Vehicle Create(int id, string model, string manufacturer,
                int year, string typeText, string statusText)
            {
                // Validate model/manufacturer
                if (string.IsNullOrWhiteSpace(model))
                    throw new ArgumentException("Model is required.");
                if (string.IsNullOrWhiteSpace(manufacturer))
                    throw new ArgumentException("Manufacturer is required.");

                // Validate year range
                if (year < 2000 || year > 2025)
                    throw new ArgumentOutOfRangeException(nameof(year), "Year must be between 2000 and 2025.");

                // Parse type
                if (!Enum.TryParse<VehicleType>(typeText, out var type))
                    throw new ArgumentException($"Invalid vehicle type: '{typeText}'");

                // Parse status
                if (!Enum.TryParse<MaintenanceStatus>(statusText, ignoreCase: true, out var status))
                    throw new ArgumentException($"Invalid maintenance status: '{statusText}'");

                return new Vehicle(id, model, manufacturer, year, type, status);
            }
        }
    }
}
