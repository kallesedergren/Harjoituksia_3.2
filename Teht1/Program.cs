using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            elevator.Floor = 1;
            int valinta = 1;

            while (valinta != 0)
            {
                Console.WriteLine("Welcome to the elevator! Please select a floor you want to go: ");
                valinta = int.Parse(Console.ReadLine());
                switch (valinta)
                {
                    case 1:
                        elevator.Floor = 1;
                        Console.WriteLine("Current floor: " + elevator.Floor);
                        break;
                    case 2:
                        elevator.Floor = 2;
                        Console.WriteLine("Current floor: " + elevator.Floor);
                        break;
                    case 3:
                        elevator.Floor = 3;
                        Console.WriteLine("Current floor: " + elevator.Floor);
                        break;
                    case 4:
                        elevator.Floor = 4;
                        Console.WriteLine("Current floor: " + elevator.Floor);
                        break;
                    case 5:
                        elevator.Floor = 5;
                        Console.WriteLine("Current floor: " + elevator.Floor);
                        break;
                }
            } 
            
            
              
        }
    }
}
