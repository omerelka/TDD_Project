using System.ComponentModel;
using TDD_Proj;
using TDD_Proj.Models;
using TDD_Proj.Services;
using Xunit;

namespace TDD_Proj.tests
{
    public class AnalyticsServiceTests
    {
        [Fact]
        public void BuildReport_EmptyList_ShowsZerosAndNoErrors()
        {
            // Arrange
            var list = new BindingList<Vehicle>();

            // Act
            string report = PresenationForm.AnalyticsService.BuildReport(list);

            // Assert
            Assert.Contains("Average year: 0", report);
            Assert.Contains("Sort time: ", report);      // any numerical value
            Assert.Contains("Needs maintenance: 0", report);
        }

        [Fact]
        public void BuildReport_WithVehicles_CalculatesCorrectValues()
        {
            // Arrange
            var list = new BindingList<Vehicle>
            {
                new Vehicle(1, "A", "X", 2000, VehicleType.Private, MaintenanceStatus.Ok),
                new Vehicle(2, "B", "Y", 2010, VehicleType.Truck, MaintenanceStatus.RequiresMaintenance),
                new Vehicle(3, "C", "Z", 2020, VehicleType.Bus, MaintenanceStatus.Ok)
            };
            // Ensure TimeToSort is initialized
            VehicleServices.SortByYearDescending(list);

            // Act
            string report = PresenationForm.AnalyticsService.BuildReport(list);

            // Assert average (2000+2010+2020)/3 = 2010
            Assert.Contains("Average year: 2010", report);
            // Assert maintenance count 1
            Assert.Contains("Needs maintenance: 1", report);
            // Assert Sort time appears as ms
            Assert.Matches(@"Sort time: \d+ ms", report);
        }
    }
}
