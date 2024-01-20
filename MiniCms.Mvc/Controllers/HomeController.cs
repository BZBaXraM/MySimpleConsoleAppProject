using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiniCms.Mvc.Data;
using MiniCms.Mvc.Models;
using MiniCms.Mvc.Services;

namespace MiniCms.Mvc.Controllers;

public class HomeController : Controller
{
    public async Task<IActionResult> Index()
    {
        return await Task.FromResult<IActionResult>(RedirectToAction("Index", "Order"));
    }


    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
}