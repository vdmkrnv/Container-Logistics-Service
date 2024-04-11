namespace DBTest
{
    internal class Port
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public Port(string name)
        {
            Name = name;
        }
    }
}