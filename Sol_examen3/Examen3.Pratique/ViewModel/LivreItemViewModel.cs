using Examen2.Pratique.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Pratique.ViewModel
{
    public class LivreItemViewModel : ViewModelBase
    {
        private readonly Livre _model;
        private string _titre;
        private string _auteur;
        private string _isbn;
        private int _annee;
        private bool _estDisponible;

        public LivreItemViewModel(Livre livre)
        {
            _model = livre;
        }

        public string Titre
        {
            get { return _model.Titre; }
            set
            {
                _model.Titre = value;
                OnPropertyChanged();
            }
        }

        public string Auteur
        {
            get { return _model.Auteur; }
            set
            {
                _model.Auteur = value;
                OnPropertyChanged();
            }
        }
        public string Isbn
        {
            get { return _model.Isbn; }
            set
            {
                _model.Isbn = value;
                OnPropertyChanged();
            }
        }
        public int Annee
        {
            get { return _model.Annee; }
            set
            {
                _model.Annee = value;
                OnPropertyChanged();
            }
        }

        public bool EstDisponible
        {
            get { return _model.EstDisponible; }
            set
            {
                _model.EstDisponible = value;
                OnPropertyChanged();
            }
        } 
    }
}
