using System;

namespace rich_dad_poor_dad_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PoorPeopleIncomeStyle();
            

           

        }



        static void PoorPeopleIncomeStyle()
        {
            double daysOfYear = 0;
            double amountMoneyYouHave = 0;
            double MonthlyIncome = 10000;
            double stMonthPoor = 0;    //daysPoor
            while (daysOfYear != 360)//&& stMonthPoor <= 29 && stMonthPoor <= 59 && stMonthPoor <= 89 && stMonthPoor <= 119 && stMonthPoor <= 149 && stMonthPoor <= 179 && stMonthPoor <= 209 && stMonthPoor <= 239 && stMonthPoor <= 269 && stMonthPoor <= 299 && stMonthPoor <= 329 && stMonthPoor <= 359)
            {

                stMonthPoor += 30;
                daysOfYear += 30;

                if (stMonthPoor / 30 == 1 || stMonthPoor / 60 == 1 || stMonthPoor / 90 == 1 || stMonthPoor / 120 == 1 || stMonthPoor / 150 == 1 || stMonthPoor / 180 == 1 || stMonthPoor / 210 == 1 || stMonthPoor / 240 == 1 || stMonthPoor / 270 == 1 || stMonthPoor / 300 == 1 || stMonthPoor / 330 == 1 || stMonthPoor / 360 == 1)
                {
                    Console.WriteLine($"You made it throught another 30 days of finacial Hell \n");
                }

                double expenses = -40000;

                if (stMonthPoor == 270)
                {
                    Console.WriteLine("Now you want either a new Bike, Car, or another stupid shit wher you can impress your neighbours. - 40000");

                    amountMoneyYouHave += expenses;
                }

                double newAmountOM = amountMoneyYouHave += MonthlyIncome;  // trough setting the += you tell them to do this everytime:)

                if (stMonthPoor == 270)
                {
                    Console.WriteLine("Now you want either a new Bike, Car, or another stupid shit wher you can impress your neighbours. - 40000");

                    amountMoneyYouHave += expenses;
                }

                Console.WriteLine($"Your survived days:{daysOfYear} + your Theoretical Bank-Account:{newAmountOM}" +
                    $"but in fact with taxes and let`s say 20% of Food and another 30% for essentials and house problems" +
                    $"\n the rest your left with is ");
            }
            /* Days of Income 30
         What I do with this Money,
         Percentage that goes away with taxes
         That they will loose they Money by not investing them but still
         having to give this Money the purpose of obligation
        */

        }
            
    }





    /*/static void RichPeopleIncome()
    {

    /Days of income 30
     after these days giving percantages in to
     1.new investmenst that give you an addable amount of money
     2.take away that money you investet with
     3.needs less taxes
     4.takes away a little amount per month by misscalculations and to less infos
     investment not obligation.
     }
    */


    }

