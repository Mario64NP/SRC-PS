using Aplikacija.Domen;
using System.Collections.Generic;
using System.Linq;

namespace Aplikacija.SistemskeOperacije
{
    public class SearchPlayersSystemOperation : SystemOperationBase
    {
        private readonly string criterion;

        public SearchPlayersSystemOperation(string criterion)
        {
            this.criterion = criterion.ToLower();
        }

        protected override void ExecuteSpecificOperation()
        {
            List<Igrac> list = repository.GetAll(new Igrac()).OfType<Igrac>().ToList();

            if (string.IsNullOrEmpty(criterion))
            {
                Result = list;
                return;
            }

            Result = list.Where(i => 
                i.Nadimak.ToLower().Contains(criterion) ||
                (int.TryParse(criterion, out int a) && i.Starost == a)).ToList();
        }
    }
}