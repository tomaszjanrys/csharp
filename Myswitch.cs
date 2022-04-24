namespace myswitchlekcja
{
    public static class Myswitch
    {
        public static void mytest()
        {
            Console.WriteLine("Swicht");


            DateTime data = new DateTime();

            data = DateTime.Now;
             
            string mydata = string.Format("{0:dddd}",data);


            switch(mydata)
            {
                case "niedziela":
                    Console.WriteLine("Dzisiaj jest :" + mydata);
                    break;
                case "test":
                    Console.WriteLine("no");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej opcji");
                    break;

            }

        }
    }
}