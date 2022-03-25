using Microsoft.AspNetCore.Mvc;
using RegistrationAbstractLibrary;
using RegistrationCommonLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        // Storage type we defined as 1 so it will be configure to file structure
        const string storageKey = "1";

        // GET api/<RegistrationController>
        [HttpGet]
        public Configuration Get()
        {
            var dbRepository = FactoryRegistration.Repository(storageKey);
            return dbRepository.GetConfiguration();
        }

        // POST api/<RegistrationController>
        [HttpPost]
        public bool Post([FromBody] Configuration configuration)
        {
            var dbRepository = FactoryRegistration.Repository(storageKey);
            return dbRepository.InsertOrUpdate(configuration);
        }
    }
}
