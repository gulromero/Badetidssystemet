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

        private string _id;
        private string _navn;
        private string _adresse;
        private int _antalDeltagere;

        //properties

        public string ID { get { return _id;} }
        public string Navn { get { return _navn; } } 
        public string Adresse { get { return _adresse; } }
        public int AntalDeltagere
        { 
            get { return _antalDeltagere; }
            set
            {
                if (value >= 1)
                {
                    _antalDeltagere = value;
                }

                else
                {
                    Console.WriteLine("Antallet af deltagere skal være mindst 0.");
                    // throw new ArgumentException("Antallet af deltagere skal være mindst 0.");
                }
            }
        
        }


        // Kontruktør

        public Kreds(string id, string navn, string adresse, int antalDeltagere)
        {
            ID = id;
            Navn = navn;
            Adresse = adresse;
            AntalDeltagere = antalDeltagere;
        }



        //ToString() metode

        public override string ToString() 
        {
            return $" ID: {ID}, Navn: {Navn}, Adresse: {Adresse}, Antal Deltagere: {AntalDeltagere}";
        }
    }
}
