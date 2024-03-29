﻿namespace Badetidssystemet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opretter instanser/eksempler og printer dem ud til konsollen;


            Kreds kreds1 = new Kreds("4", "Kreds 1", "Maglehøjen", -10);
            Kreds kreds2= new Kreds("5", "Kreds 2", "Valby", 9);


            Console.WriteLine(kreds1);
            //Console.WriteLine(kreds2);


           try
              {
                Badetidsperiode badetidsperiode1 = new Badetidsperiode("type 1", DayOfWeek.Sunday, DateTime.Parse("06:30"), DateTime.Parse("08:30"));
                
              }
           catch (ArgumentException e)
              {
                 Console.WriteLine(e.Message);
              }

            Badetidsperiode badetidsperiode2 = new Badetidsperiode("type 2", DayOfWeek.Monday, DateTime.Parse("12:30"), DateTime.Parse("14:30"));


              Console.WriteLine(badetidsperiode1); 
              Console.WriteLine(badetidsperiode2);



            /// AdderKreds(); problemer med key


            badetidsperiode1.AdderKreds(kreds1);
            badetidsperiode2.AdderKreds(kreds2);

            // SletKreds();

            badetidsperiode1.SletKreds("1");
            badetidsperiode2.SletKreds("2");
        }
    }
}