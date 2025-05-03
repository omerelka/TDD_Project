using System;
using TDD_Proj.Models;
using TDD_PROJ;
using Xunit;

namespace TDD_Proj.tests
{
    public class VehicleFactoryTests
    {
        [Fact]
        public void Create_ValidInputs_ReturnsVehicleWithExpectedProperties()
        {
            // Arrange
            int id = 5;
            string model = "Civic";
            string manuf = "Honda";
            int year = 2023;
            string typeText = "Private";
            string statusText = "Ok";

            // Act
            var v = ManualForm.VehicleFactory.Create(id, model, manuf, year, typeText, statusText);

            // Assert
            Assert.Equal(id, v.Id);
            Assert.Equal(model, v.Model);
            Assert.Equal(manuf, v.Manufacturer);
            Assert.Equal(year, v.Year);
            Assert.Equal(VehicleType.Private, v.Type);
            Assert.Equal(MaintenanceStatus.Ok, v.Status);
        }

        [Fact]
        public void Create_EmptyModel_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                ManualForm.VehicleFactory.Create(1, "", "Maker", 2020, "Bus", "Ok"));
        }

        [Fact]
        public void Create_NullManufacturer_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                ManualForm.VehicleFactory.Create(1, "X", null!, 2020, "Bus", "Ok"));
        }

        [Fact]
        public void Create_YearBelow2000_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                ManualForm.VehicleFactory.Create(1, "X", "Y", 1999, "Bus", "Ok"));
        }

        [Fact]
        public void Create_YearAbove2025_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                ManualForm.VehicleFactory.Create(1, "X", "Y", 2026, "Bus", "Ok"));
        }

        [Fact]
        public void Create_InvalidTypeText_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                ManualForm.VehicleFactory.Create(1, "X", "Y", 2020, "Plane", "Ok"));
        }

        [Fact]
        public void Create_InvalidStatusText_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                ManualForm.VehicleFactory.Create(1, "X", "Y", 2020, "Bus", "Broken"));
        }
    }
}