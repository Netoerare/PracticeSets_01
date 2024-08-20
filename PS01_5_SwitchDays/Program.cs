using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_5_SwitchDays
{
    class Program
    {
        static void Main(string[] args)
        {
        const double Pi = 3.14;

        Console.Write("Enter your choice (A for area, P for perimeter, X to exit): ");
        char choice = Convert.ToChar(Console.ReadLine().ToUpper());

        Console.Write("Enter the radius of the circle: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        switch (choice)
            {
                case 'A':
                    int area = (int)(Pi * radius * radius);
                    Console.WriteLine($"The area of the circle is: {area}");
                    break;
    
                case 'P':
                    int perimeter = (int)(2 * Pi * radius);
                    Console.WriteLine($"The perimeter of the circle is: {perimeter}");
                    break;
    
                case 'X':
                    Console.WriteLine("Exiting the application.");
                    break;
            }
        }
    }
}
