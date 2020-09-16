using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController  : ControllerBase
    {
        public ApplicationDbContext _context { get; set; }

        public CelestialObjectsController(ApplicationDbContext context) => _context = context;
    }
}