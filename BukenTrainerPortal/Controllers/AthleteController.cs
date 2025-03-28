using Microsoft.AspNetCore.Mvc;

namespace BukenTrainerPortal.Controllers;

public class AthletesController : Controller
{
    private readonly ILogger<AthletesController> _logger;

    public AthletesController(ILogger<AthletesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
