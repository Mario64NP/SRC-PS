namespace Aplikacija.Repozitorijum
{
    public interface IDbRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        void Commit();
        void Rollback();
        void Close();
    }
}