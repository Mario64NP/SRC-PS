using Aplikacija.Domen;

namespace Aplikacija.SistemskeOperacije
{
    public class AddResultSystemOperation : SystemOperationBase
    {
        private readonly Rezultat r;

        public AddResultSystemOperation(Rezultat r)
        {
            this.r = r;
        }

        protected override void ExecuteSpecificOperation()
        {
            repository.Add(r);
            Result = true;
        }
    }
}