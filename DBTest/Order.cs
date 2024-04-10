namespace DBTest
{
    internal class Order
    {
        public long Id { get; set; }
        public Port? Port1 { get; set; }
        public Port? Port2 { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime DepartTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public List<Containe>? Containers { get; set; }

        /* public Order(Port port1, Port port2, decimal price*//*, List<ContainerBox> containers*//*)
         {
             Port1 = port1;
             Port2 = port2;
             Price = price;
             //Containers = containers;
         }*/
    }
}
