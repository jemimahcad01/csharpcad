﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myproject.Models;

namespace myproject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
     public IActionResult contactus()
    {
        return View();
    }
    public IActionResult aboutus()
    {
        return View();
    }
    public IActionResult ourservice()
    {
        return View();
    }
    public IActionResult login()
    {
        return View();
    }


      public IActionResult register()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
