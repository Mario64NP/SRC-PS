using Aplikacija.Domen;
using Aplikacija.Repozitorijum;

namespace Aplikacija.SistemskeOperacije
{
    public abstract class SystemOperationBase
    {
		protected IDbRepository<IEntity> repository;
		public object Result { get; set; }

		public SystemOperationBase()
		{
			repository = new GenericDbRepository();
		}

        public void Execute()
        {
			try
			{
				ExecuteSpecificOperation();
				repository.Commit();
			}
			catch (System.Exception)
			{
				repository.Rollback();
				throw;
			}
			finally 
			{ 
				repository.Close(); 
			}
        }

		protected abstract void ExecuteSpecificOperation();
    }
}