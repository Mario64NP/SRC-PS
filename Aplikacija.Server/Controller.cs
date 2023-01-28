using Aplikacija.Domen;
using Aplikacija.SistemskeOperacije;
using System.Collections.Generic;

namespace Aplikacija.Server
{
    internal class Controller
    {
        private static Controller _instance;
        public static Controller Instance
        {
            get
            {
                if (_instance is null)
                    _instance = new Controller();

                return _instance;
            }
        }

        private Controller()
        {

        }

        public bool Login(User user)
        {
            LoginSystemOperation so = new LoginSystemOperation(user);
            so.Execute();
            return (bool)so.Result;
        }

        public List<Igrac> GetPlayers()
        {
            GetPlayersSystemOperation so = new GetPlayersSystemOperation();
            so.Execute();
            return (List<Igrac>)so.Result;
        }

        public List<Igrac> SearchPlayers(string criterion)
        {
            SearchPlayersSystemOperation so = new SearchPlayersSystemOperation(criterion);
            so.Execute();
            return (List<Igrac>)so.Result;
        }

        public bool AddPlayer(Igrac i)
        {
            AddPlayerSystemOperation so = new AddPlayerSystemOperation(i);
            so.Execute();
            return (bool)so.Result;
        }

        public bool UpdatePlayer(Igrac i)
        {
            UpdatePlayerSystemOperation so = new UpdatePlayerSystemOperation(i);
            so.Execute();
            return (bool)so.Result;
        }

        public bool DeletePlayer(Igrac i)
        {
            DeletePlayerSystemOperation so = new DeletePlayerSystemOperation(i);
            so.Execute();
            return (bool)so.Result;
        }

        public List<VideoIgra> GetGames()
        {
            GetGamesSystemOperation so = new GetGamesSystemOperation();
            so.Execute();
            return (List<VideoIgra>)so.Result;
        }

        public List<VideoIgra> SearchGames(string criterion)
        {
            SearchGamesSystemOperation so = new SearchGamesSystemOperation(criterion);
            so.Execute();
            return (List<VideoIgra>)so.Result;
        }

        public bool AddGame((VideoIgra, List<Kategorija>) v)
        {
            AddGameSystemOperation so = new AddGameSystemOperation(v);
            so.Execute();
            return (bool)so.Result;
        }

        public bool UpdateGame((VideoIgra, List<Kategorija>) v)
        {
            UpdateGameSystemOperation so = new UpdateGameSystemOperation(v);
            so.Execute();
            return (bool)so.Result;
        }

        public bool DeleteGame(VideoIgra v)
        {
            DeleteGameSystemOperation so = new DeleteGameSystemOperation(v);
            so.Execute();
            return (bool)so.Result;
        }

        public List<Rezultat> GetResults()
        {
            GetResultsSystemOperation so = new GetResultsSystemOperation();
            so.Execute();
            return (List<Rezultat>)so.Result;
        }

        public List<Rezultat> SearchResults(string criterion)
        {
            SearchResultsSystemOperation so = new SearchResultsSystemOperation(criterion);
            so.Execute();
            return (List<Rezultat>)so.Result;
        }

        public bool AddResult(Rezultat r)
        {
            AddResultSystemOperation so = new AddResultSystemOperation(r);
            so.Execute();
            return (bool)so.Result;
        }

        public bool UpdateResult(Rezultat r)
        {
            UpdateResultSystemOperation so = new UpdateResultSystemOperation(r);
            so.Execute();
            return (bool)so.Result;
        }

        public bool DeleteResult(Rezultat r)
        {
            DeleteResultSystemOperation so = new DeleteResultSystemOperation(r);
            so.Execute();
            return (bool)so.Result;
        }

        public List<Platforma> GetPlatforms()
        {
            GetPlatformsSystemOperation so = new GetPlatformsSystemOperation();
            so.Execute();
            return (List<Platforma>)so.Result;
        }

        public List<Kategorija> GetCategories()
        {
            GetCategoriesSystemOperation so = new GetCategoriesSystemOperation();
            so.Execute();
            return (List<Kategorija>)so.Result;
        }

        public List<KategorijaIgre> GetGameCategories()
        {
            GetGameCategoriesSystemOperation so = new GetGameCategoriesSystemOperation();
            so.Execute();
            return (List<KategorijaIgre>)so.Result;
        }
    }
}