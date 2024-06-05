using MongoDB.Driver;

namespace PropertyExplorerAPI.MongoProvider
{
    public class MongoConnectionProvider
    {

        private string ConnectionString { get; set; }
        private string DatabaseName { get; set; }
        public MongoConnectionProvider(string connectionString, string databaseName)
        {
            ConnectionString = connectionString;
            DatabaseName = databaseName;
        }
        public IMongoDatabase GetDatabase()
        {
            var connection = new MongoClient(ConnectionString);
            var db = connection.GetDatabase(DatabaseName);
            return db;
        }
    }
}
