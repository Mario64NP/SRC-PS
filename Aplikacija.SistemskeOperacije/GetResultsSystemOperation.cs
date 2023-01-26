using Aplikacija.Domen;
using System.Linq;

namespace Aplikacija.SistemskeOperacije
{
    public class GetResultsSystemOperation : SystemOperationBase
    {
        protected override void ExecuteSpecificOperation()
        {
            Result = repository.GetAll(new Rezultat()).OfType<Rezultat>().ToList();
        }
    }
}