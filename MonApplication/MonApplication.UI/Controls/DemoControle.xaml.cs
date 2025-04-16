using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Demo.UI.Controls
{
    /// <summary>
    /// Logique d'interaction pour DemoControle.xaml
    /// </summary>
    public partial class DemoControle : UserControl
    {
        public string SelectedOption { get; set; } = "Option 2";

        public DemoControle()
        {
            InitializeComponent();
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.LightBlue;
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Background = Brushes.Pink;
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Pink;
            btn2.Background = Brushes.LightBlue;
        }

        void Increase(object sender, RoutedEventArgs e)
        {
            Int32 Num = Convert.ToInt32(valueText.Text);

            valueText.Text = ((Num + 1).ToString());
        }

        void Decrease(object sender, RoutedEventArgs e)
        {
            Int32 Num = Convert.ToInt32(valueText.Text);

            valueText.Text = ((Num - 1).ToString());
        }

        void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            // Pour récupérer l'élément sélectionné
            ListBoxItem selectedItem = (ListBoxItem)listBox.SelectedItem;
            MessageBox.Show(selectedItem.Content.ToString());

            // Pour vérifier si la case est cochée
            bool isChecked = checkBox.IsChecked ?? false;
            MessageBox.Show(isChecked ? "Checked" : "Unchecked");

            // Pour vérifier quel RadioButton est sélectionné
            var selectedRadioButton = choicesStackPanel.Children.OfType<RadioButton>().FirstOrDefault(r => r.IsChecked == true);
            MessageBox.Show(selectedRadioButton?.Content.ToString());

            // Pour récupérer la valeur actuelle du slider
            double value = slider.Value;
            sliderValue.Text = value.ToString();

            // Pour changer la valeur de la ProgressBar
            if(double.TryParse(progressVal.Text, out double val)){
                progressBar.Value = (int)val;
            }

            // Pour récupérer la date sélectionnée
            DateTime? selectedDate = datePicker.SelectedDate;
            MessageBox.Show(selectedDate?.ToString() ?? "No date selected");
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        // Classe qui représente une collection de personnes
        public class PersonCollection : ObservableCollection<Person>
        {
        }
    }
}
