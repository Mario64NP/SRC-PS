using System.Collections.Generic;

namespace Aplikacija.Repozitorijum
{
    public interface IRepository<TEntity> where TEntity : class
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        List<TEntity> GetAll(TEntity entity);
    }
}