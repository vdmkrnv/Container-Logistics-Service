namespace DBTest
{
    internal class Containe
    {
        public long Id { get; set; }
        public TypeContainer Type { get; set; }
        public decimal Cost { get; set; }
        public List<Order>? Orders { get; set; }

        public Containe(TypeContainer type, decimal cost)
        {
            Type = type;
            Cost = cost;
        }
    }

    public enum TypeContainer
    {
        UNDEF, STANDART, FREEZ, OPEN, PLATFORM, BOILER, TERMOS, SILK, VENT
    }
}