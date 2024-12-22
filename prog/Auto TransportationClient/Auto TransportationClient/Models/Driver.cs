namespace Auto_TransportationClient.Models;

public class Driver : Human
{

    public Guid AutoId { get; set; } = Guid.Empty;
    public Auto? Auto {  get; set; }
}
