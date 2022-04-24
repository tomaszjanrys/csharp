namespace loopslekcja;
    public static class Loops
    {
        public static void myLoops()
        {
            /* FOR */
            string txt = "C_SHARP_IS_COLL";
            for (int i = 0; i < txt.Length+1; i++)
            {
               var x =txt.Insert(i,"X");
                //Console.WriteLine("Liczba" + i);
                            Console.WriteLine(x);   
                if(x[i]=='X'){
                 var newChar = x.Replace('X','1');   
                Console.WriteLine(newChar.ToLower());
                } else{
                    Console.WriteLine("ERr");
                }            
            }
            /* END FOR */

        }
    }
