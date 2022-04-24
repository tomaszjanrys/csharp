using System;

namespace tryparselekcja
{
    public static class Tryparse
    {
        public static void myParse()
        {
           string x ="1dss111";// zwraca 0

            decimal.TryParse(x, out decimal x1);
            //

           Console.WriteLine("Wprowadziles : " + x1 + "Type orginalny :"+x.GetType() +" Typ po TryParse" + x1.GetType()); 
           //przy zlej wprowadzonej wartosci zwaracanie jest  zero
           switch(x1)
           {
               case 0:
                Console.WriteLine("Wprowadziles zle dane");
                break;

           }


        }
    }
}