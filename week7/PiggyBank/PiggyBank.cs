using System;

namespace PiggyBank
{
    class PiggyBank
    {
        static void Main(string[] args)
        {
            int days = 30;
            int saving = 2;//lv
            int throwAwayForFalseVodka = 5;//lv
            int monthsInYear = 12;
            double result = 0;
            try
            {
                int tankPrice = int.Parse(Console.ReadLine());
                int partyDays = int.Parse(Console.ReadLine());
                
                int sadDays = days-partyDays;
                int totalMonthSaving = sadDays * saving;
                int netSaving = totalMonthSaving - (throwAwayForFalseVodka * partyDays);

                double monthsForSaving4Tank = tankPrice / netSaving;

                 result = monthsForSaving4Tank / monthsInYear;

                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("Please,try again later as entering numbers!");
            }
            if (result < 0) Console.WriteLine("Never!");
            else
            {
                result = Math.Round(result, 1, MidpointRounding.AwayFromZero);
                //Console.WriteLine($"{result} years");
                string months = result.ToString().Split(',')[1];
                Console.WriteLine($"{(int)result} years {months} months");
            }
            

        }
    }
}
