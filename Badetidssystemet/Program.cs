namespace Badetidssystemet
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Opretter instanser/eksempler og printer dem ud til konsollen;


            Kreds kreds1 = new Kreds("1", "Kreds 1", "Maglehøjen", 10);
            Kreds kreds2= new Kreds("2", "Kreds 2", "Valby", 9);

            Console.WriteLine(kreds1);
            Console.WriteLine(kreds2);



            Badetidsperiode badetidsperiode1 = new Badetidsperiode("type 1", DayOfWeek.Sunday, DateTime.Parse("06:30"), DateTime.Parse("08:30"));

            Console.WriteLine(badetidsperiode1);
        }
    }
}