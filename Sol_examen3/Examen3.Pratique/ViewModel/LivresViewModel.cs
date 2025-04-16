using Examen2.Pratique.Data;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Examen2.Pratique.ViewModel
{
    public class LivresViewModel : ViewModelBase
    {
        private readonly ILivreDataProvider _livreDataProvider;
        private string _auteurRecherche;

        public ObservableCollection<LivreItemViewModel> Livres { get; private set; } = new ();
        public ObservableCollection<LivreItemViewModel> LivresRecherches { get; private set; } = new ();

        public ICommand RechercherTrierLivreCommand { get; set; }
        public string AuteurRecherche {
            get => _auteurRecherche;
            set
            {
                _auteurRecherche = value;
                OnPropertyChanged();
            }
        }
        public LivresViewModel(ILivreDataProvider livreDataProvider)
        {
            _livreDataProvider = livreDataProvider;
            RechercherTrierLivreCommand = new RelayCommand(RechercherTrierLivre);
        }

        public async Task LoadAsync() 
        { 
            var livres = await _livreDataProvider.GetAllAsync();

            Livres.Clear();

            if (livres != null) 
            { 
                foreach (var livre in livres) 
                { 
                    Livres.Add(new LivreItemViewModel(livre)); 
                } 
            } 
        }

        public void RechercherTrierLivre(object? parameter)
        {
            var resultatRecherche = Livres
                .Where(livre => !string.IsNullOrWhiteSpace(AuteurRecherche) && 
                                livre.Auteur.Contains(AuteurRecherche))
                .OrderBy(livre => livre.Annee)
                .ToList();
            LivresRecherches.Clear();
            
            foreach (var livre in resultatRecherche)
            {
                LivresRecherches.Add(livre);
            }
        }
    }
}
