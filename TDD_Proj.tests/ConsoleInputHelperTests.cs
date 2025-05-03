using System;
using System.Linq;
using System.Collections.Generic;
using TDD_Proj.Models;
using TDD_Proj.Services;
using Xunit;

namespace TDD_Proj.tests
{
    public class ConsoleInputHelperTests
    {
        [Fact]
        public void GenerateRandomVehicles_ReturnsCorrectCount()
        {
            // Arrange
            int count = 500;

            // Act
            List<Vehicle> list = ConsoleInputHelper.GenerateRandomVehicles(count);

            // Assert
            Assert.Equal(count, list.Count);
        }

        [Fact]
        public void GenerateRandomVehicles_IdsAreUnique()
        {
            // Arrange
            int count = 1000;

            // Act
            List<Vehicle> list = ConsoleInputHelper.GenerateRandomVehicles(count);

            // Assert
            var distinctCount = list.Select(v => v.Id).Distinct().Count();
            Assert.Equal(count, distinctCount);
        }

        [Fact]
        public void GenerateRandomVehicles_FieldsWithinExpectedRanges()
        {
            // Arrange
            int count = 200;
            var validTypes = Enum.GetValues(typeof(VehicleType)).Cast<VehicleType>().ToHashSet();
            var validStatus = Enum.GetValues(typeof(MaintenanceStatus)).Cast<MaintenanceStatus>().ToHashSet();

            // Act
            List<Vehicle> list = ConsoleInputHelper.GenerateRandomVehicles(count);

            // Assert each vehicle
            foreach (var v in list)
            {
                Assert.InRange(v.Year, 2000, 2025);
                Assert.Contains(v.Type, validTypes);
                Assert.Contains(v.Status, validStatus);
                Assert.False(string.IsNullOrWhiteSpace(v.Model));
                Assert.False(string.IsNullOrWhiteSpace(v.Manufacturer));
            }
        }
    }
}