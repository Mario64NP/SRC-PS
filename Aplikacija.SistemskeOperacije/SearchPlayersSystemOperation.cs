using Aplikacija.Domen;
using System.Collections.Generic;
using System.Linq;

namespace Aplikacija.SistemskeOperacije
{
    public class SearchPlayersSystemOperation : SystemOperationBase
    {
        private readonly Igrac i;

        public SearchPlayersSystemOperation(Igrac i)
        {
            this.i = i;
        }

        protected override void ExecuteSpecificOperation()
        {
            List<Igrac> list = repository.GetAll(i).OfType<Igrac>().ToList();

            Result = list.Where(ig => 
                ig.Nadimak.Contains(string.IsNullOrEmpty(i.Nadimak) ? ig.Nadimak : i.Nadimak) &&
                ig.Starost == ((i.Starost == 0) ? ig.Starost : i.Starost)).ToList();
        }
    }
}