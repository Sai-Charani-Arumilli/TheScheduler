using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchedulerApp.Data;
using SchedulerApp.Models;

namespace SchedulerApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUserService _userService;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, IUserService userService, ApplicationDbContext context)
    {
        _logger = logger;
        _userService = userService;
        _context = context;
    }

    public IActionResult Index()
    {
        var users = _userService.GetUsers();
        //var tableCount = _context.Database.ExecuteSqlRaw("SELECT * FROM dbo.users WHERE id = 1");
        //var user = _context.UsersInApplication.FromSqlRaw("SELECT * FROM dbo.users WHERE id = 1").FirstOrDefault();

       // var test ="";
        return View(users);
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
