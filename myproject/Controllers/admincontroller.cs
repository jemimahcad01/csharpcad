using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myproject.Models;

namespace myproject.Controllers;

public class adminController : Controller
{
    private readonly ILogger<adminController> _logger;

    public adminController(ILogger<adminController> logger)
    {
        _logger = logger;
    }
 
    // SqlConnection con =new SqlConnection();
    // SqlCommand com= new SqlCommand();
    // SqlDataReader? dr;

    public IActionResult Dashboard()
    {
        return View("Dashboard","_LayoutAdmin");
    }
    public IActionResult ManageProducts()
    {
        return View("Manage Products","_LayoutAdmin");
    }
    public IActionResult ManageCategories()
    {
        return View("Manage Categories","_LayoutAdmin");
    }
    public IActionResult Orders()
    {
        return View("Orders","_LayoutAdmin");
    }
    public IActionResult Customers()
    {
        return View("Customers","_LayoutAdmin");
    }
    
    public IActionResult Reports()
    {
        return View("Reports","_LayoutAdmin");
    }

// [HttpPost]
// public IActionResult VerifyLogin(LoginModel lmodel)
// {
//     string connectionString = "Data Source=192.168.1.240\\SQLEXPRESS;Initial Catalog=cad_oos_shop;User ID=CADBATCH01;Password=CAD@123pass;TrustServerCertificate=True;";
    
//     using (SqlConnection connection = new SqlConnection(connectionString))
//     {
//         connection.Open();
        
//         string query = "SELECT * FROM loginuser WHERE username=@username AND password=@password";
        
//         using (SqlCommand command = new SqlCommand(query, connection))
//         {
//             command.Parameters.AddWithValue("@username", lmodel.username);
//             command.Parameters.AddWithValue("@password", lmodel.password);
            
//             using (SqlDataReader reader = command.ExecuteReader())
//             {
//                 if (reader.Read())
//                 {
//                     return View("success");
//                 }
//                 else
//                 {
//                     return View("error");
//                 }
//             }
//         }
//     }
// }

    public IActionResult Settings()
    {
        return View("Settings","_LayoutAdmin");
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
