
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using PropertyExplorerAPI.Models;
using PropertyExplorerAPI.Wrapper;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
namespace PropertyExplorerAPI.Controllers
{


    [ApiController]
    [Route("api/properties")]
    public class PropertiesController : BaseController<Properties>
    {
        private readonly IMongoCollection<Properties> _mongoCollection;

        public PropertiesController(IConfiguration configuration)
            : base(configuration, nameof(Properties).Trim().ToLower())
        {
            _mongoCollection = GetCollection();
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAllProperties()
        {
            try
            {
                var filter = Builders<Properties>.Filter.Empty;
                var properties = _mongoCollection.Find(filter).ToList();
                return Ok(CreateResponse<List<Properties>>(true, "Properties retrieved successfully", properties, (int)HttpStatusCode.OK));
            }
            catch (Exception ex)
            {

                return BadRequest(CreateResponse<ErrorDetails>(false, "An error occurred", new ErrorDetails(ex.Message, "ERR01"), (int)HttpStatusCode.BadRequest));
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPropertyById(string id)
        {
            try
            {
                var filter = Builders<Properties>.Filter.Eq("_id", new ObjectId(id));
                var property = _mongoCollection.Find(filter).FirstOrDefault();
                if (property == null)
                {
                    return NotFound(CreateResponse<ErrorDetails>(false, "Property not found", new ErrorDetails("The property with the specified ID does not exist", "ERR02"), (int)HttpStatusCode.NotFound));
                }
                return Ok(CreateResponse<Properties>(true, "Properties retrieved successfully", property, (int)HttpStatusCode.OK));
            }
            catch (Exception ex)
            {
                return BadRequest(CreateResponse<ErrorDetails>(false, "An error occurred", new ErrorDetails(ex.Message, "ERR01"), (int)HttpStatusCode.BadRequest));
            }
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreateProperty([FromBody] Properties property)
        {
            try
            {
                _mongoCollection.InsertOne(property);
                return Ok(CreateResponse<Properties>(true, "Properties retrieved successfully", property, (int)HttpStatusCode.OK));
            }
            catch (Exception ex)
            {
                return BadRequest(CreateResponse<ErrorDetails>(false, "An error occurred", new ErrorDetails(ex.Message, "ERR01"), (int)HttpStatusCode.BadRequest));
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateProperty(string id, [FromBody] Properties property)
        {
            try
            {
                var filter = Builders<Properties>.Filter.Eq("_id", new ObjectId(id));
                var updateResult = _mongoCollection.ReplaceOne(filter, property);
                if (updateResult.MatchedCount == 0)
                {
                    return NotFound(CreateResponse<ErrorDetails>(false, "Property not found", new ErrorDetails("The property with the specified ID does not exist", "ERR02"), (int)HttpStatusCode.NotFound));
                }
                return Ok(CreateResponse<Properties>(true, "Property deleted successfully", property, (int)HttpStatusCode.OK));
            }
            catch (Exception ex)
            {
                return BadRequest(CreateResponse<ErrorDetails>(false, "An error occurred", new ErrorDetails(ex.Message, "ERR01"), (int)HttpStatusCode.BadRequest));
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProperty(string id)
        {
            try
            {
                var filter = Builders<Properties>.Filter.Eq("_id", new ObjectId(id));
                var deleteResult = _mongoCollection.DeleteOne(filter);
                if (deleteResult.DeletedCount == 0)
                {
                    return NotFound(CreateResponse<ErrorDetails>(false, "Property not found", new ErrorDetails("The property with the specified ID does not exist", "ERR02"), (int)HttpStatusCode.NotFound));
                }

                return Ok(CreateResponse<Properties>(true, "Property deleted successfully", null, (int)HttpStatusCode.OK));
            }
            catch (Exception ex)
            {
                return BadRequest(CreateResponse<ErrorDetails>(false, "An error occurred", new ErrorDetails(ex.Message, "ERR01"), (int)HttpStatusCode.BadRequest));
            }
        }

        [HttpGet]
        [Route("category/{categoryId}")]
        public IActionResult GetPropertiesByCategoryId(string categoryId)
        {
            try
            {
                var filter = Builders<Properties>.Filter.Eq("CategoryId", categoryId);
                var properties = _mongoCollection.Find(filter).ToList();

                return Ok(CreateResponse<IEnumerable<Properties>>(true, "Properties retrieved successfully", properties, (int)HttpStatusCode.OK));
            }
            catch (Exception ex)
            {
                return BadRequest(CreateResponse<ErrorDetails>(false, "An error occurred", new ErrorDetails(ex.Message, "ERR01"), (int)HttpStatusCode.BadRequest));
            }
        }
    }


}
