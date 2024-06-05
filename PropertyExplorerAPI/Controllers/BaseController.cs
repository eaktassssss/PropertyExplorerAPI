using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PropertyExplorerAPI.Models;
using PropertyExplorerAPI.Wrapper;
using System.Collections;

namespace PropertyExplorerAPI.Controllers
{
    public abstract class BaseController<T> : ControllerBase where T : class
    {

        IMongoDatabase database;
        IMongoCollection<T> mongoCollection;
        private string ConnectionString { get; set; }
        private string DatabaseName { get; set; }
        private string CollectionName { get; set; }
        public BaseController(IConfiguration configuration,string collectionName)
        {
            this.ConnectionString = configuration.GetSection("MongoConnection:ConnectionString").Value;
            this.DatabaseName = configuration.GetSection("MongoConnection:Database").Value;
            this.CollectionName = collectionName;
            database = GetDatabase();
        }
        [NonAction]
        public  IMongoCollection<T> GetCollection()
        {
            mongoCollection = mongoCollection = database.GetCollection<T>(this.CollectionName);
            return mongoCollection;
        }
        private IMongoDatabase GetDatabase()
        {
            var connection = new MongoClient(ConnectionString);
            var db = connection.GetDatabase(DatabaseName);
            return db;
        }

        //public ResponseWrapper<IEnumerable<T> CreateSuccessResponse(bool success, string message, T data, int statusCode)

        public ResponseWrapper<T> CreateResponse<T>(bool success, string message, T data, int statusCode)
        {
            return new ResponseWrapper<T>(success, message, data, statusCode);
        }
    }
}
