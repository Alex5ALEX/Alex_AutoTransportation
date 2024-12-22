namespace Auto_TransportationClient.Models;

public class Admin
{
    public Guid Id { get; set; }
    public Guid PersonId { get; set; }
    public Person? Person { get; set; }
}
