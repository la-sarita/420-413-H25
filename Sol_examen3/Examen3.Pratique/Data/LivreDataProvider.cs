using Examen2.Pratique.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Pratique.Data
{
    public interface ILivreDataProvider 
    {
        public Task<IEnumerable<Livre>?> GetAllAsync();
    }

    public class LivreDataProvider : ILivreDataProvider
    {
        public async Task<IEnumerable<Livre>?> GetAllAsync()
        {
            await Task.Delay(1000);

            var livres = new List<Livre>
            {
                new Livre { Titre = "Clean Code", Auteur = "Robert C. Martin", Isbn = "978-0132350884", Annee = 2008, EstDisponible = true },
                new Livre { Titre = "Clean Architecture", Auteur = "Robert C. Martin", Isbn = "978-0134494166", Annee = 2017, EstDisponible = false },
                new Livre { Titre = "The Pragmatic Programmer", Auteur = "Andrew Hunt", Isbn = "978-0135957059", Annee = 1999, EstDisponible = true },
                new Livre { Titre = "Eloquent JavaScript", Auteur = "Marijn Haverbeke", Isbn = "978-1593279509", Annee = 2018, EstDisponible = true },
                new Livre { Titre = "The Art of Computer Programming", Auteur = "Donald Knuth", Isbn = "978-0201896830", Annee = 1968, EstDisponible = false },
                new Livre { Titre = "C# in Depth", Auteur = "Jon Skeet", Isbn = "978-1617294532", Annee = 2019, EstDisponible = true },
                new Livre { Titre = "Design Patterns", Auteur = "Erich Gamma", Isbn = "978-0201633610", Annee = 1994, EstDisponible = true },
                new Livre { Titre = "Refactoring", Auteur = "Martin Fowler", Isbn = "978-0201485677", Annee = 1999, EstDisponible = false },
                new Livre { Titre = "Introduction to Algorithms", Auteur = "Thomas H. Cormen", Isbn = "978-0262033848", Annee = 2009, EstDisponible = true },
                new Livre { Titre = "Domain-Driven Design", Auteur = "Eric Evans", Isbn = "978-0321125217", Annee = 2003, EstDisponible = true }
            };

            return livres;
        }
    }
}
