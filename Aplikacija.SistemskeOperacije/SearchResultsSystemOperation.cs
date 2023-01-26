using Aplikacija.Domen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplikacija.SistemskeOperacije
{
    public class SearchResultsSystemOperation : SystemOperationBase
    {
        private readonly Rezultat r;

        public SearchResultsSystemOperation(Rezultat r)
        {
            this.r = r;
        }

        protected override void ExecuteSpecificOperation()
        {
            List<Rezultat> list = repository.GetAll(r).OfType<Rezultat>().ToList();

            Result = list.Where(re =>
                re.Igrac.Equals(r.Igrac is null ? re.Igrac : r.Igrac) &&
                re.VideoIgra.Equals(r.VideoIgra is null ? re.VideoIgra : r.VideoIgra) &&
                re.Kategorija.Equals(r.Kategorija is null ? re.Kategorija : r.Kategorija) &&
                re.Vreme == ((r.Vreme == 0) ? re.Vreme : r.Vreme) &&
                re.Datum == ((r.Datum == DateTime.MinValue) ? re.Datum : r.Datum)).ToList();
        }
    }
}