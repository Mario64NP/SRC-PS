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
            if (!string.IsNullOrEmpty(i.Nadimak) && i.Starost > 12)
                Result = repository.Add(i);
            else
                Result = false;
        }
    }
}