namespace Services.Services.Contracts.ContainerType;

/// <summary>
/// DTO типа контейнера
/// </summary>
public class ContainerTypeDto
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public double PricePerDay { get; set; }
}