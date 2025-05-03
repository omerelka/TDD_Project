using TDD_Proj;
using TDD_Proj.Models;
using TDD_Proj.Services;
using System.ComponentModel;

namespace TDD_PROJ
{
    public partial class ManualForm : Form
    {
        public ManualForm()
        {
            InitializeComponent();
        }

        private BindingList<Vehicle> vehicles = new();
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

            Vehicle vehicle = new Vehicle(nextVehicleId, model, manufacturer, year, type, status);
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
    }
}
