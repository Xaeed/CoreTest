using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testing.Models;
using testing.persistence;

namespace testing.Controllers
{
    public class MakeController : Controller
    {
        private readonly TestingDbContext context;
        public MakeController(TestingDbContext context)
        {
            this.context = context;

        }

        [HttpGet("api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await  context.Make.Include(m=>m.Name)
            .ToListAsync();
        }



    }
}