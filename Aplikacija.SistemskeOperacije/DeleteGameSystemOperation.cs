using Aplikacija.Domen;

namespace Aplikacija.SistemskeOperacije
{
    public class DeleteGameSystemOperation : SystemOperationBase
    {
        private readonly VideoIgra v;

        public DeleteGameSystemOperation(VideoIgra v)
        {
            this.v = v;
        }
        protected override void ExecuteSpecificOperation()
        {
            repository.Delete(v);
            Result = true;
        }
    }
}