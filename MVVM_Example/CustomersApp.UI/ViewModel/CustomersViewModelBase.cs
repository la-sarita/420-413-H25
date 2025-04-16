using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CustomersApp.UI.ViewModel
{
    internal class CustomersViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}