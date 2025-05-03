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

        private void AnalyticsButton_Click(object sender, EventArgs e)
        {
            var report = AnalyticsService.BuildReport(_vehicles);
            MessageBox.Show(report, "Fleet Analytics",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static class AnalyticsService
        {
            public static string BuildReport(BindingList<Vehicle> vehicles)
            {
                int avgYear = VehicleServices.CalculateAverageYear(vehicles);
                int sortMs = VehicleServices.TimeToSort;
                int needsMaint = VehicleServices.CountVehiclesNeedMaintenance(vehicles);
                return
                  $"Average year: {avgYear}\n" +
                  $"Sort time: {sortMs} ms\n" +
                  $"Needs maintenance: {needsMaint}";
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
