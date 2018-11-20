using System;

namespace week8TextBombardment
{
    class TextBombardment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence you wish to bombard:");
            string sentence =Console.ReadLine() ;
            try
            {
                int lineWidth = int.Parse(Console.ReadLine());
                string bombIndex = Console.ReadLine();
                Console.WriteLine(sentence);
                Console.WriteLine(lineWidth);
                Console.WriteLine(bombIndex);


                double rows = sentence.Length / lineWidth;
               
                    for (int i = 0; i < sentence.Length; i++)
                    {
                        Console.Write(sentence[i]);
                        if (i/(lineWidth-1)==1)
                        {
                            Console.Write("\n");
                        }
                    }
                Console.WriteLine();
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
         

        }
    }
}
