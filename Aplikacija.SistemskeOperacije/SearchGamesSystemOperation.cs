using Aplikacija.Domen;
using System.Collections.Generic;
using System.Linq;

namespace Aplikacija.SistemskeOperacije
{
    public class SearchGamesSystemOperation : SystemOperationBase
    {
        private readonly VideoIgra v;

        public SearchGamesSystemOperation(VideoIgra v) 
        {
            this.v = v;
        }

        protected override void ExecuteSpecificOperation()
        {
            List<VideoIgra> list = repository.GetAll(v).OfType<VideoIgra>().ToList();

            Result = list.Where(vi =>
                vi.Naziv.Contains(string.IsNullOrEmpty(v.Naziv) ? vi.Naziv : v.Naziv) &&
                vi.Izdavac.Contains(string.IsNullOrEmpty(v.Izdavac) ? vi.Izdavac : v.Izdavac) &&
                vi.GodinaIzdanja == ((v.GodinaIzdanja == 0) ? vi.GodinaIzdanja : v.GodinaIzdanja) &&
                vi.Platforma.Equals(v.Platforma is null ? vi.Platforma : v.Platforma)).ToList();
        }
    }
}