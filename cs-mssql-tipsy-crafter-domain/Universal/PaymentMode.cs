namespace AmritaDb.Tipsy.Domain.Universal;

using Purchase;

public class PaymentMode
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public ICollection<Settlement> Settlements => null!;
}