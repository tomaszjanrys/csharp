using lekcja2;
using lekcjaDatetime;
using errorlekcja;
using myswitchlekcja;
using tryparselekcja;
using constantsExample;
using stringmanipulationslekcja;
using loopslekcja;
using loopnestedlekcja;


int x = 1;
double x1 = (double) x;
Console.WriteLine("Rzutowanie Int :"+x.GetType() + " na  Typ :"+x1.GetType());

int age = 33;
string ageString = age.ToString();

Console.WriteLine("Age to casting on string " + ageString + "Age type"+age.GetType()+"Age after casting" + ageString.GetType());

int age1 = 33;

decimal age1int= (decimal)age1;

Console.WriteLine(age1.GetType()+"->"+age1int.GetType());

//this it  type casting

static void metoda(string tekst="you did no provide argument")
{
    Console.WriteLine("Metoda :"+ tekst);
}

//metoda

metoda();
metoda(tekst:"I am Hero");
//
//Type
double doublenum = 2.2d;
doublenum= 33.33;
decimal decnum = 10.0m;
decnum=33.66m;
char charX= '2';
Console.WriteLine("Double :" + doublenum + "Decimal num :"+ decnum+ "Char is :" + charX);
string name , surname;
name = "Bat";
surname = "Man";
Console.WriteLine($"Your name {name} and surname  {surname} ->"+ name+surname);

bool IsWorking;

IsWorking = false;

Console.WriteLine("Bool "+ IsWorking);
test.learn1();

datetime.lesson();



Console.WriteLine(error.myErr(19,5));
/* 
switch
 */
Myswitch.mytest();

/* 

try parse
 */
Tryparse.myParse();

/* 

OCNSTATNTS
 */
Constantsexample.myConst();

/* 
PROMMPT 

 */
Stringmanipulations.myString();


/* 
loops FOR
s
 */

 Loops.myLoops();
LoopNestes.loopNested();
