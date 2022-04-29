namespace loopnestedlekcja
{
    public static class LoopNestes
    {
       public static void loopNested()
       {
           Console.WriteLine("_____LOOP_____NESTED_____\n \n \n ");
           for(int i =0 ,j=5 ;(j>i) && (i<j);i++,j--)
           {
               Console.WriteLine("First loop i = " + i + " Fisrt loop j =  "+j);
               for(int u=0;u<5;u++)
               {
                   Console.WriteLine("\tSecond Loops u = "+ u);
                   for (int o = 0 ;o<10 ;o++){
                       Console.WriteLine("\t\tThree loops o = "+ o);
                   }

               }
               Console.WriteLine("");
           }

      /*      for(int f=1 ; f<=10; f++)
           {
            
               for(int p =1; 1<10;p++)
               {
                   Console.Write("0"+p);
               }
           } */
       }
    
    }
}