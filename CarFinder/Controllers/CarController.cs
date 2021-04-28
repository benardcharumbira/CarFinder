using CarFinder.Data;
using CarFinder.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
        public  PageResult GetCars(int? page, int pagesize = 10)
        {
            var result = new PageResult
            {
                Count = _applicationDbContext.Cars.Count(),
                PageIndex = page ?? 1,
                PageSize = pagesize,
                Items = _applicationDbContext.Cars.Skip((page - 1 ?? 0) * pagesize).Take(pagesize).ToList()
            };
            return result;
        } 
    }
}
