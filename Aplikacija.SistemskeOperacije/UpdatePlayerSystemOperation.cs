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
            if (!string.IsNullOrEmpty(i.Nadimak) && i.Starost > 12)
                Result = repository.Update(i);
            else
                Result = false;
        }
    }
}