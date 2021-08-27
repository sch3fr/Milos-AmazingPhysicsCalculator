using System;

namespace consoleMAPC
{
    class Program
    {
        static void Main(string[] args)//TODO převodník jednotek
        {
            bool quitSwitch = false; //makes the do-while loop run, thus letting user choose again and agian
            char choice; //used to navigate menu
            Menu(); //clears console window and writes wall of text

            do
            {
                choice = Console.ReadKey().KeyChar; //reads keypress
                switch (choice)
                {
                    case '1': //mechanika
                        bool localSwitch = false; //same functionality as quitSwitch, just in another loop
                        char localChoice; //used to navigate submenu
                        int easterEgg = 0; // :)
                        Console.Clear();
                        Console.WriteLine("Mechanika\n\nCo počítáme?\nPro výběr zmáčkni klávesu před veličinou (a-j)\n");
                        Console.WriteLine("a. rychlost\nb. zrychlení\nc. čas\nd. dráhu\ne. hybnost\nf. sílu\ng. výkon\nh. rychlost vody\ni. tlak\nj. hustota");

                        do
                        {
                            localChoice = char.ToLower(Console.ReadKey().KeyChar);
                            switch (localChoice)
                            {
                                case 'a'://rychlost
                                    Rychlost();
                                    localSwitch = true;
                                    break;
                                case 'b'://zrychlení
                                    Zrychleni();
                                    localSwitch = true;
                                    break;
                                case 'c'://čas
                                    MechanikaCas();
                                    localSwitch = true;
                                    break;
                                case 'd'://dráha
                                    Draha();
                                    localSwitch = true;
                                    break;
                                case 'e'://hybnost
                                    Hybnost(); //ještě nefunguje 
                                    break;
                                case 'f'://síla
                                    Sila();
                                    break;
                                case 'g'://výkon
                                    Vykon();
                                    break;
                                case 'h'://rychlost vody
                                    RychlostVody();
                                    break;
                                case 'i'://tlak
                                    Tlak();
                                    break;
                                case 'j'://hustota
                                    Hustota();
                                    break;
                                default:
                                    if (easterEgg < 8)
                                    {
                                        Console.WriteLine("\nMusíš vybrat jedno z výše uvedených písmen");
                                        easterEgg++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nHele mě už to nebaví. Jestli budeš dělat kraviny tak se ukončím >:(");
                                    }
                                    break;
                            }
                        }
                        while (localSwitch == false);
                        Menu();
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
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Milošova kvalitní fyzikální kalkulačka <3 v 0.1");
            Console.WriteLine("\nVyberte si obor, z něhož je váš příklad.");
            Console.WriteLine("\n1. Mechanika\n2. Molekulová fyzika a termika\n3. Mechanické kmitání a vlnění\n4. Elektřina a magnetismus\n5. Optika\n6. Teorie relativity\n7. Fyzika mikrosvěta\n\nZmáčkněte 0 pro ukončení programu.");
        }
        public static void Rychlost()
        {
            Console.WriteLine("\nZadejte dráhu v m");
            double draha = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte čas v s");
            double cas = Convert.ToDouble(Console.ReadLine());
            double vysledenaRychlost = draha / cas;
            Console.WriteLine("\nVýsledek je {0} m.s^-1", vysledenaRychlost);
            Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
            Console.ReadKey();
        }
        public static void Zrychleni()
        {
            Console.WriteLine("\nZadejte změnu rychlosti v m.s^-1");
            double rychlostDelta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte čas v s");
            double casDelta = Convert.ToDouble(Console.ReadLine());
            double vysledneZrychleni = rychlostDelta / casDelta;
            Console.WriteLine("\nVýsledek je {0} m.s^-2", vysledneZrychleni);
            Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
            Console.ReadKey();
        }
        public static void MechanikaCas()
        {
            Console.WriteLine("\nPočítáme dobu vzhledem k\na. rychlosti, nebo \nb. ke zrychlení?");
            char vyber = char.ToLower(Console.ReadKey().KeyChar);
            while ((vyber != 'a') && (vyber != 'b'))
            {
                Console.WriteLine("Prosím vyberte možnost 'a' nebo 'b'");
                vyber = char.ToLower(Console.ReadKey().KeyChar);
            }
            if (vyber == 'a')
            {
                Console.WriteLine("Zvolili jste možnost a");

                Console.WriteLine("\nZadejte dráhu v m");
                double draha = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Zadejte rychost v m.s^-1");
                double rychlost = Convert.ToDouble(Console.ReadLine());
                double vysledenyCas = draha / rychlost;
                Console.WriteLine("\nVýsledek je {0} s", vysledenyCas);
                Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
                Console.ReadKey();

            } else
            {
                Console.WriteLine("Zvolili jste b");

                Console.WriteLine("\nZadejte změnu rychlosti v m.s^-1");
                double deltaRychlost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Zadejte zrychleni v m.s^-2");
                double zrychleni = Convert.ToDouble(Console.ReadLine());
                double vysledenyCas = deltaRychlost / zrychleni;
                Console.WriteLine("\nVýsledek je {0} s", vysledenyCas);
                Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
                Console.ReadKey();
            }
            
        }
        public static void Draha()
        {
            Console.WriteLine("\nZadejte rychlost v m.s^-1");
            double rychlost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte čas v s");
            double cas = Convert.ToDouble(Console.ReadLine());
            double vysledenaDraha = rychlost * cas;
            Console.WriteLine("\nVýsledek je {0} m", vysledenaDraha);
            Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
            Console.ReadKey();
        }
        public static void Hybnost()
        {
            Console.WriteLine("\nZadejte hmotnost v kg");
            double hmotnost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte rychlost v m.s^-1");
            double rychlost = Convert.ToDouble(Console.ReadLine());
            double vysledenaHybnost = hmotnost * rychlost;
            Console.WriteLine("\nVýsledek je {0} kg·m·s^-1", vysledenaHybnost);
            Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
            Console.ReadKey();
        }
        public static void Sila()
        {

        }
        public static void Vykon()
        {

        }
        public static void RychlostVody()
        {

        }
        public static void Tlak()
        {

        }
        public static void Hustota()
        {

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
