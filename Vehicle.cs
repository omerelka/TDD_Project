namespace TDD_Proj.Models
{
    public enum VehicleType { Bus, Truck, Commercial, Private }
    public enum MaintenanceStatus { Ok, RequiresMaintenance }

    public class Vehicle
    {
        public int Id { get; }
        public string Model { get; }
        public string Manufacturer { get; }
        public int Year { get; }
        public VehicleType Type { get; }
        public MaintenanceStatus Status { get; }

        public Vehicle(int id, string model, string manufacturer,
            int year, VehicleType type, MaintenanceStatus status)
        {
            Id = id;
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            Type = type;
            Status = status;
        }

        public override string ToString() =>
            $"ID:{Id} ─ {Manufacturer} {Model} ({Year}) [{Type}] → {Status}";
    }
}