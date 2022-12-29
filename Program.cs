using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("                       this program print prime numbers from first num to second num ."); 
            Console.WriteLine("enter first num : ");
            int firstnum=int.Parse(Console.ReadLine()); 
            Console.WriteLine("enter second num : ");
            int secondnum = int.Parse(Console.ReadLine());
            Console.WriteLine("  ");
            for(int i = firstnum; i <= secondnum; i++)
            {
                int counter = 0;
                for(int j=2;j<=i/2;j++)
                {

                    if(i%j==0)
                    {

                        counter++;
                        break;


                    }
                }
                if (counter == 0 && i != 0)
                {
                    Console.WriteLine(i);
                }



            }
            Console.ReadKey();
        }







    }
    }

