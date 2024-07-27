using BusModels;

namespace Services.Bus.Interfaces;

public interface IDeleteOrderProducer
{ 
    Task NotifyOrderDeleted(OrderDeleted message);
}