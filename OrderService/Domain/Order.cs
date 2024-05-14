using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

[Table("orders")]
public class Order : BaseEntity
{
    [Column("client_id")]
    public Guid ClientId { get; set; }
    
    [Column("date_start")]
    public DateTime DateStart { get; set; }
    
    [Column("date_end")]
    public DateTime DateEnd { get; set; }
    
    [Column("hub_start_id")]
    public Guid HubStartId { get; set; }
    
    [Column("date_end_id")]
    public Guid HubEndId { get; set; }
    
    [Column("price")]
    public double Price { get; set; }
    
    [Column("costs")]
    public double Costs { get; set; }
    
    public ICollection<Container> Containers { get; set; }
    
    public ICollection<DownTime> DownTimes { get; set; }
    
    [Column("is_canceled")]
    public bool IsCanceled { get; set; }

    
    public Order()
    {
        Containers = new List<Container>();
        DownTimes = new List<DownTime>();
    }
}