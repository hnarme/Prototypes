using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Security;
using PlantShop.Models;

namespace PlantShop.Controllers;

public class StaffController : Controller
{
    private readonly ILogger<StaffController> _logger;
    private readonly IConfiguration _configuration;

    public StaffController(ILogger<StaffController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        return View(Database.Instance.GetAllStaff());
    }

    public ActionResult Create(Staff staff)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        return View(staff);
    }

    public ActionResult CreateResult(Staff staff)
    {
        //staff.Password = "password";
        Database.Instance.AddStaff(staff);
        return View(staff);
    }

    public ViewResult Display(int id)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Staff idStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Staff_Id == id);
        return View(idStaff);
    }

    public ViewResult Edit(int id)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Staff editStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Staff_Id == id);
        return View(editStaff);
    }

    public ViewResult EditResult(Staff staff)
    {
        Database.Instance.EditStaff(staff);
        staff.Email = staff.Forename + staff.Surname + "@greenplant.com";
        return View(staff);
    }

    public ViewResult Delete(int id, Staff staff)
    {
        Database.Instance.SetConnectionString(_configuration.GetValue<string>("ConnectionString"));
        Staff deleteStaff = Database.Instance.GetAllStaff().FirstOrDefault(staff => staff.Staff_Id == id);

        return View(deleteStaff);
    }

    public ActionResult DeleteResult(Staff staff)
    {
        Database.Instance.DeleteStaff(staff);
        return View(staff);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}