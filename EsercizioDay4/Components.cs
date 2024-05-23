using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioDay4
{
    public class Components
    {
        public void printMessages(int message) 
        {
            if (message == 1) // if statement
            {
                Console.WriteLine("Enter the Amount of sheep the shepard needs to watch over:");
            }
            switch (message) //switch statement
            {
                case 2:
                    Console.WriteLine("Enter the Amount of space the shepard has available (Km2):");
                    break;
                case 3:
                    Console.WriteLine($"The shepard will need {NrOfDogs(Program.nrOfSheep)} dogs"); 
                    break;
                case 4:
                    Km2(new Program().spaceAvailable);
                    break;
                default:
                    break;
            } 

        }
        public static double NrOfDogs(double sheep) //static returns double
        {
            double DogsAmt = Math.Ceiling((sheep-50) / 50);
            return DogsAmt;
            
        }
        
        public static void Km2(double space) //static returns nothing
        {
            double available = Program.nrOfSheep / space;
            if((Program.nrOfSheep / space) > 50.0)
            {
                Console.WriteLine("The shepard does not have enough space");                
            }
            else if((Program.nrOfSheep / space) <= 50.0 )
            {
                Console.WriteLine("The shepard has enough space");
            }
            

        }

    }
}
