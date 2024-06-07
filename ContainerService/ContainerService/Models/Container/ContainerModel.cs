namespace WebApi.Models.Container;

public class ContainerModel
{
	public Guid Id { get; set; }

	public string IsoNumber { get; set; }

	public Guid ContainerTypeId { get; set; }

	public bool IsEngaged { get; set; }
}