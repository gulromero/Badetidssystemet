using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badetidssystemet
{
    internal class Badetidsperiode
    {


        // Instansfelter

        private string type;
        private DayOfWeek ugeDag;
        private DateTime startTidspunkt;
        private DateTime slutTidspunkt;




        //Properties

        public string Type { get { return type; } }
        public DayOfWeek UgeDag { get { return ugeDag; } }

        public DateTime StartTidspunkt { get { return startTidspunkt; } }

        public DateTime SlutTidspunkt { get { return slutTidspunkt; } }




       

        //Konstruktør



        public Badetidsperiode(string Type, DayOfWeek UgeDag, DateTime StartTidspunkt, DateTime SlutTidspunkt)
        {
            type = Type;
            ugeDag= UgeDag;
            startTidspunkt= StartTidspunkt;
            slutTidspunkt= SlutTidspunkt;

            //Dictionary

            Dictionary<string, Kreds> kredse = new Dictionary<string, Kreds>();


            Kreds kreds1 = new Kreds("1", "Kreds 1", "Maglehøjen", 10);
            Kreds kreds2 = new Kreds("2", "Kreds 2", "Valby", 9);

            kredse["1"] = kreds1;
            kredse["2"] = kreds2;

        }

        // ToString() metode: 


        public override string ToString()
        {
            return $" Type: {Type}, Ugedag: {UgeDag}, StartTidspunkt: {StartTidspunkt}, SlutTidspunkt: {SlutTidspunkt}";
        }
    }
}
