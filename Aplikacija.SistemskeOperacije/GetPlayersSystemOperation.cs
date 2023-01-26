using Aplikacija.Domen;
using System.Linq;

namespace Aplikacija.SistemskeOperacije
{
    public class GetPlayersSystemOperation : SystemOperationBase
    {
        protected override void ExecuteSpecificOperation()
        {
            Result = repository.GetAll(new Igrac()).OfType<Igrac>().ToList();
        }
    }
}