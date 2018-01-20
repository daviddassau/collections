using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreNewStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            var things = new List<string>();

            things.Add("this is a string");
            things.Remove("this is a string");
            things.AddRange(new List<string> { "david", "lindsay", "charlie" });
            var shouldBeFalse = things.Contains("this is a string");

            var thing = things[2]; // this will target 'charlie'

            //var myDictionary = new Dictionary<string,int>();
            //myDictionary.Add("firstKey",12345);
            //var myValue = myDictionary["firstKey"]; // in this case, the variable 'myValue' is equal to 12345

            var myNewDictionary = new Dictionary<string, Food>
            {
                {"firstKey", new Food { Name = "Carrots", GlutenFree = true }},
                {"second", new Food { Name = "Bread", GlutenFree = false }},
                {"third", new Food { Name = "Meat", GlutenFree = true }}
            };

            if (myNewDictionary.ContainsKey("david"))
            {
                Console.WriteLine("Never going to get here");
            }

            foreach (var food in myNewDictionary.Values)
            {
                Console.WriteLine($"Food is {food.Name}");
            }

            foreach (var key in myNewDictionary.Keys)
            {
                Console.WriteLine($"Key is {key}");
            }

            foreach (var item in myNewDictionary)
            {
                Console.WriteLine($"{item.Key} is the key for {item.Value.Name}");
            }

            var newFoodThing = new Food { Name = "Pizza", GlutenFree = false };
            newFoodThing.GetHashCode();
            var sameThing = newFoodThing;

            var int1 = 1;
            var int2 = 1;

            if (int1 == int2)
            {
                Console.WriteLine("This is value equality");
            }

            if (newFoodThing == sameThing)
            {
                Console.WriteLine("Yes, they are the same");
            }

            if (newFoodThing.GetHashCode() == sameThing.GetHashCode())
            {
                Console.WriteLine("Told you so.");
            }



            var hashset = new HashSet<Food>();
            hashset.Add(new Food { Name = "Broccoli", GlutenFree = false });

            foreach (var food in hashset)
            {

            }

            // If you're writing more, use a List. If you're reading more, use a HashSet.




        }
    }
}
