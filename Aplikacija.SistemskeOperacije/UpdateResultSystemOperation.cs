using Aplikacija.Domen;

namespace Aplikacija.SistemskeOperacije
{
    public class UpdateResultSystemOperation : SystemOperationBase
    {
        private readonly Rezultat r;

        public UpdateResultSystemOperation(Rezultat r)
        {
            this.r = r;
        }

        protected override void ExecuteSpecificOperation()
        {
            Result = repository.Update(r);
        }
    }
}