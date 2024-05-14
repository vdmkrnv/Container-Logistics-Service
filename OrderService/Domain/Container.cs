namespace Domain;

public class Container : BaseEntity
{
    public string IsoNumber { get; set; }
    
    public Guid TypeId { get; set; }
    
    public bool IsEngaged { get; set; }
}
