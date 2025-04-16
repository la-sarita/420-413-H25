using Examen2.Pratique.Data;
using Examen2.Pratique.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examen2.Pratique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LivresViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new LivresViewModel(new LivreDataProvider());
            DataContext = _viewModel;
            Loaded += OnLoaded;
        }

        public async void OnLoaded(object sender, RoutedEventArgs e) 
        { 
            await _viewModel.LoadAsync(); 
        }
    }
}