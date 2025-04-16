using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomersApp.UI.Model;

namespace CustomersApp.UI.Data
{
    interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }

    internal class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            await Task.Delay(1000);
            var customers = new List<Customer>() 
            { 
                new Customer { FirstName = "Ali", LastName = "Badr", IsDeveloper = false },
                new Customer { FirstName = "Faissal", LastName = "Karim", IsDeveloper = false },
                new Customer { FirstName = "Marc-André", LastName = "Brubé", IsDeveloper = false },
                new Customer { FirstName = "Nicolas", LastName = "Wallet", IsDeveloper = true },
            };

            return customers;
        }
    }
}
