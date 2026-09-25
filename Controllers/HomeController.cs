using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers;

public class HomeController : Controller
{
    // GET: показываем пустую форму
    public IActionResult Index()
    {
        return View();
    }

    // POST: принимаем данные из формы и отдаём обратно
    [HttpPost]
    public IActionResult Index(Book book)
    {
        return View(book);
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


    // GET: показываем пустую форму
    public IActionResult Books()
    {
        return View();
    }

    // POST: получаем данные из формы и передаём их обратно в View
    [HttpPost]
    public IActionResult Books(Book book)
    {
        return View(book);
    }
}
