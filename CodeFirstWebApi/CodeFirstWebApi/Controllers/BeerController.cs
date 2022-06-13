using DB.Data;
using DB.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private readonly BarContext _context;

        public BeerController(BarContext barContext)
        {
            _context = barContext;
        }

        [HttpGet]
        public IEnumerable<Beer> Get() => _context.Beers.ToList();
    }
}
