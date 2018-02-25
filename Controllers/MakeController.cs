using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testing.Controllers.Resources;
using testing.Models;
using testing.persistence;

namespace testing.Controllers
{
    public class MakeController : Controller
    {
        private readonly TestingDbContext context;
        private readonly IMapper mapper;

        public MakeController(TestingDbContext context,IMapper mapper )
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("api/makes")]
        public async Task<IEnumerable<MakeResources>> GetMakes()
        { 
            
              var makes= await context.Make.Include(m=>m.Model).ToListAsync();
              return mapper.Map<List<Make>,List<MakeResources>>(makes);
        }
    }
}