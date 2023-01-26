using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aplikacija.Domen
{
    [Serializable]
    public class Kategorija : IEntity
    {
        public int KategorijaID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public string TableName => "Kategorija";

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
            return !(obj is null) && obj is Kategorija k && k.KategorijaID == KategorijaID;
        }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> categories = new List<IEntity>();
            while (reader.Read())
            {
                Kategorija k = new Kategorija
                {
                    KategorijaID = (int)reader[0],
                    Naziv = (string)reader[1],
                    Opis = (string)reader[2]
                };
                categories.Add(k);
            }
            return categories;
        }
    }
}