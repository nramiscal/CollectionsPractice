using System;
using System.Collections.Generic;


namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {0,1,2,3,4,5,6,7,8,9};
            string[] names = {"Tony", "Martin", "Nikki", "Sara"};
            bool[] trueOrFalse = {true,false,true,false,true,false,true,false,true,false};

            List<string> iceCreamFlavors = new List<string>();
            iceCreamFlavors.Add("Mint Chocolate Chip");
            iceCreamFlavors.Add("Butter Pecan");
            iceCreamFlavors.Add("Rocky Road");
            iceCreamFlavors.Add("Green Tea");
            iceCreamFlavors.Add("Black Raspberry");
            // Console.WriteLine(iceCreamFlavors.Count);
            // Console.WriteLine(iceCreamFlavors[2]);
            // iceCreamFlavors.RemoveAt(2);
            // Console.WriteLine(iceCreamFlavors.Count);

            Dictionary<string,string> dict = new Dictionary<string,string>();
            // foreach (string name in names){
            //     dict.Add(name, null);
            // }
            Random rand = new Random();
            foreach (string name in names){
                dict.Add(name, iceCreamFlavors[rand.Next(0, names.Length)]);
            }
            foreach (var entry in dict)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }

        }
    }
}
