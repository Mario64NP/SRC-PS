using Aplikacija.Domen;
using System.Collections.Generic;
using System.Linq;

namespace Aplikacija.SistemskeOperacije
{
    public class SearchResultsSystemOperation : SystemOperationBase
    {
        private readonly string criterion;

        public SearchResultsSystemOperation(string criterion)
        {
            this.criterion = criterion.ToLower();
        }

        protected override void ExecuteSpecificOperation()
        {
            List<Rezultat> list = repository.GetAll(new Rezultat()).OfType<Rezultat>().ToList();

            if (string.IsNullOrEmpty(criterion))
            {
                Result = list;
                return;
            }

            Result = list.Where(r =>
                r.Igrac.Nadimak.ToLower().Contains(criterion) ||
                r.VideoIgra.Naziv.ToLower().Contains(criterion) ||
                r.Kategorija.Naziv.ToLower().Contains(criterion) ||
                (int.TryParse(criterion, out int a) && r.Vreme == a)).ToList();
        }
    }
}