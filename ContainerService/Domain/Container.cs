namespace Domain;

public class Container : BaseEntity
{
	public int IsoNumber { get; set; }

	public Guid TypeId { get; set; }

	public bool IsEngaged { get; set; }
}