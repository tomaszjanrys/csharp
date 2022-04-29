namespace arrayslekcja
{
    public static class Arrays
    {
        public static void myArray()
        {
            Random ran = new Random();
      
            double[]  numbers = new double[20];
            string[] num = new string[4]{"banan","jabko","kiwi","jagoda"};
            string[] weekdays = {"pon","wt","sr","czw","pt","sob","niedz"};

            for(var i =0;i<20;i++)
            {
                double ran1 = ran.Next(1,200);
                //i wskazuje na nr indesku i przypisuje do niego wartosc
                numbers[i]=ran1;
                
                Console.WriteLine(ran1);
            }
        
            Console.WriteLine(numbers.Length+"_"+ num.Length);
            //for each lambda
            Array.ForEach(numbers,(el)=>Console.WriteLine("|||"+"Foreach LAMBDA"+el));
            //for each
            foreach(var name in weekdays){
                Console.WriteLine("For each in"+name);
            }
            for(int i=0;i<num.Length;i++)
            {
                Console.WriteLine("String"+num[i]);
            }
            for(int i = 0 ;i<weekdays.Length;i++)
            {
                Console.WriteLine("Dni tygodnia "+ weekdays[i]);

            switch(weekdays[i])
            {
                case("pon"):
                    Console.WriteLine("Do roboty");
                    break;
                case("wt"):
                    Console.WriteLine("Do piero wtorek");
                    break;
                case("sr"):
                    Console.WriteLine("Srodek tygodnia");
                    break;
                case("czw"):
                    Console.WriteLine("Jutro weekend");
                    break;
                case("pt"):
                    Console.WriteLine("Hurra impreza");
                    break;
                case("sob"):
                    Console.WriteLine("Sobota spimy");
                    break;
                case("niedz"):
                    Console.WriteLine("Do kosciola");
                    break;
                default:
                    Console.Write("Cos poszlo nie tak");
                    break;
                
            }
    


            }

            



        }
    }
}