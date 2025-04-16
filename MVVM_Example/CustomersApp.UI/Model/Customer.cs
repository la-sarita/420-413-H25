namespace CustomersApp.UI.Model
{
    public class Customer
    {
        private static int _nbCustomers = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDeveloper { get; set; }

        public Customer()
        {
            Id = ++_nbCustomers;
        }
    }
}