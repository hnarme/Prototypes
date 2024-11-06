using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Models;

namespace PlantShop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;
    public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    // Shows view depending on staff's role
    public IActionResult Index(Staff staff)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        List<Staff> allStaff = Database.Instance.GetAllStaff();

        foreach (Staff staffDetails in allStaff)
        {
            if (staffDetails.Email == staff.Email && staffDetails.Password == staff.Password)
            {
                if (staffDetails.Role == "manager")
                {
                    return RedirectToAction("Index", "Staff");
                }

                if (staffDetails.Role == "standard")
                {
                    return RedirectToAction("Index", "Plant");
                }
            }
        }

        return View(staff);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
