// See https://aka.ms/new-console-template for more information
using DBTest;

Console.WriteLine("Hello, World!");


using (var db = new ContainerContext())
{
    var port1 = new Port("Saint-Peterburg");
    var port2 = new Port("Vladivostok");
    var port3 = new Port("Tokio");
    db.Ports.AddRange(port1, port2, port3);


    var container1 = new Containe(TypeContainer.STANDART, 10000);
    var container2 = new Containe(TypeContainer.OPEN, 10000);
    var container3 = new Containe(TypeContainer.PLATFORM, 10000);
    var container4 = new Containe(TypeContainer.BOILER, 10000);
    var container5 = new Containe(TypeContainer.TERMOS, 10000);
    db.Containers.AddRange(container1, container2, container3, container4, container5);


    var client1 = new Client("mail.ru", "art", "pass");
    var client2 = new Client("google.com", "tom", "qwerty");
    db.Clients.AddRange(client1, client2);


    var containers1 = new List<Containe>
    {
        container1
    };
    //var order1 = new Order(port1, port2, 1111.222m/*, containers1*/);
    var order1 = new Order
    {
        Port1 = port1,
        Port2 = port2,
        Containers = containers1
    };


    var containers2 = new List<Containe>
           {
               container2,
               container3
           };
    //var order2 = new Order(port1, port3, 3333.221m, containers2);
    var order2 = new Order
    {
        Port1 = port2,
        Port2 = port3,
        Containers = containers2
    };

    var containers3 = new List<Containe>
           {
               container1,
               container2,
               container3,
               container4,
               container5
           };
    //var order3 = new Order(port3, port2, 4443.321m, containers3);
    var order3 = new Order
    {
        Port1 = port3,
        Port2 = port2,
        Containers = containers3
    };

    db.Orders.AddRange(order1, order2, order3);


    db.SaveChanges();
}