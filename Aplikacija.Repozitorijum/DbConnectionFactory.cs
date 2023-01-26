namespace Aplikacija.Repozitorijum
{
    public class DbConnectionFactory
    {
        private DbConnection connection = new DbConnection();
        private static DbConnectionFactory _instance;
        public static DbConnectionFactory Instance
        { 
            get 
            { 
                if (_instance is null) 
                    _instance = new DbConnectionFactory();

                return _instance; 
            } 
        }

        public DbConnection GetDbConnection()
        {
            if (!connection.IsReady())
                connection.OpenConnection();

            return connection;
        }
    }
}