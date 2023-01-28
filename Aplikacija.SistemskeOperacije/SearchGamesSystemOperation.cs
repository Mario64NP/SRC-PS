using Aplikacija.Domen;
using System.Collections.Generic;
using System.Linq;

namespace Aplikacija.SistemskeOperacije
{
    public class SearchGamesSystemOperation : SystemOperationBase
    {
        private readonly string criterion;

        public SearchGamesSystemOperation(string criterion) 
        {
            this.criterion = criterion.ToLower();
        }

        protected override void ExecuteSpecificOperation()
        {
            List<VideoIgra> list = repository.GetAll(new VideoIgra()).OfType<VideoIgra>().ToList();

            if (string.IsNullOrEmpty(criterion))
            {
                Result = list;
                return;
            }

            Result = list.Where(v =>
                v.Naziv.ToLower().Contains(criterion) ||
                v.Izdavac.ToLower().Contains(criterion) ||
                (int.TryParse(criterion, out int a) && v.GodinaIzdanja == a) ||
                v.Platforma.Naziv.ToLower().Contains(criterion)).ToList();
        }
    }
}