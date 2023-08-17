namespace AmritaDb.Tipsy.Domain.Universal;

using Purchase;

public class Shipper
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public ICollection<Delivery> Deliveries => null!;
}