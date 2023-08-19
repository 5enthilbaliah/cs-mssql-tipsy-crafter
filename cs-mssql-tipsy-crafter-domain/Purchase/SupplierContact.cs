namespace AmritaDb.Tipsy.Domain.Purchase;

using Universal;

public class SupplierContact
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Detail { get; set; } = null!;
    public bool IsPrimary { get; set; }
    public string SupplierId { get; set; } = null!;
    public string ContactTypeId { get; set; } = null!;
    public string ModifiedBy { get; set; } = null!;

    public Supplier Supplier { get; set; } = null!;
    public ContactType ContactType { get; set; } = null!;
}