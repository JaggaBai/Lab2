using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; } 
        public string Stanowisko{ get; set; }

        public double Wynagrodzenia { get; set; }
   


        public abstract void ObliczRoczneWynagrodzenie();
    }
    class Nauczyciel_Akad : Pracownik
    {
       public int Mnoznik { get; set; }

        public override void ObliczRoczneWynagrodzenie()
        {

            Console.WriteLine("Wynagrodzenie to " + (Wynagrodzenia*Mnoznik)*12);
        }
    }



    class PracownikDziekanatu: Pracownik
    {

        public override void ObliczRoczneWynagrodzenie()
        {

            Console.WriteLine("Wynagrodzenie to " + (Wynagrodzenia)*12);
        }
    }

    class Wozny : Pracownik
    {
        public int Dodatek_od_pracy_w_nocy { get; set; }
        public override void ObliczRoczneWynagrodzenie()
        {

            Console.WriteLine("Wynagrodzenie to " + (Wynagrodzenia+Dodatek_od_pracy_w_nocy) * 12);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pracownik pracownik1 = new PracownikDziekanatu
            { Imie = "Adam",
            Nazwisko= "Bielan",
            Stanowisko= "Asystent studenta",
           Wynagrodzenia= 2400,
           

            };



            Pracownik pracownik2 = new Nauczyciel_Akad
            {
                Imie = "Paweł",
                Nazwisko = "Olaf",
                Stanowisko = "Profesor",
                Wynagrodzenia = 2400,
                Mnoznik = 2,

            };


            Pracownik pracownik3 = new Wozny
                {
                Imie = "Paweł",
                Nazwisko = "Olaf",
                Stanowisko = "Wozny",
                Wynagrodzenia = 2400,
                Dodatek_od_pracy_w_nocy = 300,

            };
        


            pracownik1.ObliczRoczneWynagrodzenie();
            Console.WriteLine("\r\n");
            pracownik2.ObliczRoczneWynagrodzenie();
            Console.WriteLine("\r\n");
            pracownik3.ObliczRoczneWynagrodzenie();
            Console.ReadKey();
        }
    }
}
      