using System;

class Program {
    static void Main(string[] args) {
        int dayOfWeek, timeOfDay, breakfastSet = 5, weekendSet = 3, coffeeSet = 2;
        string menu = "";

        
            Console.Write("Enter day (1-7):");
            dayOfWeek = int.Parse(Console.ReadLine());

            Console.Write("Enter time (8-18):");
            timeOfDay = int.Parse(Console.ReadLine());

            while (menu != "End") {

                Console.Write("Enter menu ('Breakfast Set', 'Weekend Set', 'Coffee'):");
            menu = Console.ReadLine();

             switch (menu) {
                case "Breakfast Set":
                    if (breakfastSet > 0 && timeOfDay >= 8 && timeOfDay < 11) {
                        breakfastSet--;
                        
                        Console.WriteLine("{0} sets of 'Weekend Set' left.", breakfastSet);
                        if(dayOfWeek >= 1 && dayOfWeek <= 5){
                            Console.WriteLine("'Weekend Set' is not available now.", weekendSet);
                        }
                        else{
                           Console.WriteLine("{0} sets of 'Weekend Set' left.", weekendSet); 
                        }
                        Console.WriteLine("{0} sets of 'Coffee' left.", coffeeSet);
                    }
                    else if (breakfastSet == 0) {
                        Console.WriteLine("Sorry, Your order is out of stock.");
                    }
                    else if (timeOfDay >= 11 && timeOfDay <= 18) {
                        Console.WriteLine("Sorry, Your order is not available");
                    }
                    
                    break;
                case "Weekend Set":
                    if (weekendSet > 0 && dayOfWeek >= 6 && dayOfWeek <= 7) {
                        weekendSet--;
                        if(timeOfDay >= 11 && timeOfDay <= 18){
                            Console.WriteLine("'Breakfast Set' is not available now.");
                        }
                        else{
                            Console.WriteLine("{0} sets of 'Weekend Set' left.", breakfastSet);
                        }
                        Console.WriteLine("{0} sets of 'Weekend Set' left.", weekendSet);
                        Console.WriteLine("{0} sets of 'Coffee' left.", coffeeSet);
                    }
                    else if (weekendSet == 0) {
                        Console.WriteLine("Sorry, Your order is out of stock.");
                    }
                    else if (dayOfWeek >= 1 && dayOfWeek <= 5) {
                        Console.WriteLine("Sorry, Your order is not available");
                    }
                    break;
                case "Coffee":
                    if (coffeeSet > 0) {
                        coffeeSet--;
                        if(timeOfDay >= 11 && timeOfDay <= 18){
                            Console.WriteLine("'Breakfast Set' is not available now.");
                        }
                        else{
                            Console.WriteLine("{0} sets of 'Weekend Set' left.", breakfastSet);
                        }
                        if(dayOfWeek >= 1 && dayOfWeek <= 5){
                            Console.WriteLine("'Weekend Set' is not available now.", weekendSet);
                        }
                        else{
                           Console.WriteLine("{0} sets of 'Weekend Set' left.", weekendSet); 
                        }
                        Console.WriteLine("{0} sets of 'Coffee' left.", coffeeSet);
                    }
                    else {
                        Console.WriteLine("Sorry, Your order is sold out.");
                    }
                    break;
                case "End":
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Please enter a valid menu.");
                    break;
            }
        }
    }
}
