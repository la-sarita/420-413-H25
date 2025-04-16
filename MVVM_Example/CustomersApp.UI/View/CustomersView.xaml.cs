using CustomersApp.UI.Data;
using CustomersApp.UI.Model;
using CustomersApp.UI.ViewModel;
using System.Windows;

namespace CustomersApp.UI.View
{
    /// <summary>
    /// Logique d'interaction pour CustomersView.xaml
    /// </summary>
    public partial class CustomersView : Window
    {
        private CustomersViewModel _viewModel;

        public CustomersView()
        {
            InitializeComponent();
            _viewModel = new CustomersViewModel(new CustomerDataProvider());
            DataContext = _viewModel;
            Loaded += OnLoaded;
        }

        public async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();

        }
    }
}
