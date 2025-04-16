using CustomersApp.UI.Data;
using CustomersApp.UI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp.UI.ViewModel
{
    class CustomersViewModel : CustomersViewModelBase
    {
        private readonly ICustomerDataProvider _customerDataProvider;
        private Customer _selectedCustomer;

        public Customer SelectedCustomer {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Customer> Customers { get; } = new ObservableCollection<Customer>();
        
        public CustomersViewModel(ICustomerDataProvider customerDataProvider) 
        {
            _customerDataProvider = customerDataProvider;
        }

        public async Task LoadAsync()
        {
            var customers = await _customerDataProvider.GetAllAsync();
            if (customers != null)
            {
                foreach (var customer in customers)
                {
                    Customers.Add(customer);
                }
            }
        }
    }
}
