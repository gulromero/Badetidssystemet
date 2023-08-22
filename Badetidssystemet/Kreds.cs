using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Badetidssystemet
{
    internal class Kreds
    {


        //Opretter instansfelter

        private string id;
        private string navn;
        private string adresse;
        private int antalDeltagere;

        //properties

        public string ID { get { return id;} }
        public string Navn { get { return navn; } } 
        public string Adresse { get { return adresse; } }
        public int AntalDeltagere
        { 
            get { return antalDeltagere; }
            set
            {
                if (value >= 1)
                {
                    antalDeltagere = value;
                }

                else
                {
                    //Console.WriteLine("Antallet af deltagere skal være mindst 0.");
                    throw new ArgumentException("Antallet af deltagere skal være mindst 0.");
                }
            }
        
        }


        // Kontruktør

        public Kreds(string ID, string Navn, string Adresse, int AntalDeltagere)
        {
            id = ID;
            navn = Navn;
            adresse = Adresse;
            antalDeltagere = AntalDeltagere;
        }



        //ToString() metode

        public override string ToString() 
        {
            return $" ID: {ID}, Navn: {Navn}, Adresse: {Adresse}, Antal Deltagere: {AntalDeltagere}";
        }
    }
}
