using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database;
namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public PersonController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ActionResult<List<Person>> GetAllPerson()
        {
            return Ok(_dbContext.Person.Include(p => p).ToList());
        }
    }
}