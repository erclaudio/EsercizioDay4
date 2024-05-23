using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioDay4
    /*
     * Assume a shepard wants a system to understand how many sheep he can keep under control at once. 
     * He tells you he can watch over 50 sheep in an area of 1km squared. 
     * He can however use dogs to increase the number of sheeps he can watch. 
     * 1 dog adds 50 sheep per sqare kilomenter.
     * He receives requests with the number of sheep he needs to watch over and the amount of space he has available.
     * Write a program to understand if he needs any dogs to watch over the sheep and how many dogs he needs.
     * Assume that to watch more than 50 sheep he needs a new dog each time.
     * Assume no more than 50 sheep fit in 1 square km.
     */
{
    
    public class Program
    {

        public static int nrOfSheep; //static members
        public float spaceAvailable; //non static members
        static void Main(string[] args)
        {

            Components components = new Components(); //instantiate with variable
            components.printMessages(1);
            nrOfSheep = Convert.ToInt32(Console.ReadLine());
            new Components().printMessages(2); //instantiate inline            
            components.printMessages(3);
            components.printMessages(4);
            Console.WriteLine("Try Again: \n");
            Main(args);
        }
    }
}
