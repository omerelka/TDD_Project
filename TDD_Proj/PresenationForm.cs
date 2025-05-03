using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDD_Proj.Services;
using TDD_Proj.Models;

namespace TDD_Proj
{
    public partial class PresenationForm : Form
    {
        private readonly BindingList<Vehicle> _vehicles;
        public PresenationForm(BindingList<Vehicle> vehicles)
        {
            InitializeComponent();
            _vehicles = vehicles;
            vehicleGrid.AutoGenerateColumns = true;
            vehicleGrid.DataSource = _vehicles;
        }

        private void AnaliticsButton_Click(object sender, EventArgs e)
        {
            int avgYear = VehicleServices.CalculateAverageYear(_vehicles);
            int timeToSort = VehicleServices.TimeToSort;
            int vehiclesNeedMaintence = VehicleServices.CountVehiclesNeedMaintenance(_vehicles);
            MessageBox.Show($"Average year: {avgYear}\n" +
                            $"Time to sort : {timeToSort} ms\n " +
                            $"Vehicles need Maintence : {vehiclesNeedMaintence}");
                            
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
