using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

[Route("")]
[ApiController]
public class CelestialObjectsController : ControllerBase
{
    public ApplicationDbContext _context { get; set; }
    
    public CelestialObjectsController(ApplicationDbContext context) => _context = context;
}