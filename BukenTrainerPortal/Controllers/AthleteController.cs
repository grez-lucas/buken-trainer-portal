using BukenTrainerPortal.Data;
using BukenTrainerPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        List<Athlete> objAthleteList = _db.Athletes.Include(a => a.Coach).ToList();
        return View(objAthleteList);
    }

    public IActionResult Create()
    {
        List<Coach> coaches = _db.Coaches.ToList();

        // Pass list of coaches to the view using ViewBag
        ViewBag.CoachList = coaches;

        return View();
    }

    // POST: /Athletes/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Athlete model)
    {
        if (ModelState.IsValid) // Check if the C# object is valid
        {
            _db.Athletes.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        List<Coach> coaches = _db.Coaches.ToList();
        ViewBag.CoachList = coaches;

        // Return the model back to the view wth errors
        return View(model);
    }
}
