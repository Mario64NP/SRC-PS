using Aplikacija.Domen;
using System.Collections.Generic;

namespace Aplikacija.SistemskeOperacije
{
    public class AddGameSystemOperation : SystemOperationBase
    {
        private readonly VideoIgra v;
        private readonly List<Kategorija> k;

        public AddGameSystemOperation((VideoIgra, List<Kategorija>) v)
        {
            this.v = v.Item1;
            this.k = v.Item2;
        }

        protected override void ExecuteSpecificOperation()
        {
            repository.Add(v, out int id);
            foreach (var kat in k)
            {
                repository.Add(new KategorijaIgre(id, kat.KategorijaID));
            }
            Result = true;
        }
    }
}