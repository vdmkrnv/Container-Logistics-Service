namespace Services.Services.Contracts;

/// <summary>
/// DTO отменяемого заказа
/// </summary>
public class CancelingOrderDto
{
    /// <summary>
    ///  Идентификатор удаляемого заказа
    /// </summary>
    public Guid Id { get; set; }
}