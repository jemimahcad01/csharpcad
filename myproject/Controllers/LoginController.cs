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

    
    void ConnectionString(){
        con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS; database=cad_oos_shop; User ID=CADBATCH01; Password=CAD@123pass; TrustServerCertificate=True; ";
    }
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

    [HttpGet]
    public IActionResult login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult LoginDB(LoginModel lmodel){
    ConnectionString();
        con.Open();
        com.Connection=con;
        com.CommandText="select * from loginuser where username=@username and password=@password";
        com.Parameters.AddWithValue("@username",lmodel.username);
        com.Parameters.AddWithValue("@password",lmodel.password);
        int rowAffected=com.ExecuteNonQuery();
        if(rowAffected>0)
        {
            con.Close();
            return RedirectToAction("Index");
        }
        else
        {
            con.Close();
            return View("Error");
        }
    }




    [HttpGet]
    public IActionResult register()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult registerDB(RegisterModel rmodel){
    ConnectionString();
        con.Open();
        com.Connection=con;
        com.CommandText="insert into reg_user(username,Phone_number,email_id,password) values (@username,@Phone_number,@email_id,@password) ";
        com.Parameters.AddWithValue("@username",rmodel.username);
        com.Parameters.AddWithValue("@Phone_number",rmodel.Phone_number);
        com.Parameters.AddWithValue("@email_id",rmodel.email_id);
        com.Parameters.AddWithValue("@password",rmodel.password);
        int rowAffected=com.ExecuteNonQuery();
        if(rowAffected>0){
            con.Close();
            return RedirectToAction("Login");
        }
        else{
            con.Close();
            return View("Error");
        }
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
