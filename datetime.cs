using System;
using System.Xml.Linq;
using System.Linq;
namespace lekcjaDatetime
{
    public static class datetime
    {
        public static void lesson()
        {
            //i assing specify date 
            DateTime myData = new DateTime(1999,4,11);

         Console.WriteLine(myData);   

         myData = DateTime.Today;

         Console.WriteLine("Actual date to day:"+myData);   

         myData = DateTime.Now;
           Console.WriteLine("Actual date to day and hours:"+myData);  
        
        myData = DateTime.Now;
          Console.WriteLine("Actual SHORT date to day:"+myData.ToShortDateString());  
        myData = DateTime.Now;
          Console.WriteLine("Actual LONG date to day:"+myData.ToLongDateString()); 
        myData = DateTime.Now;
        //we can +- day months yeasr min sek itd
          Console.WriteLine("i added 10 days to actual date :"+myData.AddDays(365));   
        myData = DateTime.Now;
        string dateMyFormat = string.Format("Year is {0:yyyy MM dddd HH mm ss ms tt}",myData);
          Console.WriteLine(dateMyFormat);  
          DateTime reminderTime = new DateTime();

          reminderTime = DateTime.Now;
          Console.WriteLine($"Dzis jest {reminderTime.ToLongDateString()}");
          string data1= "";
          data1= string.Format("Dzis jest {0:dddd} w miesiacu {0:MMMM} roku Panskiego {0:'Roku'yy \n'Godzina' HH}",reminderTime);
          Console.WriteLine(data1);
          if(reminderTime.Hour>14)
          {
            for (int i = 0; i < 5; i++)
            {
              var data = reminderTime.AddHours(i);
              Console.WriteLine(data);
            }
            Console.WriteLine("Jest po poludniu");
          }
        }
    }
}