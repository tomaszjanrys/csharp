namespace randomnumlekcja
{
    public static class Randomnum
    {
        public static void randomNumer()
        {
            Console.WriteLine("____Random___Numer______");
            Random ran = new Random();
            int x =0;
            x = ran.Next(1,88);
            Console.WriteLine(x);
            for(int i = 0 ; i<31;i++)
            {
                int c =0;
                
                c = ran.Next(2,3);
                //Console.WriteLine("Wylosowano :"+c+"");

                double cc = 0;
                cc = ran.NextDouble()*c;
                double c2 = cc%i;
                Console.WriteLine("Random double :"+c2 + " Zaokraglam do :"+Math.Round(c2,6))           ;
              
            }
        }
    }
}