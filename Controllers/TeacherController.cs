using Microsoft.AspNetCore.Mvc;
using MyFirstProyectWithLineCommand.Models;

namespace MyFirstProyectWithLineCommand.Controllers;
public class TeacherController : Controller
{
    public TeacherController()
    {
    }

    public IActionResult TeacherAdd()
    {
        return View();
    }


     public IActionResult TeacherList()
    {
        TeacherModel profesor = new TeacherModel();
        profesor.Nombre = "Ricardo Elizalde";
        profesor.Carrera = "Ing. en Sistemas Computacionales";

        TeacherModel profesor2 = new TeacherModel();
        profesor2.Nombre = "Ericka Cardona";
        profesor2.Carrera = "Lic. en Matematicas";

        List<TeacherModel> List = new List<TeacherModel>();
        List.Add(profesor);
        List.Add(profesor2);

        return View(List);
    }

    [HttpPost]
    public IActionResult TeacherAdd(TeacherModel teacher)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        return Redirect("TeacherList");
    }

    public IActionResult TeacherEdit()
    {
        return View();
    }

    public IActionResult TeacherShowToDelete()
    {
        return View();
    }

    public ActionResult TeacherDeleted()
    {
        return Redirect("TeacherList");
    }
}