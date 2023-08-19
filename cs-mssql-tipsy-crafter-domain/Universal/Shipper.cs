namespace AmritaDb.Tipsy.Domain.Universal;

using Purchase;

using Retail;

public class Shipper
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ModifiedBy { get; set; } = null!;

    public ICollection<Delivery> Deliveries => null!;
    public ICollection<Shipment> Shipments => null!;
}