using Microsoft.AspNetCore.Mvc;
using MyFirstProyectWithLineCommand.Models;

namespace MyFirstProyectWithLineCommand.Controllers;
public class StudentController : Controller
{
    public StudentController()
    {
    }

    public IActionResult StudentList()
    {
        StudentModel alumno = new StudentModel();
        alumno.Nombre ="Carlos Ernesto Marin Ramirez";
        alumno.Matricula = 44552;
        alumno.Carrera = "Ing. TI en Desarrollo de Software";
        alumno.Sexo = "M";
        alumno.Edad = 29;

        StudentModel alumno2 = new StudentModel();;
        alumno2.Nombre ="Mariana Zavala";

        StudentModel alumno3 = new StudentModel();
        alumno3.Nombre ="Ulises Moises";

        List<StudentModel> List = new List<StudentModel>();
        List.Add(alumno);
        List.Add(alumno2);
        List.Add(alumno3);

        return View(List);

    }

    public IActionResult StudentAdd()
    {
        return View();
    }

    public IActionResult StudentEdit()
    {
        return View();
    }

    [HttpPost]
    public IActionResult StudentAdd(StudentModel student)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        return Redirect("StudentList");
    }

    public IActionResult StudentShowToDelete()
    {
        return View();
    }

    public ActionResult DegreeDeleted()
    {
        return Redirect("StudentList");
    }
}