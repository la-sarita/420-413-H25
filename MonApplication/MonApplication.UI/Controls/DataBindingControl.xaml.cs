using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Demo.UI.Controls
{
    /// <summary>
    /// Logique d'interaction pour DataBindingControl.xaml
    /// </summary>
    public partial class DataBindingControl : UserControl
    {
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Student> Students { get; set; }
        public Student SelectedStudent { get; set; }
        public Product SelectedProduct { get; set; }
        public DataBindingControl()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>
            {
                new Product { Name = "Product 1", StartPrice = 100 },
                new Product { Name = "Product 2", StartPrice = 200 },
                new Product { Name = "Product 3", StartPrice = 300 }
            };
            
            Students = new ObservableCollection<Student>
            {
                new Student()
                {
                    ID = 101,
                    FirstName = "Mahesh",
                    LastName = "Chand",
                    Note = 66,
                    DateOfBirth = new DateTime(1975, 2, 23),
                    IsActive = false,
                },
                new Student()
                {
                    ID = 201,
                    FirstName = "Mike",
                    LastName = "Gold",
                    Note = 57,
                    DateOfBirth = new DateTime(1982, 4, 12),
                    IsActive = true,
                },
                new Student()
                {
                    ID = 244,
                    FirstName = "Mathew",
                    LastName = "Cochran",
                    Note = 86,
                    DateOfBirth = new DateTime(1985, 9, 11),
                    IsActive = true,
                }
            };

            DataContext = this;
        }

        //private void StudentDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}
    }
    public class Product
    {
        public string Name { get; set; }
        public int StartPrice { get; set; }
    }

    public class Student
    {
        public int ID { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; internal set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        internal float Note { get; set; }
    }
}
