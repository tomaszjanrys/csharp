namespace lekcja2
{
    public static class test
    {
        public static void learn1()
        {
            sbyte c = 0;
             c= SByte.MaxValue;
             string x ="d";
            
            float flo = 0;
            flo = float.MaxValue;
            double dou = 0;
            dou = double.MaxValue;

    
            Console.WriteLine(typeof(int).IsValueType);
            Console.WriteLine(flo+" "+dou);
//precision float double decimal
            float floatNum = 0.0f;
            double doubleNum = 0.0d;
            decimal decimalNum = 0.0m;

            floatNum = 1 / 3f;
            doubleNum = 1 /3d;
            decimalNum = 1 / 3m;
            Console.WriteLine("Float {0} \n Double  {1} \n Decimal {2} \n", floatNum,doubleNum,decimalNum);


        }
    }
}