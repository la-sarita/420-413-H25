using System.Collections.ObjectModel;

namespace Atelier5.Exo1.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; private set; } = new ObservableCollection<Product>();
    }
}
