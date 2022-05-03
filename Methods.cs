namespace metodylekcja
{
    public static class Methods
    {
        public static void metoda()
        {
            string test = string.Empty;
            test = "d";

            Console.WriteLine("string empty is "+test  + test.GetType());
            
            hello(test);
            //passnig by values
            string firstEmploye, secondEmploye;
            firstEmploye =" tomasz rys";
            secondEmploye = "natalia rys";
            Console.WriteLine($"inside main method \n...\n {firstEmploye}\n{secondEmploye}");
            changeName(firstEmploye, secondEmploye);
            Console.WriteLine($"inside main method \n...\n {firstEmploye}\n{secondEmploye}");

            //--------------------------------------------------------------------------------
            //passnig by ref
            string firstEmploye1, secondEmploye1;
            firstEmploye1 =string.Empty; //in ref variable  must be initialized before use 
                //or it we use out 
            //Console.WriteLine($"inside main method before ref \n...\n {firstEmploye1}\n{secondEmploye1}");
              Console.WriteLine($"inside main method before ref \n...\n {firstEmploye1}\n");
            changeNameRef(ref firstEmploye1, out secondEmploye1);
            Console.WriteLine($"inside main method after ref\n...\n {firstEmploye1}\n{secondEmploye1}");

        }

        public static void hello(string name)
        {
            Console.WriteLine($"imie {name}");
        }
        public static void changeName( string changeF, string changeS)
        {
            //passing by values
            changeF = "Marek burak";
            changeS = "Agata lopata";
            Console.WriteLine($"inside channgeName method  1: \n...\n {changeF} \n {changeS}");

        }
        public static void changeNameRef(ref string changeF,out string changeS)
        {
            //passing by values
            changeF = "Super man";
            changeS = "Bat man";
            Console.WriteLine($"inside channgeName method  1: \n...\n {changeF} \n {changeS}");

        }
        //ref zawsze zmieniaj wartości zmiennych, 
        //ref must be initialized before use
    }
}