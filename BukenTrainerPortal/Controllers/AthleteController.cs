using BukenTrainerPortal.Data;
using BukenTrainerPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace BukenTrainerPortal.Controllers;

public class AthletesController : Controller
{
    private readonly ILogger<AthletesController> _logger;
    private readonly ApplicationDbContext _db;

    public AthletesController(ILogger<AthletesController> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        List<Athlete> objAthleteList = _db.Athletes.ToList();
        return View();
    }
}
