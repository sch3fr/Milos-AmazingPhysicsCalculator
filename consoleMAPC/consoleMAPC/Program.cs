using System;

namespace consoleMAPC
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quitSwitch = false;
            char choice;
            string menu = "\n1. Mechanika\n2. Molekulová fyzika a termika\n3. Mechanické kmitání a vlnění\n4. Elektřina a magnetismus\n5. Optika\n6. Teorie relativity\n7. Fyzika mikrosvěta\n\nZmáčkněte 0 pro ukončení programu.";

            Console.WriteLine("Milošova kvalitní fyzikální kalkulačka <3 v 0.1");
            Console.WriteLine("\nVyberte si obor, z něhož je váš příklad.");
            Console.WriteLine(menu);

            do
            {
                choice = Console.ReadKey().KeyChar;
                switch (choice) 
                {
                    case '1': //mechanika
                        Mechanika();
                        break;
                    case '2': //molekulová fyzika a termika
                        MoleTermik();
                        break;
                    case '3': //mechanické kmitání a vlnění
                        KmitVln();
                        break;
                    case '4': //elektřina a magnetismus
                        ElMag();
                        break;
                    case '5':  //optika
                        Optika();
                        break;
                    case '6': //speciální teroie relativity
                        Str();
                        break;
                    case '7': //fyzika mikrosvěta
                        Mikro();
                        break;
                    case '0':
                        quitSwitch = true;
                        break;
                    default:
                        Console.WriteLine("Dobrej pokus, ale prosím zadej číslo od 0 - 7.");
                        break;
                }
            } while (quitSwitch == false);




        }
        public static void Mechanika()
        {
            Console.Clear();
            Console.WriteLine("Mechanika");
        }
        public static void MoleTermik()
        {
            Console.Clear();
            Console.WriteLine("Molekulová fyzika a termika");
        }
        public static void KmitVln()
        {
            Console.Clear();
            Console.WriteLine("Kmitání a vlnění");
        }
        public static void ElMag()
        {
            Console.Clear();
            Console.WriteLine("Elektřina a magnetismus");
        }
        public static void Optika()
        {
            Console.Clear();
            Console.WriteLine("Optika");
        }
        public static void Str() 
        {
            Console.Clear();
            Console.WriteLine("Speciální teorie relativity");
        }
        public static void Mikro()
        {
            Console.Clear();
            Console.WriteLine("Fyzika mikrosvěta");
        }
        
    }
}
