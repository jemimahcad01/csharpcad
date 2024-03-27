using System.Diagnostics;
using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using myproject.Models;

namespace myproject.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    SqlConnection con =new SqlConnection();
    SqlCommand com= new SqlCommand();
    SqlDataReader? dr;

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult CustomJewelry()
    {
        return View();
    }
    public IActionResult DesignerJewelry()
    {
        return View();
    }
    public IActionResult aboutus()
    {
        return View();
    }

    public IActionResult contactus()
    {
        return View();
    }
    public IActionResult login()
    {
        return View();
    }

    [HttpGet]
    public IActionResult register()
    {
        return View();
    }
    

    public IActionResult registerDB()
    {
        return View();
    }
     public IActionResult error()
    {
        return View();
    }
     public IActionResult success()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
