using Aplikacija.Domen;
using System.Linq;

namespace Aplikacija.SistemskeOperacije
{
    public class GetCategoriesSystemOperation : SystemOperationBase
    {
        protected override void ExecuteSpecificOperation()
        {
            Result = repository.GetAll(new Kategorija()).OfType<Kategorija>().ToList();
        }
    }
}