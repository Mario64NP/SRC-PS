using Aplikacija.Domen;

namespace Aplikacija.SistemskeOperacije
{
    public class UpdatePlayerSystemOperation : SystemOperationBase
    {
        private readonly Igrac i;

        public UpdatePlayerSystemOperation(Igrac i)
        {
            this.i = i;
        }

        protected override void ExecuteSpecificOperation()
        {
            Result = repository.Update(i);
        }
    }
}