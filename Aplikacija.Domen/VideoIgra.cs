using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aplikacija.Domen
{
    [Serializable]
    public class VideoIgra : IEntity
    {
        public int VideoIgraID { get; set; }
        public string Naziv { get; set; }
        public string Izdavac { get; set; }
        public int GodinaIzdanja { get; set; }
        public Platforma Platforma { get; set; }

        public string TableName => "VideoIgra";
        public string InsertValues => $"'{Naziv}', '{Izdavac}', {GodinaIzdanja}, {Platforma.PlatformaID}";
        public string UpdateValues => $"Naziv = '{Naziv}', Izdavac = '{Izdavac}', GodinaIzdanja = {GodinaIzdanja}, PlatformaID = {Platforma.PlatformaID}";
        public string RecordID => $"ID = {VideoIgraID}";
        public string Join => "INNER JOIN Platforma ON (VideoIgra.PlatformaID = Platforma.ID)";

        public override string ToString()
        {
            return Naziv;
        }

        public override bool Equals(object obj)
        {
            return !(obj is null) && obj is VideoIgra v && v.VideoIgraID == VideoIgraID;
        }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> games = new List<IEntity>();
            while (reader.Read())
            {
                VideoIgra v = new VideoIgra();
                v.VideoIgraID = (int)reader[0];
                v.Naziv = (string)reader[1];
                v.Izdavac = (string)reader[2];
                v.GodinaIzdanja = (int)reader[3];
                v.Platforma = new Platforma();
                v.Platforma.PlatformaID = (int)reader[4];
                v.Platforma.Naziv = (string)reader[6];
                games.Add(v);
            }
            return games;
        }
    }
}