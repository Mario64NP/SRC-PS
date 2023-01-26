using Aplikacija.Domen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplikacija.Kontroler
{
    public class Kontroler
    {
        private static Kontroler instance = null;
        public static Kontroler Instance { get
            {
                if (instance == null)
                    instance = new Kontroler();
                return instance;
            }
        }

        private readonly DBBroker broker = new DBBroker();
        public List<Igrac> Igraci { get; }
        public List<VideoIgra> VideoIgre { get; }
        public List<Rezultat> Rezultati { get; }
        public List<Platforma> Platforme { get; }
        public List<Kategorija> Kategorije { get; }
        public List<KategorijaIgre> KategorijeZaIgre { get; }

        private Kontroler()
        {
            Igraci           = broker.SearchPlayers(null);
            VideoIgre        = broker.SearchVideoGames(null);
            Rezultati        = broker.SearchResults(null);
            Platforme        = broker.GetAllPlatforms();
            Kategorije       = broker.GetAllCategories();
            KategorijeZaIgre = broker.GetAllGameCategories();

            foreach (VideoIgra v in VideoIgre)
                v.Platforma = GetPlatformByID(v.Platforma.PlatformaID);
            
            foreach (Rezultat r in Rezultati)
            {
                r.Igrac = GetPlayerByID(r.Igrac.IgracID);
                r.VideoIgra = GetVideoGameByID(r.VideoIgra.VideoIgraID);
                r.Kategorija = GetCategoryByID(r.Kategorija.KategorijaID);
            }
        }

        public bool SavePlayer(Igrac newPlayer, Igrac oldPlayer = null)
        {
            if (broker.SavePlayer(newPlayer, oldPlayer))
            {
                if (oldPlayer == null)
                {
                    newPlayer.IgracID = broker.GetLastAddedID<Igrac>();
                    Igraci.Add(newPlayer);
                }
                else
                    foreach (Igrac i in Igraci)
                        if (i.Nadimak == oldPlayer.Nadimak && i.Starost == oldPlayer.Starost)
                        {
                            i.Nadimak = newPlayer.Nadimak;
                            i.Starost = newPlayer.Starost;
                        }
                return true;
            }
            return false;
        }

        public List<Igrac> SearchPlayers(Igrac i)
        {
            if (i == null || i.Nadimak == null && i.Starost == 0)
                return broker.SearchPlayers(null);
            return broker.SearchPlayers(i);
        }

        public bool DeletePlayer(Igrac i)
        {
            if (broker.DeletePlayer(i))
                return Igraci.Remove(i);
            return false;
        }

        public Igrac GetPlayerByID(int id)
        {
            return Igraci.Single(i => i.IgracID == id);
        }

        public bool SaveVideoGame(VideoIgra newGame, VideoIgra oldGame = null)
        {
            if (broker.SaveVideoGame(newGame, oldGame))
            {
                if (oldGame == null)
                {
                    newGame.VideoIgraID = broker.GetLastAddedID<VideoIgra>();
                    VideoIgre.Add(newGame);
                }
                else
                    foreach (VideoIgra v in VideoIgre)
                        if (v.Naziv == oldGame.Naziv && v.Izdavac == oldGame.Izdavac && 
                            v.GodinaIzdanja == oldGame.GodinaIzdanja && v.Platforma.PlatformaID == oldGame.Platforma.PlatformaID)
                        {
                            v.Naziv         = newGame.Naziv;
                            v.Izdavac       = newGame.Izdavac;
                            v.GodinaIzdanja = newGame.GodinaIzdanja;
                            v.Platforma     = newGame.Platforma;
                        }
                return true;
            }
            return false;
        }

        public List<VideoIgra> SearchVideoGames(VideoIgra v)
        {
            List<VideoIgra> list;
            if (v == null || v.Naziv == null && v.Izdavac == null && v.GodinaIzdanja == 0 && v.Platforma == null)
                list = broker.SearchVideoGames(null);
            else
                list = broker.SearchVideoGames(v);

            foreach (VideoIgra videoIgra in list)
            {
                videoIgra.Platforma = GetPlatformByID(videoIgra.Platforma.PlatformaID);
            }

            return list;
        }

        public bool DeleteVideoGame(VideoIgra v)
        {
            if (broker.DeleteVideoGame(v))
                return VideoIgre.Remove(v);
            return false;
        }

        public VideoIgra GetVideoGameByID(int id)
        {
            return VideoIgre.Single(v => v.VideoIgraID == id);
        }

        public bool SaveResult(Rezultat newResult, Rezultat oldResult = null)
        {
            if (broker.SaveResult(newResult, oldResult))
            {
                if (oldResult == null)
                    Rezultati.Add(newResult);
                else
                    foreach (Rezultat r in Rezultati)
                        if (r.Igrac.IgracID == oldResult.Igrac.IgracID && r.VideoIgra.VideoIgraID == oldResult.VideoIgra.VideoIgraID &&
                            r.Kategorija.KategorijaID == oldResult.Kategorija.KategorijaID && r.Vreme == oldResult.Vreme && r.Datum == oldResult.Datum)
                        {
                            r.Igrac      = newResult.Igrac;
                            r.VideoIgra  = newResult.VideoIgra;
                            r.Kategorija = newResult.Kategorija;
                            r.Vreme      = newResult.Vreme;
                            r.Datum      = newResult.Datum;
                        }
                return true;
            }
            return false;
        }

        public List<Rezultat> SearchResults(Rezultat r)
        {
            List<Rezultat> list;
            if (r == null || r.Igrac == null && r.VideoIgra == null && r.Kategorija == null && r.Vreme == 0 && r.Datum  == default(DateTime))
                list = broker.SearchResults(null);
            else
                list = broker.SearchResults(r);

            foreach (Rezultat result in list)
            {
                result.Igrac      = GetPlayerByID(result.Igrac.IgracID);
                result.VideoIgra  = GetVideoGameByID(result.VideoIgra.VideoIgraID);
                result.Kategorija = GetCategoryByID(result.Kategorija.KategorijaID);
            }

            return list;
        }

        public bool DeleteResult(Rezultat r)
        {
            if (broker.DeleteResult(r))
                return Rezultati.Remove(r);
            return false;
        }

        public Platforma GetPlatformByID(int id)
        {
            return Platforme.Single(p => p.PlatformaID == id);
        }

        public Kategorija GetCategoryByID(int id)
        {
            return Kategorije.Single(k => k.KategorijaID == id);
        }
    }
}