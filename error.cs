using System.Runtime.CompilerServices;
using System;
namespace errorlekcja
{
    public static class error
    {


        static public decimal myErr(decimal a , decimal b)
        {
            try
            {
            
            Console.WriteLine("Typ"+a.GetHashCode());

                
                return a %b;    
            }
            catch (Exception err)
            {
                Console.WriteLine("Dzielisz przez zero"+err.Message);
                throw;
                
            }
            
           
        }
    }
}