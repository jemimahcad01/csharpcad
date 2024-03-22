﻿using System.Diagnostics;
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
    [HttpGet]
    public IActionResult login()
    {
        return View();
    }
    // void ConnectionString()
    // {
    // con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS; database:cad_oos_shop; User Id:CADBATCH01; Password:CAD@123pass; TrustServerCertificate=True;";
    // }

    // [HttpPost]
    // public IActionResult VerifyLogin(LoginModel lmodel){
    //     ConnectionString();
    //     con.Open();
    //     com.Connection=con;
    //     com.CommandText="select*from loginuser where username='"+ lmodel.username +"'+and password ='" + lmodel.password +"';";
    //     dr=com.ExecuteReader();
    //     if(dr.Read())
    //     {
    //         con.Close();
    //         return View("success");
    //     }
    //     else
    //     {
    //         con.Close();
    //         return View("error");
    //     }
    // }

[HttpPost]
public IActionResult VerifyLogin(LoginModel lmodel)
{
    string connectionString = "Data Source=192.168.1.240\\SQLEXPRESS;Initial Catalog=cad_oos_shop;User ID=CADBATCH01;Password=CAD@123pass;TrustServerCertificate=True;";
    
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        
        string query = "SELECT * FROM loginuser WHERE username=@username AND password=@password";
        
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@username", lmodel.username);
            command.Parameters.AddWithValue("@password", lmodel.password);
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return View("success");
                }
                else
                {
                    return View("error");
                }
            }
        }
    }
}
    public IActionResult register()
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