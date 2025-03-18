namespace task2;
using System;

class Program
{
    public static void Main(string[] args)   
    {  
        Dictionary<string, int> shop = new Dictionary<string, int>
        {
            { "a", 10 },
            { "b", 20 },
            { "c", 30 },
            { "d", 50 },
            { "e", 70 },
            { "f", 80 }
        };
        //Shows the base dictionary
        foreach (var item in shop)
        {
           int Discount = GetDiscount(item.Value); 
            Console.WriteLine($"item {item.Key}, quantity:{item.Value}, Discount = {Discount}%" );
        }
        // prompts the user to input an item
        while (true)
        {
           Console.WriteLine("Enter item name"); 
           string ItemName = Console.ReadLine();
           Console.WriteLine($"Enter quantity for {ItemName}");
           int quantity = Convert.ToInt32(Console.ReadLine());
           shop.Add(ItemName, quantity);
           break;
        }
        //shows the updated dictionary after user has inputted a new item
        foreach (var item in shop) 
        {
            int Discount = GetDiscount(item.Value); 
             Console.WriteLine($"item {item.Key}, quantity:{item.Value}, Discount = {Discount}%" );
        }
   
    }
    // Assigns discount depending on item quantity, with a max value of 40% on anything higher than 80.
    public static int GetDiscount (int quantity) 
    {
        if (quantity >= 0 && quantity <= 19)
        {
            return 0;
        }
        else if (quantity >= 20 && quantity <= 39)
        {
            return 10;
        }
        else if (quantity >= 40 && quantity <= 59)
        {
            return 20;
        }
       else if (quantity >= 60 && quantity <= 79)
        {
            return 30;
        }
        else if (quantity >= 80 && quantity <= 100)
        {
            return 40;
        }
        else 
        {
            return 40;
        }
    }

}

