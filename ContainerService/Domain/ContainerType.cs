namespace Domain;

/// <summary>
/// Доменная сущность контейнера
/// </summary>
public class ContainerType : BaseEntity
{
	/// <summary>
	/// Название типа
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// Цена за день аренды
	/// </summary>
	public double PricePerDay { get; set; }
	
	/// <summary>
	/// Флаг удаления
	/// </summary>
	public bool IsDeleted { get; set; }
}