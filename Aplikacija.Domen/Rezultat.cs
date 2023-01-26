using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aplikacija.Domen
{
    [Serializable]
    public class Rezultat : IEntity
    {
        public Igrac Igrac { get; set; }
        public VideoIgra VideoIgra { get; set; }
        public Kategorija Kategorija { get; set; }
        public int Vreme { get; set; }
        public DateTime Datum { get; set; }

        public string TableName => "Rezultat";
        public string InsertValues => $"{Igrac.IgracID}, {VideoIgra.VideoIgraID}, {Kategorija.KategorijaID}, {Vreme}, '{Datum.ToString("yyyyMMdd HH:mm")}'";
        public string UpdateValues => $"Vreme = {Vreme}, Datum = '{Datum.ToString("yyyyMMdd HH:mm")}'";
        public string RecordID => $"IgracID = {Igrac.IgracID} AND VideoIgraID = {VideoIgra.VideoIgraID} AND KategorijaID = {Kategorija.KategorijaID}";
        public string Join => "INNER JOIN Igrac ON (Rezultat.IgracID = Igrac.ID) INNER JOIN VideoIgra ON (Rezultat.VideoIgraID = VideoIgra.ID) INNER JOIN Kategorija ON (Rezultat.KategorijaID = Kategorija.ID)";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> results = new List<IEntity>();
            while (reader.Read())
            {
                Rezultat r = new Rezultat();
                r.Igrac = new Igrac();
                r.VideoIgra = new VideoIgra();
                r.Kategorija = new Kategorija();

                r.Vreme = (int)reader[3];
                r.Datum = (DateTime)reader[4];

                r.Igrac.IgracID = (int)reader[5];
                r.Igrac.Nadimak = (string)reader[6];
                r.Igrac.Starost = (int)reader[7];

                r.VideoIgra.VideoIgraID = (int)reader[8];
                r.VideoIgra.Naziv = (string)reader[9];
                r.VideoIgra.Izdavac = (string)reader[10];
                r.VideoIgra.GodinaIzdanja = (int)reader[11];

                r.Kategorija.KategorijaID = (int)reader[13];
                r.Kategorija.Naziv = (string)reader[14];
                r.Kategorija.Opis = (string)reader[15];


                results.Add(r);
            }
            return results;
        }
    }
}