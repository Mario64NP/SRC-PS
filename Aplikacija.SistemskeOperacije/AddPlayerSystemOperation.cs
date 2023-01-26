using Aplikacija.Domen;

namespace Aplikacija.SistemskeOperacije
{
    public class AddPlayerSystemOperation : SystemOperationBase
    {
        private readonly Igrac i;

        public AddPlayerSystemOperation(Igrac i)
        {
            this.i = i;
        }

        protected override void ExecuteSpecificOperation()
        {
            Result = repository.Add(i);
        }
    }
}