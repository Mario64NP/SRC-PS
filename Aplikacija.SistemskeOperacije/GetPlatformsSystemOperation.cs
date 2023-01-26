using Aplikacija.Domen;
using System.Linq;

namespace Aplikacija.SistemskeOperacije
{
    public class GetPlatformsSystemOperation : SystemOperationBase
    {
        protected override void ExecuteSpecificOperation()
        {
            Result = repository.GetAll(new Platforma()).OfType<Platforma>().ToList();
        }
    }
}