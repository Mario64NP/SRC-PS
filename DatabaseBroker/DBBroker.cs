using Aplikacija.Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabaseBroker
{
    public class DBBroker
    {
        private readonly SqlConnection _connection;

        public DBBroker()
        {
            _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;");
        }

        public List<Igrac> SearchPlayers(Igrac i)
        {
            List<Igrac> list = new List<Igrac>();
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();

            if (i == null)
                cmd.CommandText = "SELECT * FROM [SpeedrunCommunity].[dbo].[Igrac]";
            else
            {
                cmd.CommandText = "SELECT * FROM [SPeedrunCommunity].[dbo].[Igrac] WHERE ";
                if (!string.IsNullOrEmpty(i.Nadimak))
                {
                    cmd.CommandText += $"Nadimak LIKE @nadimak ";
                    cmd.Parameters.AddWithValue("@nadimak", $"%{i.Nadimak}%");
                }
                if (i.Starost != 0)
                {
                    cmd.CommandText += $"AND Starost = @starost";
                    cmd.Parameters.AddWithValue("@starost", i.Starost);
                }
            }
            cmd.CommandText = cmd.CommandText.Replace("WHERE AND", "WHERE");

            using (SqlDataReader reader = cmd.ExecuteReader())
                while(reader.Read())
                {
                    Igrac igrac = new Igrac();
                    igrac.IgracID = (int)reader["ID"];
                    igrac.Nadimak = (string)reader["Nadimak"];
                    igrac.Starost = (int)reader["Starost"];

                    list.Add(igrac);
                }
            _connection.Close();
            return list;
        }

        public bool SavePlayer(Igrac newPlayer, Igrac oldPlayer = null)
        {
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();
            if (oldPlayer == null)
            {
                cmd.CommandText = $"INSERT INTO [SpeedrunCommunity].[dbo].[Igrac] (Nadimak, Starost) VALUES (@nadimak, @starost)";
                cmd.Parameters.AddWithValue("@nadimak", newPlayer.Nadimak);
                cmd.Parameters.AddWithValue("@starost", newPlayer.Starost);
            }
            else
            {
                cmd.CommandText = $"UPDATE [SpeedrunCommunity].[dbo].[Igrac] SET Nadimak = @newnadimak, Starost = @newstarost WHERE ID = @oldid AND Nadimak = @oldnadimak AND Starost = @oldstarost";
                cmd.Parameters.AddWithValue("@newnadimak", newPlayer.Nadimak);
                cmd.Parameters.AddWithValue("@newstarost", newPlayer.Starost);
                cmd.Parameters.AddWithValue("@oldid", oldPlayer.IgracID);
                cmd.Parameters.AddWithValue("@oldnadimak", oldPlayer.Nadimak);
                cmd.Parameters.AddWithValue("@oldstarost", oldPlayer.Starost);

            }
            int j = cmd.ExecuteNonQuery();
            _connection.Close();
            return j > 0;
        }

        public bool DeletePlayer(Igrac i)
        {
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM [SpeedrunCommunity].[dbo].[Igrac] WHERE ID = @id AND Nadimak = @nadimak AND Starost = @starost";
            cmd.Parameters.AddWithValue("@id", i.IgracID);
            cmd.Parameters.AddWithValue("@nadimak", i.Nadimak);
            cmd.Parameters.AddWithValue("@starost", i.Starost);
            int j = cmd.ExecuteNonQuery();
            _connection.Close();
            return j > 0;
        }

        public List<VideoIgra> SearchVideoGames(VideoIgra v)
        { 
            List<VideoIgra> list = new List<VideoIgra>();
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();

            if (v == null)
                cmd.CommandText = "SELECT * FROM [SpeedrunCommunity].[dbo].[VideoIgra]";
            else
            {
                cmd.CommandText = "SELECT * FROM [SpeedrunCommunity].[dbo].[VideoIgra] WHERE ";
                if (!string.IsNullOrEmpty(v.Naziv))
                {
                    cmd.CommandText += $"Naziv LIKE @naziv ";
                    cmd.Parameters.AddWithValue("@naziv", $"%{v.Naziv}%");
                }
                if (!string.IsNullOrEmpty(v.Izdavac))
                {
                    cmd.CommandText += $"AND Izdavac LIKE @izdavac ";
                    cmd.Parameters.AddWithValue("@izdavac", $"%{v.Izdavac}%");
                }
                if (v.GodinaIzdanja != 0)
                {
                    cmd.CommandText += $"AND GodinaIzdanja = @godina ";
                    cmd.Parameters.AddWithValue("@godina", v.GodinaIzdanja);
                }
                if (v.Platforma != null)
                {
                    cmd.CommandText += $"AND PlatformaID = @platforma";
                    cmd.Parameters.AddWithValue("@platforma", v.Platforma.PlatformaID);
                }
            }
            cmd.CommandText = cmd.CommandText.Replace("WHERE AND", "WHERE");

            using (SqlDataReader reader = cmd.ExecuteReader())
                while(reader.Read())
                {
                    VideoIgra igra = new VideoIgra();
                    igra.VideoIgraID = (int)reader[0];
                    igra.Naziv = (string)reader[1];
                    igra.Izdavac = (string)reader[2];
                    igra.GodinaIzdanja = (int)reader[3];
                    igra.Platforma = new Platforma() { PlatformaID = (int)reader[4] };
                    list.Add(igra);
                }
            _connection.Close();
            return list;
        }

        public bool SaveVideoGame(VideoIgra newGame, VideoIgra oldGame = null)
        {
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();
            if (oldGame == null)
            {
                cmd.CommandText = $"INSERT INTO [SpeedrunCommunity].[dbo].[VideoIgra] (Naziv, Izdavac, GodinaIzdanja, PlatformaID) VALUES (@naziv, @izdavac, @godina, @platforma)";
                cmd.Parameters.AddWithValue("@naziv", newGame.Naziv);
                cmd.Parameters.AddWithValue("@izdavac", newGame.Izdavac);
                cmd.Parameters.AddWithValue("@godina", newGame.GodinaIzdanja);
                cmd.Parameters.AddWithValue("@platforma", newGame.Platforma.PlatformaID);
            }
            else
            {
                cmd.CommandText = $"UPDATE [SpeedrunCommunity].[dbo].[VideoIgra] SET Naziv = @newnaziv, Izdavac = @newizdavac, GodinaIzdanja = @newgodina, PlatformaID = @newplatforma " +
                                  $"WHERE ID = @oldid AND Naziv = @oldnaziv AND Izdavac = @oldizdavac AND GodinaIzdanja = @oldgodina AND PlatformaID = @oldplatforma";
                cmd.Parameters.AddWithValue("@newnaziv", newGame.Naziv);
                cmd.Parameters.AddWithValue("@newizdavac", newGame.Izdavac);
                cmd.Parameters.AddWithValue("@newgodina", newGame.GodinaIzdanja);
                cmd.Parameters.AddWithValue("@newplatforma", newGame.Platforma.PlatformaID);
                cmd.Parameters.AddWithValue("@oldid", oldGame.VideoIgraID);
                cmd.Parameters.AddWithValue("@oldnaziv", oldGame.Naziv);
                cmd.Parameters.AddWithValue("@oldizdavac", oldGame.Izdavac);
                cmd.Parameters.AddWithValue("@oldgodina", oldGame.GodinaIzdanja);
                cmd.Parameters.AddWithValue("@oldplatforma", oldGame.Platforma.PlatformaID);
            }
            int j = cmd.ExecuteNonQuery();
            _connection.Close();
            return j > 0;
        }

        public bool DeleteVideoGame(VideoIgra v)
        {
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM [SpeedrunCommunity].[dbo].[VideoIgra] WHERE ID = @id AND Naziv = @naziv AND Izdavac = @izdavac AND GodinaIzdanja = @godina AND PlatformaID = @platforma";
            cmd.Parameters.AddWithValue("@id", v.VideoIgraID);
            cmd.Parameters.AddWithValue("@naziv", v.Naziv);
            cmd.Parameters.AddWithValue("@izdavac", v.Izdavac);
            cmd.Parameters.AddWithValue("@godina", v.GodinaIzdanja);
            cmd.Parameters.AddWithValue("@platforma", v.Platforma.PlatformaID);
            int j = cmd.ExecuteNonQuery();
            _connection.Close();
            return j > 0;
        }


        public List<Rezultat> SearchResults(Rezultat r)
        {
            List<Rezultat> list = new List<Rezultat>();
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();

            if (r == null)
                cmd.CommandText = "SELECT * FROM [SpeedrunCommunity].[dbo].[Rezultat]";
            else
            {
                cmd.CommandText = "SELECT * FROM [SpeedrunCommunity].[dbo].[Rezultat] WHERE ";
                if (r.Igrac != null)
                {
                    cmd.CommandText += $"IgracID = @igrac ";
                    cmd.Parameters.AddWithValue("@igrac", r.Igrac.IgracID);
                }
                if (r.VideoIgra != null)
                {
                    cmd.CommandText += $"AND VideoIgraID = @videoigra ";
                    cmd.Parameters.AddWithValue("@videoigra", r.VideoIgra.VideoIgraID);
                }
                if (r.Kategorija != null)
                {
                    cmd.CommandText += $"AND KategorijaID = @kategorija ";
                    cmd.Parameters.AddWithValue("@kategorija", r.Kategorija.KategorijaID);
                }
                if (r.Vreme != 0)
                {
                    cmd.CommandText += $"AND Vreme = @vreme ";
                    cmd.Parameters.AddWithValue("@vreme", r.Vreme);
                }
                if (r.Datum != default(DateTime))
                {
                    cmd.CommandText += $"AND Datum = @datum";
                    cmd.Parameters.AddWithValue("@datum", r.Datum.ToString("yyyyMMdd HH:mm"));
                }
            }
            cmd.CommandText = cmd.CommandText.Replace("WHERE AND", "WHERE");

            using (SqlDataReader reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    Rezultat rezultat = new Rezultat();
                    rezultat.Igrac = new Igrac() { IgracID = (int)reader[0] };
                    rezultat.VideoIgra = new VideoIgra() { VideoIgraID = (int)reader[1] };
                    rezultat.Kategorija = new Kategorija() { KategorijaID = (int)reader[2] };
                    rezultat.Vreme = (int)reader[3];
                    rezultat.Datum = (DateTime)reader[4];
                    list.Add(rezultat);
                }
            _connection.Close();
            return list;
        }

        public bool SaveResult(Rezultat newResult, Rezultat oldResult = null)
        {
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();
            if (oldResult == null)
            {
                cmd.CommandText = $"INSERT INTO [SpeedrunCommunity].[dbo].[Rezultat] VALUES (@newigrac, @newvideoigra, @newkategorija, @newvreme, @newdatum)";
                cmd.Parameters.AddWithValue("@newigrac", newResult.Igrac.IgracID);
                cmd.Parameters.AddWithValue("@newvideoigra", newResult.VideoIgra.VideoIgraID);
                cmd.Parameters.AddWithValue("@newkategorija", newResult.Kategorija.KategorijaID);
                cmd.Parameters.AddWithValue("@newvreme", newResult.Vreme);
                cmd.Parameters.AddWithValue("@newdatum", newResult.Datum.ToString("yyyyMMdd HH:mm"));
            }
            else
            {
                cmd.CommandText = $"UPDATE [SpeedrunCommunity].[dbo].[Rezultat] SET IgracID = @newigrac, VideoIgraID = @newvideoigra, KategorijaID = @newkategorija, Vreme = @newvreme, Datum = @newdatum " +
                                  $"WHERE IgracID = @oldigrac AND VideoIgraID = @oldvideoigra AND KategorijaID = @oldkategorija AND Vreme = @oldvreme AND Datum = @olddatum";
                cmd.Parameters.AddWithValue("@newigrac", newResult.Igrac.IgracID);
                cmd.Parameters.AddWithValue("@newvideoigra", newResult.VideoIgra.VideoIgraID);
                cmd.Parameters.AddWithValue("@newkategorija", newResult.Kategorija.KategorijaID);
                cmd.Parameters.AddWithValue("@newvreme", newResult.Vreme);
                cmd.Parameters.AddWithValue("@newdatum", newResult.Datum.ToString("yyyyMMdd HH:mm"));
                cmd.Parameters.AddWithValue("@oldigrac", oldResult.Igrac.IgracID);
                cmd.Parameters.AddWithValue("@oldvideoigra", oldResult.VideoIgra.VideoIgraID);
                cmd.Parameters.AddWithValue("@oldkategorija", oldResult.Kategorija.KategorijaID);
                cmd.Parameters.AddWithValue("@oldvreme", oldResult.Vreme);
                cmd.Parameters.AddWithValue("@olddatum", oldResult.Datum.ToString("yyyyMMdd HH:mm"));
            }
            int j = cmd.ExecuteNonQuery();
            _connection.Close();
            return j > 0;
        }

        public bool DeleteResult(Rezultat r)
        {
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM [SpeedrunCommunity].[dbo].[Rezultat] WHERE IgracID = @igrac AND VideoIgraID = @videoigra AND KategorijaID = @kategorija AND Vreme = @vreme AND Datum = @datum";
            cmd.Parameters.AddWithValue("@igrac", r.Igrac.IgracID);
            cmd.Parameters.AddWithValue("@videoigra", r.VideoIgra.VideoIgraID);
            cmd.Parameters.AddWithValue("@kategorija", r.Kategorija.KategorijaID);
            cmd.Parameters.AddWithValue("@vreme", r.Vreme);
            cmd.Parameters.AddWithValue("@datum", r.Datum.ToString("yyyyMMdd HH:mm"));
            int j = cmd.ExecuteNonQuery();
            _connection.Close();
            return j > 0;
        }

        public List<Platforma> GetAllPlatforms()
        {
            List<Platforma> list = new List<Platforma>();
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM [SpeedrunCommunity].[dbo].[Platforma]";

            using (SqlDataReader reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    Platforma p = new Platforma();
                    p.PlatformaID = (int)reader["ID"];
                    p.Naziv = (string)reader["Naziv"];
                    list.Add(p);
                }
            _connection.Close();
            return list;
        }

        public List<Kategorija> GetAllCategories()
        {
            List<Kategorija> list = new List<Kategorija>();
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM [SpeedrunCommunity].[dbo].[Kategorija]";

            using (SqlDataReader reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    Kategorija k = new Kategorija();
                    k.KategorijaID = (int)reader["ID"];
                    k.Naziv = (string)reader["Naziv"];
                    k.Opis = (string)reader["Opis"];
                    list.Add(k);
                }
            _connection.Close();
            return list;
        }

        public List<KategorijaIgre> GetAllGameCategories()
        {
            List<KategorijaIgre> list = new List<KategorijaIgre>();
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM [SpeedrunCommunity].[dbo].[KategorijaIgre]";

            using (SqlDataReader reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    KategorijaIgre k = new KategorijaIgre();
                    k.VideoIgraID = (int)reader["VideoIgraID"];
                    k.KategorijaID = (int)reader["KategorijaID"];
                    list.Add(k);
                }
            _connection.Close();
            return list;
        }

        public int GetLastAddedID<T>()
        {
            int lastAddedID = -1;

            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();
            if (typeof(T) == typeof(Igrac))
                cmd.CommandText = "SELECT MAX(ID) FROM [SpeedrunCommunity].[dbo].[Igrac]";
            else if (typeof(T) == typeof(VideoIgra))
                cmd.CommandText = "SELECT MAX(ID) FROM [SpeedrunCommunity].[dbo].[VideoIgra]";
            else
                throw new Exception("Unsupported type " + typeof(T).Name);
            using (SqlDataReader reader = cmd.ExecuteReader())
                while (reader.Read())
                    lastAddedID = (int)reader[0];
            _connection.Close();
            return lastAddedID;
        }
    }
}