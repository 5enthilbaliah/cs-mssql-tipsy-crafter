namespace AmritaDb.Tipsy.Domain.Retail;

public class SaleStatus
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ModifiedBy { get; set; } = null!;

    public ICollection<Receipt> Receipts => null!;
}