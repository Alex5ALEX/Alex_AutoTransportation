namespace AutoTransportationServer.Models;

public class Auto
{
    public Guid Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public double MaxFuel { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;

    public List<Driver> Drivers { get; set; } = [];

    public Guid FuelId { get; set; }

    public Fuel? Fuel { get; set; }
}
