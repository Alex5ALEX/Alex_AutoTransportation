namespace AutoTransportationServer.Models;

public class Fuel
{
    public Guid Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
