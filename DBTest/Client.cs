namespace DBTest
{
    internal class Client
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Telephone { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Order>? Orders { get; set; }

        public Client(string email, string login, string password)
        {
            Email = email;
            Login = login;
            Password = password;
        }
    }
}