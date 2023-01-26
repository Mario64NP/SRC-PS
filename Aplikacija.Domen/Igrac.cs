using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aplikacija.Domen
{
    [Serializable]
    public class Igrac : IEntity
    {
        public int IgracID { get; set; }
        public string Nadimak { get; set; }
        public int Starost { get; set; }

        public string TableName => "Igrac";
        public string InsertValues => $"'{Nadimak}', {Starost}";
        public string UpdateValues => $"Nadimak = '{Nadimak}', Starost = {Starost}";
        public string RecordID => $"ID = {IgracID}";
        public string Join => string.Empty;

        public override string ToString()
        {
            return Nadimak;
        }

        public override bool Equals(object obj)
        {
            return !(obj is null) && obj is Igrac i && i.IgracID == IgracID;
        }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> players = new List<IEntity>();
            while (reader.Read())
            {
                Igrac i = new Igrac
                {
                    IgracID = (int)reader[0],
                    Nadimak = (string)reader[1],
                    Starost = (int)reader[2]
                };
                players.Add(i);
            }
            return players;
        }
    }
}