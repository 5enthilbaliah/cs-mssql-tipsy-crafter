namespace AmritaDb.Tipsy.Domain.Universal;

using Retail;

public class ContactType
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    
    public ICollection<StoreContact> Contacts => null!;
}