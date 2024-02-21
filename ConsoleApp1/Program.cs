using System;
using System.Collections.Generic;

namespace TakeAwayApp
{
    //Global Variables

    //Methods and/or functions
    class Program
    {
        
        //When run/main process
        static void Main(string[] args)
        {
            List<List<int>> food = new List<List<int>>();

            food.Add(new List<int> { 1, 2, 3 });
            food.Add(new List<int> { 4, 5, 6 });
            food.Add(new List<int> { 6, 7, 8, 9});
            food.Add(new List<int> { 10, 11, 12});

            foreach (var list in food)
            {
                
            }

            //food[1] = "Ham & cheese";
            //food[2] = "Beef & onion";
            //food[3] = "Hawaiian";
            //food[4] = "Vegetarian";
            //food[5] = "Pepperoni";
            //food[6] = "Margherita";
            //food[7] = "Chicken BBQ";
            //food[8] = "Buffalo chicken";
            //food[9] = "Neapolitan";
            //food[10] = "Chicken Cranberry";
            //food[11] = "Hot & Spicy Veggie";
            //food[12] = "Cheesy Garlic";

            string flagMain = "";
            while (!flagMain.Equals("XXX"))
            {
                CheckFlag();

                CheckPizza();

                OneOrder();

                Console.WriteLine("Press <Enter> to finish ordering or press 'XXX' to cancel");
                flagMain = Console.ReadLine();

            }

            Console.WriteLine($"You have ordered () pricing at ()$");

            Console.WriteLine(CheckFlag());
            Console.Clear();

        }

        static string CheckFlag() 
        {
            while (true)
            {
                //Recieve user's choice

                Console.WriteLine("Please select a choice for recieving your order:\n1.Delivery\n2.Pickup");
                string pizzaName = Console.ReadLine();

                if (!pizzaName.Equals(""))
                {
                    //Check if order inputted is correct

                    pizzaName = pizzaName[0].ToString().ToUpper() + pizzaName.Substring(1);

                    return pizzaName;
                }
                Console.WriteLine("Error: Please enter a number for a pizza you may like");
                Console.Clear();

            }
        }

        static string CheckPizza()
        {
            while (true)
            {

                //Display two choices, delivery or pickup

                Console.WriteLine("Please select a choice for recieving your order:\n1.Delivery\n2.Pickup");
                string pizzaName = Console.ReadLine();

                if (!pizzaName.Equals(""))
                {
                    //Check if order inputted is correct

                    pizzaName = pizzaName[0].ToString().ToUpper() + pizzaName.Substring(1);

                    return pizzaName;
                }

                Console.WriteLine("Error: Please enter a number for a pizza you may like");
            }
        }

        static void OneOrder()
        {
            //Display order type

            Console.WriteLine();

            //Display pizza menu
            Console.WriteLine(
                "Dream Pizza menu\n"
                + ">------------------------------------------<\n\n"
                + "1. Ham & cheese\n"
                + "2. Beef & onion\n"
                + "3. Hawaiian\n"
                + "4. Vegetarian\n"
                + "5. Pepperoni\n"
                + "6. Margherita\n"
                + "7. Chicken BBQ\n"
                + "8. Buffalo chicken\n"
                + "9. Neapolitan\n"
                + "10. Chicken Cranberry\n"
                + "11. Hot & Spicy Veggie\n"
                + "12. Cheesy Garlic\n\n"
                + ">------------------------------------------<"
                );
            
        }
    }
}
