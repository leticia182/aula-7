using Microsoft.AspNetCore.Mvc;
namespace Uninove.Web.Controllers;


public class ProdutoController : Controller
{
    public IActionResult Index()
    {
        List<string> produtos = new List<string>
        {
            "Notebook",
            "Mouse",
            "Teclado",
            "Monitor",
            "Impressora"
        };

        List<double> Precos = new List<double>
        {
            2500.00,
            150.00,
            200.00,
            1200.00,
            800.00
        };

        ViewBag.Produtos = produtos;
        ViewBag.Precos = Precos;
        return View();
    
    }
}
