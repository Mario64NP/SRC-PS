using Aplikacija.Domen;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aplikacija.Repozitorijum
{
    public class GenericDbRepository : IDbRepository<IEntity>
    {
        public bool Add(IEntity entity)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection()
                .CreateCommand($"INSERT INTO {entity.TableName} VALUES ({entity.InsertValues})");
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Update(IEntity entity)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection()
                .CreateCommand($"UPDATE {entity.TableName} SET {entity.UpdateValues} WHERE {entity.RecordID}");
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(IEntity entity)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection()
                .CreateCommand($"DELETE FROM {entity.TableName} WHERE {entity.RecordID}");
            return cmd.ExecuteNonQuery() > 0;
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            List<IEntity> result;

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection()
                .CreateCommand($"SELECT * FROM {entity.TableName} {entity.Join}");
            SqlDataReader reader = cmd.ExecuteReader();

            result = entity.GetList(reader);
            reader.Close();
            
            return result;
        }


        public void Commit()
        {
            DbConnectionFactory.Instance.GetDbConnection().Commit();
        }

        public void Rollback()
        {
            DbConnectionFactory.Instance.GetDbConnection().Rollback();
        }

        public void Close()
        {
            DbConnectionFactory.Instance.GetDbConnection().Close();
        }
    }
}