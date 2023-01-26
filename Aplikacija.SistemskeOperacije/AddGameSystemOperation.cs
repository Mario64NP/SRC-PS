using Aplikacija.Domen;

namespace Aplikacija.SistemskeOperacije
{
    public class AddGameSystemOperation : SystemOperationBase
    {
        private readonly VideoIgra v;

        public AddGameSystemOperation(VideoIgra v)
        {
            this.v = v;
        }

        protected override void ExecuteSpecificOperation()
        {
            repository.Add(v);
            Result = true;
        }
    }
}