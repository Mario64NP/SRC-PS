using Aplikacija.Domen;
using System.Collections.Generic;

namespace Aplikacija.SistemskeOperacije
{
    public class UpdateGameSystemOperation : SystemOperationBase
    {
        private readonly VideoIgra v;
        private readonly List<Kategorija> k;

        public UpdateGameSystemOperation((VideoIgra, List<Kategorija>) v)
        {
            this.v = v.Item1;
            this.k = v.Item2;
        }

        protected override void ExecuteSpecificOperation()
        {
            repository.Update(v);

            repository.Delete(new KategorijaIgre() { VideoIgraID = v.VideoIgraID});

            foreach (var kat in k)
            {
                repository.Add(new KategorijaIgre(v.VideoIgraID, kat.KategorijaID));
            }

            Result = true;
        }
    }
}