using System;

class HotelMenu
{
    static void Main()
    {
        int choice, quantity;
        int totalDishes = 0;
        double totalAmount = 0;
        char continueChoice;

        do
        {
            Console.WriteLine("\n------ HOTEL MENU ------");
            Console.WriteLine("1. Tea       - Rs. 10");
            Console.WriteLine("2. Coffee    - Rs. 20");
            Console.WriteLine("3. Burger    - Rs. 50");
            Console.WriteLine("4. Pizza     - Rs. 100");
            Console.WriteLine("------------------------");
            Console.Write("Enter your choice: ");
            
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    totalAmount += 10 * quantity;
                    totalDishes += quantity;
                    Console.WriteLine("You ordered Tea");
                    break;

                case 2:
                    totalAmount += 20 * quantity;
                    totalDishes += quantity;
                    Console.WriteLine("You ordered Coffee");
                    break;

                case 3:
                    totalAmount += 50 * quantity;
                    totalDishes += quantity;
                    Console.WriteLine("You ordered Burger");
                    break;

                case 4:
                    totalAmount += 100 * quantity;
                    totalDishes += quantity;
                    Console.WriteLine("You ordered Pizza");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.Write("\nDo you want to continue? (y/n): ");
            continueChoice = Convert.ToChar(Console.ReadLine().ToLower());

        } while (continueChoice == 'y');

        Console.WriteLine("\n------ BILL SUMMARY ------");
        Console.WriteLine("Total Dishes Ordered: " + totalDishes);
        Console.WriteLine("Total Amount: Rs. " + totalAmount);
        Console.WriteLine("Thank you! Visit again ");
    }
}