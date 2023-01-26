using Aplikacija.Domen;

namespace Aplikacija.SistemskeOperacije
{
    public class DeleteResultSystemOperation : SystemOperationBase
    {
        private readonly Rezultat r;

        public DeleteResultSystemOperation(Rezultat r)
        {
            this.r = r;
        }
        protected override void ExecuteSpecificOperation()
        {
            repository.Delete(r);
            Result = true;
        }
    }
}