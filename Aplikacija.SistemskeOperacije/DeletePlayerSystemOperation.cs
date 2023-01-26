using Aplikacija.Domen;

namespace Aplikacija.SistemskeOperacije
{
    public class DeletePlayerSystemOperation : SystemOperationBase
    {
        private readonly Igrac i;

        public DeletePlayerSystemOperation(Igrac i)
        {
            this.i = i;
        }
        protected override void ExecuteSpecificOperation()
        {
            repository.Delete(i);
            Result = true;
        }
    }
}