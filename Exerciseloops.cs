namespace exerciseloopslekcja
{
    public static class Exerciseloops
    {
        public static void exerLoops()
        {
        /*     for(int i = 1;i<100;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i+", ");
                } 

            } */
            for (int i =0 ; i<5;i++)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
        }
        
    }
}