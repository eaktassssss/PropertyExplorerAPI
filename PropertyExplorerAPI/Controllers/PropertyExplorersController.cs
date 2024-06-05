using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Linq;
using PropertyExplorerAPI.Models;
using PropertyExplorerAPI.MongoProvider;

namespace PropertyExplorerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyExplorersController : BaseController<Properties>
    {
        IMongoCollection<Properties> mongoCollection;
        public PropertyExplorersController(IConfiguration configuration) : base(configuration, nameof(Properties).Trim().ToLower())
        {
            mongoCollection = GetCollection();
        }
        [HttpGet]
        public IActionResult GetAllProperties()
        {
            try
            {
                var filter = Builders<Properties>.Filter.Empty;
                var properties = mongoCollection.Find(filter).ToList();
                return Ok(properties);
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw new Exception(ex.Message);
            }
        }
    }
}
