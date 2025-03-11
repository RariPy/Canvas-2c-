using System.Runtime.CompilerServices;
using System.Collections.Generic;
namespace task2;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)   
    {  
        Dictionary<string, int> shop = new Dictionary<string, int >();
        shop.Add("a", 10);
        shop.Add("b", 20);
        shop.Add("c", 30);
        shop.Add("d", 50);
        shop.Add("e", 70);
        shop.Add("f", 80);

        foreach (var item in shop)
        {
           int Discount = GetDiscount(item.Value); 
            Console.WriteLine($"item {item.Key}, quantity:{item.Value}, Discount = {Discount}%" );
        }
        while (true)
        {
           Console.WriteLine("Enter item name"); 
           string ItemName = Console.ReadLine();
           Console.WriteLine($"Enter quantity for {ItemName}");
           int quantity = Convert.ToInt32(Console.ReadLine());
           shop.Add(ItemName, quantity);
           break;
        }
        foreach (var item in shop)
        {
            int Discount = GetDiscount(item.Value); 
             Console.WriteLine($"item {item.Key}, quantity:{item.Value}, Discount = {Discount}%" );
        }
   
    }
    // (Publtic static int) creates a public class that allows (int Discount = GetDiscount(item.Value);) to access it 
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
        else if (quantity >= 80 && quantity <= 10)
        {
            return 40;
        }
        else 
        {
            return 40;
        }
    }

}

