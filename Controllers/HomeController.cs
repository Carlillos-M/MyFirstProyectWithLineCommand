using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstProyectWithLineCommand.Models;

namespace MyFirstProyectWithLineCommand.Controllers;

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

    public IActionResult StudentList()
    {
        StudentModel alumno = new StudentModel();
        alumno.Nombre = "Carlos Marin";
        alumno.Carrera = "Ing. TI con Orientacion a Desarrollo de Software";


        return View(alumno);
    }

    public IActionResult TeacherList()
    {
        TeacherModel profesor = new TeacherModel();
        profesor.Nombre = "Ricardo Elizalde";
        profesor.Carrera = "Ing. en Sistemas Computacionales";

        return View(profesor);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
