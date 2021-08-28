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
                                    Console.WriteLine("\nZadejte dráhu v m");
                                    double adraha = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Zadejte čas v s");
                                    double acas = Convert.ToDouble(Console.ReadLine());
                                    double vyslednaRychlost = FunkceDeleni(adraha, acas);
                                    Console.WriteLine("\nVýsledek je {0} m.s^-1", vyslednaRychlost);
                                    localSwitch = Solved();
                                    break;
                                case 'b'://zrychlení
                                    Console.WriteLine("\nZadejte změnu rychlosti v m.s^-1");
                                    double brychlostDelta = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Zadejte čas v s");
                                    double bcasDelta = Convert.ToDouble(Console.ReadLine());
                                    double vysledneZrychleni = FunkceDeleni(brychlostDelta, bcasDelta);
                                    Console.WriteLine("\nVýsledek je {0} m.s^-2", vysledneZrychleni);
                                    localSwitch = Solved();
                                    break;
                                case 'c'://čas
                                    MechanikaCas(); //complicated enough to validate its own method
                                    localSwitch = Solved();
                                    break;
                                case 'd'://dráha
                                    Console.WriteLine("\nZadejte rychlost v m.s^-1");
                                    double drychlost = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Zadejte čas v s");
                                    double dcas = Convert.ToDouble(Console.ReadLine());
                                    double vysledenaDraha = FunkceNasobeni(drychlost, dcas);
                                    Console.WriteLine("\nVýsledek je {0} m", vysledenaDraha);
                                    localSwitch = Solved();
                                    break;
                                case 'e'://hybnost
                                    Console.WriteLine("\nZadejte hmotnost v kg");
                                    double ehmotnost = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Zadejte rychlost v m.s^-1");
                                    double erychlost = Convert.ToDouble(Console.ReadLine());
                                    double vysledenaHybnost = FunkceNasobeni(erychlost,ehmotnost);
                                    Console.WriteLine("\nVýsledek je {0} m", vysledenaHybnost);
                                    localSwitch = Solved();
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
                        //MoleTermik();
                        break;
                    case '3': //mechanické kmitání a vlnění
                        //KmitVln();
                        break;
                    case '4': //elektřina a magnetismus
                        //ElMag();
                        break;
                    case '5':  //optika
                        //Optika();
                        break;
                    case '6': //speciální teroie relativity
                        //Str();
                        break;
                    case '7': //fyzika mikrosvěta
                        //Mikro();
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
        public static bool Solved()
        {
            Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
            Console.ReadKey();
            return true;
        }
        public static double FunkceNasobeni(double num1, double num2)
        {
            double vysledek;
            vysledek = num1 * num2;
            return vysledek;
        }
        public static double FunkceDeleni(double num1, double num2)
        {
            double vysledek;
            vysledek = num1 / num2;
            return vysledek;
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
    }
}