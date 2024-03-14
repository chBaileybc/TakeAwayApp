using System;
using System.Collections.Generic;

namespace TakeAwayApp
{
   
    class Program
    {
       //Global Variables

        //Delivery selection list
        static List<string> deliveryChoice = new List<string>()
        {"Delivery", "Pickup"};

        //Pizza Selection list
        static List<string> pizzaChoice = new List<string>()
        {"1. Ham & cheese", "2. Beef & onion", "3. Hawaiian", "4. Vegetarian", "5. Pepperoni", "6. Margherita"
            , "7. Chicken BBQ", "8. Buffalo chicken", "9. Neapolitan", "10. Chicken Cranberry", "11. Hot & Spicy Veggie", "12. Cheesy Garlic"};
        
       //Methods and/or functions  
        static int CheckInt(string question, int min, int max)
        {
            while (true)
            {
                try
                {

                    Console.WriteLine(question);
                    int userInt = Convert.ToInt32(Console.ReadLine());
                    if ((userInt < 1) || (userInt > 2))
                    {
                        //Display an error message letting th euser know it's too low/High what they have entered
                        Console.WriteLine("\nError:Enter a number 1-2 for recieving your order "+
                            "| Please press enter to try again");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        return userInt;
                    }
                }

                catch (System.FormatException)
                {
                    //Display an error message letting user know that intergers can only be entered
                    Console.WriteLine("\nError: Enter a number 1-2 for recieving your order\n");
                }

                
            }
            
        }

        static int CheckPizza(string question, int min, int max) 
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(question);
                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if ((userInt < 1) || (userInt > 12))
                    {
                        //Display an error message letting th euser know it's too low/High what they have entered
                        Console.WriteLine("\nError:Enter a number 1-12 for recieving your order " +
                            "| Please press enter to try again");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        return userInt;
                    }
                }
                catch (System.FormatException)
                {
                    //Display an error message letting user know that intergers can only be entered
                    Console.WriteLine("\nError: Enter a number 1-12 for selecting your pizza\n");
                }
            }
        }
    
    static string CheckFlag() 
        {
            while (true)
            {
                //get user's choice
                Console.WriteLine("Press <Enter> to select more pizza's for your order or press 'XXX' to finish ordering");
                string userInput = Console.ReadLine();

                //Convert user input to uppercase
                userInput = userInput.ToUpper();

                if (userInput.Equals("XXX") || userInput.Equals(""))
                {
                    return userInput;
                }
                
                Console.WriteLine("Error: Please type the correct choice.\n");
            }

        }  

        static void OneOrder()
        {

            //Enter and store delivery choice

            int deliveryName = CheckInt("Please select a choice for recieving your order:\n1.Delivery\n2.Pickup\n", 1, 2);

            //Display delivery choice
            Console.WriteLine($"\nYou have selected: {deliveryChoice[deliveryName - 1]}\n");

            //Direct user to menu
            Console.WriteLine("Press <Enter> to look at our menu\n");
            Console.ReadLine();
            Console.Clear();

            //Display pizza menu and store choices
            int pizzaSelection = CheckPizza("Type the number of the pizza you would want:\n"
            + "Dream Pizza menu\n"
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
            + ">------------------------------------------<", 1, 12);
              
            //Display customer's pizza selections
            Console.WriteLine($"\nYou have selected: {pizzaChoice[pizzaSelection - 1]}");

        }

        //Main process
        static void Main(string[] args)
        {
            Console.WriteLine("TAKEAWAY APP");

            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Introduction:\n" +
                "Dream pizza's will recieve an order and it's transport preference " +
                "then list each pizza with it's chosen flavour up to a maxium of 5 chosen pizza's" +
                "\nLastly, Takeaway Appe will display the entirety of the user's choices and its final price.");
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Press enter to proceed with your order. . .");
            Console.ReadLine();
            Console.Clear();

            //Loop(while) OneOrder() until user types "XXX" or "xxx"
            string flagMain = "";
            while (!flagMain.Equals("XXX") || !flagMain.Equals(""))
            {
                

                OneOrder();

                flagMain = CheckFlag();

                //Display error message when user enters wrong characters

                Console.WriteLine("Press <Enter> to restart your order or press 'XXX' to cancel");


            }

            Console.WriteLine($"You have ordered () pricing at ()$");


        }

    }
}
