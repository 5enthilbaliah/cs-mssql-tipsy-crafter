namespace AmritaDb.Tipsy.Domain.Retail;

using Universal;

public class StoreContact
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Detail { get; set; } = null!;
    public bool IsPrimary { get; set; }
    public string StoreId { get; set; } = null!;
    public string ContactTypeId { get; set; } = null!;
    public string ModifiedBy { get; set; } = null!;
    
    public Store Store { get; set; } = null!;
    public ContactType ContactType { get; set; } = null!;
}