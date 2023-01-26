using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aplikacija.Domen
{
    [Serializable]
    public class Platforma : IEntity
    {
        public int PlatformaID { get; set; }
        public string Naziv { get; set; }

        public string TableName => "Platforma";
        public string InsertValues => string.Empty;

        public string UpdateValues => string.Empty;

        public string RecordID => string.Empty;

        public string Join => string.Empty;

        public override string ToString()
        {
            return Naziv;
        }

        public override bool Equals(object obj)
        {
            return !(obj is null) && obj is Platforma p && p.PlatformaID == PlatformaID;
        }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> platforms = new List<IEntity>();
            while (reader.Read())
            {
                Platforma p = new Platforma
                {
                    PlatformaID = (int)reader[0],
                    Naziv       = (string)reader[1]
                };
                platforms.Add(p);
            }
            return platforms;
        }
    }
}