using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using control_acceso.Models;

namespace control_acceso.Controllers;

public class ControlAccesoController : Controller
{

    public ControlAccesoController()
    {
       
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
           return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
