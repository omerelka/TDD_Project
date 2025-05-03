using System;
using System.Collections.Generic;
using TDD_Proj.Models;

namespace TDD_Proj.Services
{
    /// <summary>
    /// Provides input-related helper methods for vehicle data, such as random generation.
    /// </summary>
    public static class ConsoleInputHelper
    {
        /// <summary>
        /// Generates a list of random Vehicle instances using predefined models and manufacturers.
        /// </summary>
        /// <param name="count">Number of vehicles to generate.</param>
        /// <returns>List of randomly generated vehicles.</returns>
        public static List<Vehicle> GenerateRandomVehicles(int count)
        {
            var list = new List<Vehicle>(count);
            var rnd = new Random();

            string[] models = { "A1", "Civic", "Corolla", "Model 3", "Octavia", "Fiesta" };
            string[] manufacturers = { "Toyota", "Honda", "Ford", "Tesla", "Skoda", "Mazda" };
            var types = (VehicleType[])Enum.GetValues(typeof(VehicleType));
            var statuses = (MaintenanceStatus[])Enum.GetValues(typeof(MaintenanceStatus));

            for (int i = 0; i < count; i++)
            {
                var vehicle = new Vehicle(
                    i + 1,
                    models[rnd.Next(models.Length)],
                    manufacturers[rnd.Next(manufacturers.Length)],
                    rnd.Next(2000, 2026), // Year between 2000 and 2025 inclusive
                    types[rnd.Next(types.Length)],
                    statuses[rnd.Next(statuses.Length)]
                );
                list.Add(vehicle);
            }

            return list;
        }
    }
}
