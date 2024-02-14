using System;
using System.Collections.Generic;

namespace TakeAwayApp
{
    //Global Variables
    static List<string> OrderOne = new List<string>();

    class Program
    {
        
        //When run/main process
        static void Main(string[] args)
        {
            string flagMain = "";
            while (!flagMain.Equals("XXX"))
            {
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

            List<string> OrderOne = new List<string>() 
            {"1. Ham & cheese","2. Beef & onion","3. Hawaiian","4. Vegetarian","5. Pepperoni",
             "6. Margherita","7. Chicken BBQ","8. Buffalo chicken","9. Neapolitan","10. Chicken Cranberry", 
             "11. Hot & Spicy Veggie", "12. Cheesy Garlic" };

            

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

            //Enter and store pizza name
            Console.WriteLine("Enter a number of the pizza flavour the you want choose:\n");
            Console.ReadLine();

            //Loop(while) until the user has chosen a minimum of 5 pizzas or until the user finishes ordering

            while (true)
            {

            }
            
        }
    }
}
