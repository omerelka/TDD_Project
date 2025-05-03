using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TDD_Proj.Models;
using TDD_Proj.Services;
using System.ComponentModel;
using TDD_PROJ;
namespace TDD_Proj
{
    public partial class MenuForm : Form
    {
        private BindingList<Vehicle> _vehicles = new();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            ManualForm manualForm = new ManualForm();
            manualForm.Show();
            this.Hide();
        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            const int count = 10_000;
            var randoms = ConsoleInputHelper.GenerateRandomVehicles(count);
            foreach (var v in randoms)
                _vehicles.Add(v);
            MessageBox.Show($"{count} random vehicles generated.");
            _vehicles = VehicleServices.SortByYearDescending( _vehicles );
            PresenationForm presentationform = new PresenationForm(_vehicles);
            presentationform.Show();
            this.Hide();
            
        }

    }
    
}
