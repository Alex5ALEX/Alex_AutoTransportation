namespace Auto_TransportationClient.Models;

public class Customer
{
    public Guid Id { get; set; }

    public Guid PersonId { get; set; }
    public Person? Person { get; set; }
    public List<Transportation> Transportations { get; set; } = [];
}
