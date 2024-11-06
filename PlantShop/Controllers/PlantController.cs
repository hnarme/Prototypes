using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Models;

namespace PlantShop.Controllers;

public class PlantController : Controller
{
    private readonly ILogger<StaffController> _logger;
    private readonly IConfiguration _configuration;

    public PlantController(ILogger<StaffController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        return View(Database.Instance.GetAllPlant());
    }

    public IActionResult IndoorOnly()
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        return View(Database.Instance.IndoorOnlyPlant());
    }

    public IActionResult OutdoorOnly()
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        return View(Database.Instance.outdoorOnlyPlant());
    }

    public ActionResult Create(Plant plant)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        return View(plant);
    }

    public ActionResult CreateResult(Plant plant)
    {
        Database.Instance.AddPlant(plant);
        return View(plant);
    }

    public ViewResult Display(int id)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Plant idPlant = Database.Instance.GetAllPlant().FirstOrDefault(plant => plant.Plant_Id == id);
        return View(idPlant);
    }

    public ViewResult Edit(int id)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Plant editPlant = Database.Instance.GetAllPlant().FirstOrDefault(plant => plant.Plant_Id == id);
        return View(editPlant);
    }

    public ViewResult EditResult(Plant plant)
    {
        Database.Instance.EditPlant(plant);
        return View(plant);
    }

    public ViewResult Delete(int id, Plant plant)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Plant deletePlant = Database.Instance.GetAllPlant().FirstOrDefault(plant => plant.Plant_Id == id);

        return View(deletePlant);
    }

    public ActionResult DeleteResult(Plant plant)
    {
        Database.Instance.DeletePlant(plant);
        return View(plant);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}