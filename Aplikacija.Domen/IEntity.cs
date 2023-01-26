using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aplikacija.Domen
{
    public interface IEntity
    {
        string TableName { get; }
        string InsertValues { get; }
        string UpdateValues { get; }
        string RecordID { get; }
        string Join { get; }
        List<IEntity> GetList(SqlDataReader reader);
    }
}