using Aplikacija.Domen;

namespace Aplikacija.SistemskeOperacije
{
    public class LoginSystemOperation : SystemOperationBase
    {
        private readonly User user;
        public LoginSystemOperation(User user)
        {
            this.user = user;
        }

        protected override void ExecuteSpecificOperation()
        {
            Result = repository.GetAll(new User()).Contains(user);
        }
    }
}