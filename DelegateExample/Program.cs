using System;

namespace DelegateExample
{
    class Program
    {
        private delegate int Rechner(int zahl1, int zahl2);

        static void Main(string[] args)
        {
            Rechner rechner;

            rechner = new Rechner(Addiere);
            int ergebnis = rechner(3, 2);

            Console.WriteLine("Ergebnis der Addition:" + ergebnis); // 5

            rechner = new Rechner(Subtrahiere);
            ergebnis = rechner(3, 2);

            Console.WriteLine("Ergebnis der Subtraktion:" + ergebnis); // 1

            Console.ReadKey();


        }


        private static int Addiere(int zahl1, int zahl2)
        { return zahl1 + zahl2; }

        private static int Subtrahiere(int zahl1, int zahl2)
        { return zahl1 - zahl2; }
    }
}
