using Microsoft.AspNetCore.Mvc;

namespace BukenTrainerPortal.Controllers;

public class CheckInsController : Controller
{
    private readonly ILogger<CheckInsController> _logger;

    public CheckInsController(ILogger<CheckInsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
