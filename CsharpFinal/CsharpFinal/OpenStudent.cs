using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFinal
{



    public class Student : Person, IUpdatatable
    {
        public override void Greeting()
        {
            string separator = new string('#', 80);
            Console.WriteLine(separator);
            base.Greeting();
            Console.WriteLine($"I have started {Program} at {Start_Date.ToString("MMMM dd, yyyy")} in ITD Canada \n" +
                    $"I am able to develop code in the following programing langeuages");
            foreach (var item in Skillset)
            {
                Console.Write(item.Key+" ");

            }
            Console.WriteLine("\n");
            Console.WriteLine($"Updated : {Update_Date.ToString("MMMM dd, yyyy")}");
            Console.WriteLine(separator);
            Console.WriteLine("\n");
        }
        public Dictionary<string, bool> Skillset { get; set; }
        public string Program { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime Update_Date { get; set; }
    }

    public interface  IUpdatatable
    {

        DateTime Update_Date { get; set; }

    }

    public abstract class Person
    {
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }

        public virtual void Greeting()
        {
            Console.Write($"Hello, I am {Name} {Last_Name}, \n" +
            $"My email is {Email}\n");
        }
     
    }
}

    
