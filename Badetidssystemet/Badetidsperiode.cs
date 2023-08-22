using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Reflection;

namespace Badetidssystemet
{
    internal class Badetidsperiode
    {


        // Instansfelter

        private string type;
        private DayOfWeek ugeDag;
        private DateTime startTidspunkt;
        private DateTime slutTidspunkt;

        Dictionary<string, Kreds> kredse = new Dictionary<string, Kreds>();


        //Properties

        public string Type
        {
            get { return type; } 
            set
            {
                if(value.Length >= 4)
                {
                    type = value;
                }

                else
                {
                    Console.WriteLine("Type skal være mindst 4 tegn lang.");
                }
            }
        }


        public DayOfWeek UgeDag { get { return ugeDag; } }

        public DateTime StartTidspunkt
        { 
            get { return startTidspunkt; }
            set
            {
                if (value <= slutTidspunkt)
                {
                    startTidspunkt = value;

                    
                }
                else
                    Console.WriteLine("Starttidspunkt må ikke være efter sluttidspunkt.");
            }

        }
        

       

        public DateTime SlutTidspunkt { get { return slutTidspunkt; } }




       

        //Konstruktør



        public Badetidsperiode(string Type, DayOfWeek UgeDag, DateTime StartTidspunkt, DateTime SlutTidspunkt)
        {
            type = Type;
            ugeDag= UgeDag;
            startTidspunkt= StartTidspunkt;
            slutTidspunkt= SlutTidspunkt;

            //Dictionary

           


            Kreds kreds1 = new Kreds("1", "Kreds 1", "Maglehøjen", 10);
            Kreds kreds2 = new Kreds("2", "Kreds 2", "Valby", 9);

            kredse["1"] = kreds1;
            kredse["2"] = kreds2;

        }

        // Tilføjer metoden adderkreds

        public void AdderKreds(Kreds kreds)
        {
            kredse.Add(kreds.ID, kreds);
        }

        // Tilføjer metoden SletKreds() 

        public void SletKreds(string id)
        {
            kredse.Remove(id);
        }



        // ToString() metode: 
        public override string ToString()
        {
            return $" Type: {Type}, Ugedag: {UgeDag}, StartTidspunkt: {StartTidspunkt}, SlutTidspunkt: {SlutTidspunkt}";
        }
    }
}
