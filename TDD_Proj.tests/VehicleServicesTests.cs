using System;
using System.ComponentModel;
using System.Linq;
using TDD_Proj.Models;
using TDD_Proj.Services;
using Xunit;

namespace TDD_Proj.tests
{
    public class VehicleServicesTests
    {
        [Fact]
        public void SortByYearDescending_PreservesCountAndOrdersCorrectly()
        {
            // Arrange
            var vehicles = new BindingList<Vehicle>
            {
                new Vehicle(1, "A", "X", 2010, VehicleType.Bus, MaintenanceStatus.Ok),
                new Vehicle(2, "B", "Y", 2000, VehicleType.Truck, MaintenanceStatus.RequiresMaintenance),
                new Vehicle(3, "C", "Z", 2020, VehicleType.Private, MaintenanceStatus.Ok)
            };

            // Act
            var sorted = VehicleServices.SortByYearDescending(vehicles);

            // Assert count preserved
            Assert.Equal(vehicles.Count, sorted.Count);
            // Assert order: first highest year, last lowest
            Assert.Equal(2020, sorted[0].Year);
            Assert.Equal(2000, sorted[^1].Year);
        }

        [Fact]
        public void CalculateAverageYear_ReturnsZeroForEmptyList()
        {
            // Arrange
            var empty = new BindingList<Vehicle>();

            // Act
            int avg = VehicleServices.CalculateAverageYear(empty);

            // Assert
            Assert.Equal(0, avg);
        }

        [Fact]
        public void CalculateAverageYear_ReturnsCorrectAverage()
        {
            // Arrange
            var list = new BindingList<Vehicle>
            {
                new Vehicle(1, "A", "X", 2000, VehicleType.Bus, MaintenanceStatus.Ok),
                new Vehicle(2, "B", "Y", 2005, VehicleType.Truck, MaintenanceStatus.Ok)
            };

            // Act
            int avg = VehicleServices.CalculateAverageYear(list);

            // Assert: average of 2000 and 2005 is (2000+2005)/2 = 2002
            Assert.Equal((2000 + 2005) / 2, avg);
        }

        [Fact]
        public void CountVehiclesNeedMaintenance_CountsCorrectly()
        {
            // Arrange
            var list = new BindingList<Vehicle>
            {
                new Vehicle(1, "A", "X", 2010, VehicleType.Bus, MaintenanceStatus.Ok),
                new Vehicle(2, "B", "Y", 2011, VehicleType.Truck, MaintenanceStatus.RequiresMaintenance),
                new Vehicle(3, "C", "Z", 2012, VehicleType.Private, MaintenanceStatus.RequiresMaintenance)
            };

            // Act
            int count = VehicleServices.CountVehiclesNeedMaintenance(list);

            // Assert: two vehicles require maintenance
            Assert.Equal(2, count);
        }
    }
}
