using Microsoft.AspNetCore.Mvc;

namespace BukenTrainerPortal.Controllers;

public class CoachesController : Controller
{
    private readonly ILogger<CoachesController> _logger;

    public CoachesController(ILogger<CoachesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
