using CarFinder.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFinder.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CarController
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public CarController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        /// <summary>
        /// Retrieves a a paged result of cars
        /// </summary>
        [HttpGet]
        public async Task<PageResult> GetCars(int? page, int pagesize = 1)
        {
            var count = _applicationDbContext.Cars.Count();
            var result = new PageResult
            {
                Count = count,
                PageIndex = page ?? 1,
                PageSize = pagesize,
                Items = _applicationDbContext.Cars.Skip((page - 1 ?? 0) * pagesize).Take(pagesize).ToList()
            };
            return result;
        } 
    }
}
