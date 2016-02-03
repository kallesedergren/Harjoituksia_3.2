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
            int num;

            for (int i = 0; i < ; i++)
            {
                Console.WriteLine("You are currentyly in the " +elevator.Floor + " floor, give a floor number you wish to enter: ");
                elevator.Floor = int.Parse(Console.ReadLine());
            }
            
              
        }
    }
}
