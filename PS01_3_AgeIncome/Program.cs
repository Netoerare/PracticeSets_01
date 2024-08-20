using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_3_AgeIncome
{
    class Program
    {
        static void Main(string[] args)
        {
           
        int age = 36;
        double income = 51000;

        if (age >= 25 && income > 50000)
        {
            Console.WriteLine("You are a Young Professional.");
        }
        else if (age >= 46 && income > 70000)
        {
            Console.WriteLine("You are a Middle-aged Professional.");
        }
        else if (age >= 56 && income < 30000)
        {
            Console.WriteLine("You are a Senior Citizen.");
        }
        else
        {
            Console.WriteLine("Other category.");
        }
        }
    }
}
