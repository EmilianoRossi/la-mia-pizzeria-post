using PizzeriaWebApp.Models;

namespace PizzeriaWebApp.Utils
{

    //Statica perchè ci serve un metodo che ci restituisca una lista di info
    public static class PizzaData
    {

        private static List<Pizza> pizzas;

        public static List<Pizza> GetPizza()
        {

            if(PizzaData.pizzas != null)
            {

                return PizzaData.pizzas;

            } 

            List<Pizza> nuovaPizzas = new List<Pizza>();

            for(int i = 0; i < 5; i++)
            {

                Pizza pizza = new Pizza("Pizza Margherita" , 8.00 , "Pizza base rossa con mozzarella e basilico IGP" , "https://www.scattidigusto.it/wp-content/uploads/2020/09/pizza-margherita-Diametro-33-Napoli-1568x1045.jpg");
                nuovaPizzas.Add(pizza);
            }
            PizzaData.pizzas = nuovaPizzas;
            return PizzaData.pizzas;
        }




    }


}
