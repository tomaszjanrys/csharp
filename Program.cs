
int x = 1;
double x1 = (double) x;
Console.WriteLine("Rzutowanie Int :"+x.GetType() + " na  Typ :"+x1.GetType());
//this it  type casting

static void metoda(string tekst="you did no provide argument")
{
    Console.WriteLine("Metoda :"+ tekst);
}

//metoda

metoda();
metoda(tekst:"I am Hero");
//