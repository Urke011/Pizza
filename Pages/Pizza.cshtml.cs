using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ ImageTitle="Margerita",PizzaName="Margerita", BasePrice=2, TomatoSauce=true,
            Cheese=true, FinalPrice=4},
             new PizzasModel(){ ImageTitle="Bolognese",PizzaName="Bolognese", BasePrice=2, TomatoSauce=true,
            Cheese=true, FinalPrice=5},
              new PizzasModel(){ ImageTitle="Carbonara",PizzaName="Carbonara", BasePrice=2, TomatoSauce=true,
            Cheese=true, FinalPrice=6},
               new PizzasModel(){ ImageTitle="Hawaiian",PizzaName="Hawaiian", BasePrice=2, TomatoSauce=true,
            Cheese=true, FinalPrice=14},
                new PizzasModel(){ ImageTitle="Mushroom",PizzaName="Mushroom", BasePrice=2, TomatoSauce=true,
            Cheese=true, FinalPrice=41},
                 new PizzasModel(){ ImageTitle="Pepperoni",PizzaName="Pepperoni", BasePrice=2, TomatoSauce=true,
            Cheese=true, FinalPrice=22},
                  new PizzasModel(){ ImageTitle="Vegetarian",PizzaName="Vegetarian", BasePrice=2, TomatoSauce=true,
            Cheese=true, FinalPrice=10}

        };
        public void OnGet()
        {
        }
    }
}
