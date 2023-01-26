using Aplikacija.Domen;
using System.Linq;

namespace Aplikacija.SistemskeOperacije
{
    public class GetGamesSystemOperation : SystemOperationBase
    {
        protected override void ExecuteSpecificOperation()
        {
            Result = repository.GetAll(new VideoIgra()).OfType<VideoIgra>().ToList();
        }
    }
}