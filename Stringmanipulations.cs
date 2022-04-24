namespace stringmanipulationslekcja
{
    public class Stringmanipulations
    {
        public static void myString()
        {
            string words = "        Ala ma kota a kot ma ale ale Ula nie ma juz kota";
            //liczy od 0 
        

           /* Indexex */ 
            for(var i=0;i<words.Length;i++){
            Console.Write(""+words[i]);
            }
            Console.WriteLine(words[0]);
            /* 
            TRIM
             */
             Console.WriteLine("Bez trim =>"+words.Length);
            Console.WriteLine("uSuwam biale zniaki Trim =>"+words.Trim().Length);
             /* 
             
             upper case  lowercase
              */
                Console.WriteLine(words.Trim().ToUpper()+" _ "+ words.ToLower());
              /* 
              
        
            /* REPLACE */

            Console.WriteLine(words.Replace('m','X').Trim());
        }
    }
}