using Aplikacija.Domen;

namespace Aplikacija.SistemskeOperacije
{
    public class UpdateGameSystemOperation : SystemOperationBase
    {
        private readonly VideoIgra v;

        public UpdateGameSystemOperation(VideoIgra v)
        {
            this.v = v;
        }

        protected override void ExecuteSpecificOperation()
        {
            Result = repository.Update(v);
        }
    }
}