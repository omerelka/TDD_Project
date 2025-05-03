using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Proj.Models;
using Xunit;

namespace TDD_Proj.tests
{
    public class VehicleTests
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            int id = 7;
            string model = "Corolla";
            string manufacturer = "Toyota";
            int year = 2022;
            var type = VehicleType.Commercial;
            var status = MaintenanceStatus.RequiresMaintenance;

            // Act
            var vehicle = new Vehicle(id, model, manufacturer, year, type, status);

            // Assert
            Assert.Equal(id, vehicle.Id);
            Assert.Equal(model, vehicle.Model);
            Assert.Equal(manufacturer, vehicle.Manufacturer);
            Assert.Equal(year, vehicle.Year);
            Assert.Equal(type, vehicle.Type);
            Assert.Equal(status, vehicle.Status);
        }

        [Fact]
        public void ToString_ReturnsExpectedFormat_Case1()
        {
            // Arrange
            var vehicle = new Vehicle(1, "ModelX", "MakerY", 2000, VehicleType.Bus, MaintenanceStatus.Ok);
            string expected = "ID:1 ─ MakerY ModelX (2000) [Bus] → Ok";

            // Act
            string result = vehicle.ToString();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToString_ReturnsExpectedFormat_Case2()
        {
            // Arrange
            var vehicle = new Vehicle(99, "F-150", "Ford", 2025, VehicleType.Private, MaintenanceStatus.RequiresMaintenance);
            string expected = "ID:99 ─ Ford F-150 (2025) [Private] → RequiresMaintenance";

            // Act
            string result = vehicle.ToString();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
