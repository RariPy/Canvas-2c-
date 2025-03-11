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
        shop.Add("a", 90);
        shop.Add("b", 34);
        shop.Add("c", 85);
        shop.Add("d", 80);
        shop.Add("e", 11);
        shop.Add("f", 26);                
        foreach (var ele in shop)
        {
            Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
        }
    }
}
