using Services.Services.Contracts.ContainerType;

namespace Services.Services.Contracts.Container;
/// <summary>
/// DTO контейнера
/// </summary>
public class ContainerDto
{
	/// <summary>
	/// Идентификатор контейнера.
	/// </summary>
	public Guid Id { get; set; }

	/// <summary>
	/// ISO номер.
	/// </summary>
	public string IsoNumber { get; set; }
	
	/// <summary>
	/// Идентификатор типа контейнера.
	/// </summary>
	public Guid TypeId { get; set; }
}