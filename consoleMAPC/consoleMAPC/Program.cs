using System;

namespace consoleMAPC
{
    class Program
    {
        static void Main(string[] args)
            //TODO převodník jednotek
            //     delete default switch cases
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
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Milošova kvalitní fyzikální kalkulačka <3 v 0.2.0");
            Console.WriteLine("\nVyberte si obor, z něhož je váš příklad.");
            Console.WriteLine("\n1. Mechanika\n2. Molekulová fyzika a termika\n3. Mechanické kmitání a vlnění\n4. Elektřina a magnetismus\n5. Optika\n6. Teorie relativity\n7. Fyzika mikrosvěta\n\nZmáčkněte 0 pro ukončení programu.");
        }
        public static void FunkceNasobeni(string zadani1, string zadani2, string vyslednaVelicina)
        {
            Console.WriteLine("Zadejte " + zadani1);
            double firstInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte " + zadani2);
            double secondInput = Convert.ToDouble(Console.ReadLine());
            double result = firstInput * secondInput;
            Console.WriteLine("\nVýsledek je {0} {1}", result, vyslednaVelicina);
            Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
            Console.ReadKey();

        }
        public static void FunkceDeleni(string zadani1, string zadani2, string vyslednaVelicina)
        {
            Console.WriteLine("Zadejte " + zadani1);
            double firstInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte " + zadani2);
            double secondInput = Convert.ToDouble(Console.ReadLine());
            double result = firstInput / secondInput;
            Console.WriteLine("\nVýsledek je {0} {1}", result, vyslednaVelicina);
            Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
            Console.ReadKey();
        }
        public static void Mechanika() //DONE
        {
            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Mechanika\n\nCo počítáme?\nPro výběr zmáčkni klávesu před veličinou (a-j)\na. rychlost\nb. zrychlení\nc. čas\nd. dráhu\ne. hybnost\nf. sílu\ng. výkon\nh. tlak\ni. hustotu\n");

            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while ((localChoice != 'a') && (localChoice != 'b') && (localChoice != 'c') && (localChoice != 'd') && (localChoice != 'e') && (localChoice != 'f') && (localChoice != 'g') && (localChoice != 'h') && (localChoice != 'i'))
            {
                Console.WriteLine("Prosím vyberte možnost a-i");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a'://rychlost
                    FunkceDeleni("dráhu v m", "čas v s", "m.s^-1");
                    break;
                case 'b'://zrychlení
                    FunkceDeleni("změnu rychlosti v m.s^-1", "čas v s", "m.s^-2");
                    break;
                case 'c'://čas
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
                        FunkceDeleni("dráhu v m", "rychlost v m.s^-1", "s");
                    }
                    else
                    {
                        Console.WriteLine("Zvolili jste b");
                        FunkceDeleni("změnu rychlosti v m.s^-1", "zrychlení v m.s^-2", "s");
                    }
                    break;
                case 'd'://dráha
                    FunkceNasobeni("rychlost v m.s^-1", "čas v s", "m");
                    break;
                case 'e'://hybnost
                    FunkceNasobeni("hmotnost v kg", "rychlost v m.s^-1", "kg.m.s^-1");
                    break;
                case 'f'://síla
                    FunkceNasobeni("hmotnost v kg", "zrychlení v m.s^-2", "N");
                    break;
                case 'g'://výkon
                    FunkceDeleni("práci v J", "dobu v s", "W");
                    break;
                case 'h'://tlak
                    FunkceDeleni("sílu v N", "plochu v m^2", "Pa");
                    break;
                case 'i'://hustota
                    FunkceDeleni("hmotnost v kg", "objem v m^3", "kg.m^-3");
                    break;
            }
            Menu();
        }
        public static void MoleTermik()
        {
            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Molekulová fyzika a termika.\n\nCo počítáme?\nPro výběr zmáčkni klávesu před veličinou.\na. První termodynamický zákon\nb. kinetickou enegii\nc. potenciální energii\n");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while (localChoice != 'a')
            {
                Console.WriteLine("Prosím vyberte možnost a-i");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a': //první termodynamický zákon
                    //something
                    break;
                case 'b'://kinetická energie
                    //smth
                    break;
                case 'c'://potenciální energie
                    //smth
                    break;
                
            }
        }
        public static void KmitVln()
        {
            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Mechanické kmitání a vlnění.\n\nCo počítáme?\nPro výběr zmáčkni klávesu před veličinou.\na. amplitudu výchylky\nb. periodu\nc. počáteční fázi kmitání\nd. doba amplitudy\ne. okamžitou výchylku\nf. frekvenci\ng. délku kyvadla");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while (localChoice != 'a')
            {
                Console.WriteLine("Prosím vyberte možnost a-i");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a'://amplituda výchylky
                    Console.WriteLine("Zadejte okamžitou výchylku");
                    double vychylka = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Zadajte čas");
                    double cas = Convert.ToDouble(Console.ReadLine());
                    break;
                case 'b'://perioda
                    //something
                    break;
                case 'c'://počáteční fáze
                    //something
                    break;
                case 'd'://doba amplitudy
                    //something
                    break;
                case 'e'://okamžitá výchylka
                    //something
                    break;
                case 'f'://frekvence
                    //something
                    break;
                case 'g'://dlélka kyvadla
                    //something
                    break;
            }
        }
        public static void ElMag()//TODO sloučit: napětí na rezistorech + proudy na větvích
        {
            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Co počítáme?\n\na. přitažlivou sílu nábojů\nb. intenzitu elektrického pole\nc. napětí mezi dvěma daskami\nd. kapacitu kondenzátoru\ne. uvolnění energie\nf. proud nabití kondenzátoru\ng. napětí na rezistorech\n");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while (localChoice != 'a')
            {
                Console.WriteLine("Prosím vyberte možnost a-i");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a'://přitažlivá síla nábojů
                    //something
                    break;
                case 'b'://intenzita elektrického pole
                    //something
                    break;
                case 'c'://napětí mezi dvěma náboji
                    //smth
                    break;
                case 'd'://kapacita kondenzátoru
                    //smth
                    break;
                case 'e'://uvolnění energie
                    //smth
                    break;
                case 'f'://proud nabití kondenzátoru
                    //smth
                    break;
                case 'g'://napětí na rezistorech a proudy na větvích obvodu
                    //smth
                    break;
            }
        }
        public static void Optika()
        {
            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Co počítáme?");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while (localChoice != 'a')
            {
                Console.WriteLine("Prosím vyberte možnost a-i");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a':
                    //something
                    break;
                default:
                    Console.WriteLine("You weren't supposed to be able to get here you know");
                    break;
            }
        }
        public static void Str()
        {
            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Co počítáme?");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while (localChoice != 'a')
            {
                Console.WriteLine("Prosím vyberte možnost a-i");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a':
                    //something
                    break;
                default:
                    Console.WriteLine("You weren't supposed to be able to get here you know");
                    break;
            }
        }
        public static void Mikro()
        {
            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Co počítáme?");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while (localChoice != 'a')
            {
                Console.WriteLine("Prosím vyberte možnost a-i");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a':
                    //something
                    break;
                default:
                    Console.WriteLine("You weren't supposed to be able to get here you know");
                    break;
            }
        }
    }
}