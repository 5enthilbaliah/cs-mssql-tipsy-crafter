namespace AmritaDb.Tipsy.Domain.Universal;

using Purchase;

using Retail;

public class PaymentMode
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ModifiedBy { get; set; } = null!;

    public ICollection<Settlement> Settlements => null!;
    public ICollection<Payment> Payments => null!;
}