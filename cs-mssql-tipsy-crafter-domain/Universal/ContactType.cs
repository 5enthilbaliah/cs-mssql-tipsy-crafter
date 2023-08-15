namespace AmritaDb.Tipsy.Domain.Universal;

using Purchase;

using Retail;

public class ContactType
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    
    public ICollection<StoreContact> StoreContacts => null!;
    
    public ICollection<SupplierContact> SupplierContacts => null!;
}