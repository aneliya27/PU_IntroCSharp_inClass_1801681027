using System;
using System.IO;

namespace CandyShop
{
    class Program
    {
        public static object Enconding { get; private set; }

        static void Main(string[] args)
        {
           
           // Console.OutputEncoding = Enconding.UTF8;
            
            //string firstName = Console.ReadLine();
            //string lastName = "Бончо";
            //string fullName=$"{firstName} {lastName}";
            //Console.WriteLine($" Candy for {fullName}!");

            string[] lines = File.ReadAllLines(@"C:\Users\fmi\Desktop\1b_A\PU_IntroCSharp_inClass_1801681027\W3InClass\CandyShop\files\students1.txt");

            Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                string[] currentElements = line.Split(' ');

                string firstName = currentElements[1];
                string lastName = currentElements[3];
                string fullName = $"{firstName} {lastName}";

                int sum = 0;
                for (int i = 0; i <firstName.Length; i++)
                {
                    sum += (int)firstName[i];
                        
                }
                Console.WriteLine($" Candy for {fullName}!=>{sum}");
                //Console.WriteLine("\t" + line);
            }
        }
    }
}
