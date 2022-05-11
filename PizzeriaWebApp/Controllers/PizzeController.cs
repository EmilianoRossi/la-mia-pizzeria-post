using Microsoft.AspNetCore.Mvc;
using PizzeriaWebApp.Models;
using PizzeriaWebApp.Utils;

namespace PizzeriaWebApp.Controllers
{
    public class PizzeController : Controller
    {
        [HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult LeMiePizze()
        {
            List<Pizza> pizzas = PizzaData.GetPizza();
            return View(pizzas);
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View();

        }

        [HttpGet]
        public IActionResult Create()
        {

            return View("FormPost");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza nuovaPizza)
        {

            if (!ModelState.IsValid)
            {

                return View("FormPost" , nuovaPizza);

            }

            Pizza pizzaConId = new Pizza(nuovaPizza.nome, nuovaPizza.prezzo, nuovaPizza.descrizione, nuovaPizza.foto);

            PizzaData.GetPizza().Add(pizzaConId);

            return RedirectToAction("Index" , "Home");

        }
    }

   

    
}
