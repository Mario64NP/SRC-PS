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
            if (i != null)
                Result = repository.Delete(i);
            else
                Result = false;
        }
    }
}