using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Boletim()
    {
        List<string> disciplinas = new List<string>
        {
            "Matemática",
            "Português",
            "História",
            "Geografia",
            "Ciências"
        };

        List<double> notas = new List<double>
        {
            8.5,
            7.0,
            9.0,
            6.5,
            8.0
        };

        ViewBag.Disciplinas = disciplinas;
        ViewBag.Notas = notas;
        return View();
    
    }
    public IActionResult Boletim()
    {
        return View();
    }
}

    