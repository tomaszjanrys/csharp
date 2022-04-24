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

            /* 
            next example IndexOf, LastindexOf, subsrting, 
             */
             string tvGame = "Geme of Ttron   ";
             string season = "Season 1";
             string name = "!";


             Console.WriteLine("Litera o jest pod indexem nr :"+tvGame.IndexOf('o'));
             Console.WriteLine("Litera ostatnie o jest pod   indexem nr :"+tvGame.LastIndexOf('o'));
             Console.WriteLine("Substring  od 2 wycina 5 liter:"+tvGame.Substring(2,6));
             Console.WriteLine("Remove  od 2 wycina 5 liter:"+tvGame.Remove(7,4));
             Console.WriteLine("Remove  zaczyna 0 i usowa 5 liter:"+tvGame.Remove(1,5));
             Console.WriteLine("Zamienia litery:"+tvGame.Replace('T','X'));
             Console.WriteLine("Wstawia stringa:"+tvGame.Insert(5,"_tom_"));
            
/* exercise */
            Console.WriteLine(tvGame.Insert(tvGame.Trim().Length, season.Trim()));
            Console.WriteLine(tvGame.Trim().Replace("of",season).ToUpper().Insert(tvGame.LastIndexOf('n'),name));

        }
    }
}