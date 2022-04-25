namespace loopslekcja;

    public static class Looops
    {
        public static void looops()
        {
     int x =0;
            while(x<=4)
            {
                DateTime data = new DateTime();

                 data = DateTime.Today;
                string myData1 = string.Format("rok {0:yyyy,MMMM}",data); 
                  
                Console.WriteLine($"While {x} {myData1.Insert(myData1.Length," XXX")} ");
                x++;
          
            }
                  int num =1;
                do
                {
                    Console.WriteLine("Do while"+num);
                    num++;
                }while(num<10);
        }
    }
