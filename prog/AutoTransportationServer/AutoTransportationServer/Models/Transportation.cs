namespace AutoTransportationServer.Models;

public class Transportation
{
    public Guid Id { get; set; }
    public string From { get; set; } = string.Empty;
    public string To { get; set; } = string.Empty;
    public int Distance { get; set; } 
    public double FuelVolume {  get; set; } 

    public Guid FuelId { get; set; }
    public Guid DriverId { get; set; }
    public Guid CustomerId { get; set; }

    public Fuel? Fuel { get; set; }
    public Driver? Driver { get; set; }
    public Customer? Customer { get; set; }
}
