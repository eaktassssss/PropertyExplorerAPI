using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PropertyExplorerAPI.Models;
using PropertyExplorerAPI.MongoProvider;
using System.Collections;

namespace PropertyExplorerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase
    {
        private readonly MongoConnectionProvider mongoConnectionProvider;
        IMongoDatabase database;
        IMongoCollection<T> mongoCollection;
        string collectionName;
        public BaseController()
        {
                
        }
        public BaseController(IConfiguration configuration,string collectionName)
        {
            mongoConnectionProvider = new MongoConnectionProvider(configuration.GetSection("MongoConnection:ConnectionString").Value, configuration.GetSection("MongoConnection:Database").Value);
            database = mongoConnectionProvider.GetDatabase();
            this.collectionName = collectionName;
        }
        [NonAction]
        public  IMongoCollection<T> GetCollection()
        {
            mongoCollection = mongoCollection = database.GetCollection<T>(this.collectionName);
            return mongoCollection;
        }
    }
}
