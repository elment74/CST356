using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Database;

namespace webapi.Controllers
{
    [Route("api/student")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ActionResult<List<Student>> GetAllStudent()
        {
            return Ok(_dbContext.Student.Include(p => p).ToList());
        }
    }
}
