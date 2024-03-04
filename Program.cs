using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Working with Strings tutorials
             * List<string> names = ["Ruby", "anna", "Gamal"];
             foreach(string name in names)
             {
                 Console.WriteLine($"name is {name.ToUpper()}");
             }
             Console.WriteLine();

             names.Add("new name1");
             names.Add("new name2");
             names.Remove("Gamal");
             foreach (string name in names)
             {
                 Console.WriteLine($"name is {name.ToUpper()}");
             }
             Console.WriteLine($"My name is {names[0]}");
             Console.WriteLine($"I have added name {names[2]} to the end of the list and {names[3]}");
             Console.WriteLine($"the amount of names i have is  {names.Count}");

             var index = names.IndexOf("Ruby");
            if (index==-1)
                 Console.WriteLine($"this name does not exist so it returned {index}");
            else Console.WriteLine($"this name does  exist so it returned {index}");
              index = names.IndexOf("Nobody");
             if (index == -1)
                 Console.WriteLine($"this name does not exist so it returned {index}");

          else Console.WriteLine($"this name does  exist so it returned {index}");
             names.Sort();
             foreach (string name in names)
             {
                 Console.WriteLine($"name is {name.ToUpper()}");
             } */


            //Challenge for lists .
            List<int> fibonacci = [1, 1];
            for (int i = 0; i < 18; i++)
            {
                fibonacci.Add( fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2]);
            }
            foreach(int i in fibonacci)
            {
                Console.WriteLine($" fibbonaci {fibonacci.IndexOf(i)} is {i}");
            }




        }
    }
}
