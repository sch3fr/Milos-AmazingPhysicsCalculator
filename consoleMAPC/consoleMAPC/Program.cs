using System;

namespace consoleMAPC
{
    class Program
    {
        static void Main(string[] args)
            //TODO převodník jednotek
            //     delete default switch cases //1.OCT.21 Y THO??? WHAT DID I MEAN bY THAT???
            //     JAKOU HODNOTU MÁ PLANCKOVA KONSTANTA???
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
        
        public static double NewDouble()
        {
            double vstup = Convert.ToDouble(Console.ReadLine());
            return vstup;
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
        
        /*
        public static void FunkceDeleniKonst
        {

        }
        */
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
            Console.WriteLine("Molekulová fyzika a termika.\n\nCo počítáme?\nPro výběr zmáčkni klávesu před veličinou.\na. První termodynamický zákon\nb. kinetickou enegii\nc. potenciální energii\nd. teplotu soustavy po dosažení ideálního stavu\ne. tlak ideálního plynu\nf. objem plynu\ng. vztah teploty a tlaku\nh. teplotní roztažnost\ni. tahovou deformační sílu\nj. průměr kapiláry\nk. předání tepla");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while ((localChoice != 'a') && (localChoice != 'b') && (localChoice != 'c') && (localChoice != 'd') && (localChoice != 'e') && (localChoice != 'f') && (localChoice != 'g') && (localChoice != 'h') && (localChoice != 'i')&&(localChoice != 'j')&&(localChoice != 'k'))
            {
                Console.WriteLine("Prosím vyberte možnost a-k");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a': //první termodynamický zákon
                    //something
                    break;
                case 'b'://kinetická energie
                    Console.WriteLine("Zadejte hmotnost tělesa v g");
                    double kinetHmotnost = NewDouble();
                    Console.WriteLine("Zadejte rychlost tělesa v m*s -1");
                    double kinetRychlost = NewDouble();
                    double kinetVysledek = (1/2)*kinetHmotnost*kinetRychlost*kinetRychlost;
                    Console.WriteLine("Výsledná energie je {0}.\nStisknutím jakéhokoliv tlačítka se vrátíte zpět do hlavního menu.");//chybí jednotka
                    Console.ReadKey();
                    break;
                case 'c'://potenciální energie
                    Console.WriteLine("Zadejte hmotnost tělesa v g");
                    double potencialniVaha = NewDouble();
                    Console.WriteLine("Zadejte výšku v m");
                    double potencialniVyska = NewDouble();
                    double potencialniVysledek = potencialniVaha*potencialniVyska*9.81;
                    Console.WriteLine("Výsledná energie je {0} J.\nStisknutím jakéhokoliv tlačítka se vrátíte zpět do hlavního menu.", potencialniVysledek);
                    Console.ReadKey();
                    break;
                case 'd'://teplota soustavy po dosažení rovnovážného stavu
                    //smth
                    break;
                case 'e'://tlak ideálního plynu
                    ///TODO opravit jednotky
                    Console.WriteLine("Zadejte teplotu v K");
                    double idealnipTeplota = NewDouble();
                    Console.WriteLine("Zadejte objem v m3");
                    double idealnipObjem =  NewDouble();
                    Console.WriteLine("Zadejte počet molekul formou exponentu\n(Pokud je počet molekul např. 10 na 24, zadejte 24.)");
                    double idealnipExponent =  NewDouble();
                    double idealnipVysledek = ((Math.Pow(10, idealnipExponent)*((Math.Pow(10, -23)*1.38)*idealnipTeplota ))/idealnipObjem);
                    Console.WriteLine("Výsledný tlak je {0} Pa.\nStisknutím jakéhokoliv tlačítka se vrátíte zpět do hlavního menu.", idealnipVysledek);
                    Console.ReadKey();
                    break;
                case 'f'://objem plynu + změna oběmu plynu
                    //smth
                    break;
                case 'g'://vztah teploty a tlaku
                    //smth
                    break;
                case 'h'://teplotní roztařnost
                    Console.WriteLine("Zadejte původní délku ocelového drátu v m");
                    double roztaznostDelka =  NewDouble();
                    Console.WriteLine("Zadejte teplotní rozdíl");
                    double roztaznostTeplota =  NewDouble();
                    double roztaznostVysledek = roztaznostDelka * (1 + (11.5*Math.Pow(10, 6))*roztaznostTeplota);
                    Console.WriteLine("Výsledná délka ocelového drátu je {0} m.\nStisknutím jakéhokoliv tlačítka se vrátiíte zpět do hlavního menu.", roztaznostVysledek);
                    Console.ReadKey();
                    break;
                case 'i'://tahová deformační síla
                    Console.WriteLine("Zadejte původní délku objektu v m");
                    double deformDelkaP = NewDouble();
                    Console.WriteLine("Zadejte změnu délky v m");
                    double deformDelkaZ = NewDouble();
                    Console.WriteLine("Zadejte obsah objektu v m2");
                    double deformObsah = NewDouble();
                    Console.WriteLine("Zadejte modul pružnosti tahu materiálu v Pa");
                    double deformPruznost = NewDouble();
                    double deformVysledek = (deformObsah*deformPruznost*deformDelkaZ) / deformDelkaP;
                    Console.WriteLine("Výsledek je {0} N.\nStisknutím jakéhokoliv tlačítka se vrátiíte zpět do hlavního menu.", deformVysledek);
                    Console.ReadKey();
                    break;
                case 'j'://průměr kapiláry
                    Console.WriteLine("Předpokládáme, že kapalina je voda.\nZadejte výšku, do které vzlínala kapalina v m.");
                    double vyskaKapilary = NewDouble();
                    double prumerKapilary = ((4*73*Math.Pow(10,-13))/(1000*vyskaKapilary*9.81));
                    Console.WriteLine("Průměr kapiláry je {0} m.\nStisknutím jakéhokoliv tlačítka se vrátite zpět do hlavního menu.", prumerKapilary);
                    Console.ReadKey();
                    break;
                case 'k'://předání tepla
                    //smth
                    break;
                
            }
            Menu();
        }
        public static void KmitVln()
        {
            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Mechanické kmitání a vlnění.\n\nCo počítáme?\nPro výběr zmáčkni klávesu před veličinou.\na. amplitudu výchylky\nb. periodu\nc. počáteční fázi kmitání\nd. doba amplitudy\ne. okamžitou výchylku\nf. frekvenci harmonického tónu\ng. délku kyvadla");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while ((localChoice != 'a') && (localChoice != 'b') && (localChoice != 'c') && (localChoice != 'd') && (localChoice != 'e') && (localChoice != 'f') && (localChoice != 'g'))
            {
                Console.WriteLine("Prosím vyberte možnost a-g");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a'://amplituda výchylky
                    Console.WriteLine("Zadejte okamžitou výchylku");
                    double vychylka = NewDouble();
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
                    Console.WriteLine("Zadejte amplitudu");
                    double vychylkaAmplituda = NewDouble();
                    Console.WriteLine("Je zadaná frekvence nebo perioda? Zvolte F/P");
                    char volba = char.ToLower(Console.ReadKey().KeyChar);
                    if (volba == 't')
                    {
                        double vychylkaPerioda = NewDouble();
                    }
                    else if (volba == 'f')
                    {
                        double vychylkaFrekvence = NewDouble();
                    }
                    else
                    {
                        Console.WriteLine("Chyba: Neplatná volba");
                    }
                    
                    break;
                case 'f'://frekvence harmonického tónu
                    Console.WriteLine("Zadejte délku struny v m");
                    double delkaStruny = NewDouble();
                    Console.WriteLine("Zadejte rychlost šíření vlnění");
                    double rychlostVlneni = NewDouble();
                    double vyslednaFrekvence = rychlostVlneni/(2*delkaStruny);
                    Console.WriteLine("Výsledná frekvence je {0} Hz.\nStisknutím jakéhokoliv tlačítka se vrátíte zpět do hlavního menu.", vyslednaFrekvence);
                    Console.ReadKey();
                    //something
                    break;
                case 'g'://dlélka kyvadla
                    //something
                    break;
            }
            Menu();
        }
        public static void ElMag()//TODO sloučit: napětí na rezistorech + proudy na větvích
        {
            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Co počítáme?\n\na. přitažlivou sílu nábojů\nb. intenzitu elektrického pole\nc. napětí mezi dvěma daskami\nd. kapacitu kondenzátoru\ne. uvolnění energie\nf. proud nabití kondenzátoru\ng. napětí na rezistorech\nh. permitivitu\n");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while ((localChoice != 'a') && (localChoice != 'b') && (localChoice != 'c') && (localChoice != 'd') && (localChoice != 'e') && (localChoice != 'f') && (localChoice != 'g') && (localChoice != 'h'))
            {
                Console.WriteLine("Prosím vyberte možnost a-h");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a'://přitažlivá síla nábojů
                    Console.WriteLine("Zadejte prní náboj v nC");
                    double pritazlivostNaboje1 = NewDouble();
                    Console.WriteLine("Zadejte druhý náboj v nC");
                    double pritazlivostNaboje2 = NewDouble();
                    Console.WriteLine("Zadejte vzdálenost nábojů v m");
                    double pritazlivostNabojeVzdalenost = NewDouble();
                    double pritazlivostNabojeVysledek = (1/(4*(Math.PI)*8.85*Math.Pow(10, -22)))*Math.Abs((pritazlivostNaboje1*pritazlivostNaboje2)/pritazlivostNabojeVzdalenost*pritazlivostNabojeVzdalenost);//JE TENHLE VZOREC SPRÁVNĚ??? JÁ NEVÍM, JSEM TEĎ OFFLINE!!!
                    Console.WriteLine("Výsledek je {0}.\nStisknutím jakéhokoliv talčítka se vrátíte do hlavního menu.", pritazlivostNabojeVysledek);//cybí jednotka
                    Console.ReadKey();

                    //F=k*|(q1*q2)/rr|
                    break;
                case 'b'://intenzita elektrického pole
                    FunkceDeleni("elektrickou sílu", "elektrický náboj", "N.C^-1");
                    break;
                case 'c'://napětí mezi dvěma náboji
                    //smth
                    break;
                case 'd'://kapacita kondenzátoru
                    Console.WriteLine("Zadejte vzdálenost desek v m");
                    double vzdalenostDesek = NewDouble();
                    Console.WriteLine("Zadejte plochu desek v m^2");
                    double plochaDesek = NewDouble();
                    Console.WriteLine("Zadejte relativní permitivitu");
                    double relativniPermitivita = NewDouble();
                    double vyslednaKapacita = (8.85*Math.Pow(10.0, -12.0))*(plochaDesek)/(vzdalenostDesek);
                    Console.WriteLine("Výsledná kapacita deskového kondenzátoru je {0} F.\nStisknutím jakéhokoliv tlačítka se vrátíte do hlavního menu.", vyslednaKapacita);
                    Console.ReadKey();
                    break;
                case 'e'://uvolnění energie kondenzátoru
                    Console.WriteLine("Zadejte napětí ve V");
                    double kondenzatorNapeti = NewDouble();
                    Console.WriteLine("Zadejte kapacitu kondenzátoru v F");
                    double kondenzatorKapacita = NewDouble();
                    double kondenzatorVysledek = (1/2)*(kondenzatorKapacita*Math.Pow(kondenzatorNapeti, 2)); //???     kondenzatorNapeti*kondenzatorNapeti
                    Console.WriteLine("Výsledek je {0}.\nStisknutím jakéhokoliv tlačítka se vrátíte do hlavního menu.", kondenzatorVysledek);//CHYBí JEDNOTKA
                    Console.ReadKey();
                    break;
                case 'f'://proud nabití kondenzátoru
                    Console.WriteLine("Zadejte kapacitu kondenzátoru v F");
                    double nabitKondenzatorKapacita = NewDouble();
                    Console.WriteLine("Zadejte napětí ve V");
                    double nabitKondenzatorNapeti = NewDouble();
                    Console.WriteLine("Zadejte dobu nabíjení kondenzátoru v s");
                    double nabitKondenzatorCas = NewDouble();
                    double nabitKondenzatorVysledek = (nabitKondenzatorNapeti*nabitKondenzatorKapacita)/nabitKondenzatorCas;
                    Console.WriteLine("Výsledek je {0} A.\nStisknutím jakéhokoliv tlačítka se vrátíte do hlavního menu.", nabitKondenzatorVysledek);
                    Console.ReadKey();

                    //smth
                    break;
                case 'g'://napětí na rezistorech a proudy na větvích obvodu
                    //smth
                    break;
                case 'h'://permitivita
                    FunkceDeleni("elektrickou indukci v C.m^2", "intenzitu elektrického pole v N.C^-1", "F.m^-1");
                    break;
            }
            Menu();
        }
        public static void Optika()
        {
            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Optika\nCo počítáme?\na. barvu olejové skvrny na hladině voddy v odraženém bílém světle\nb. vlnovou délku světla\nc. vzdálenost předmětu od zrcadla\nd. zvětšení obrazu v zakřiveném zrcadle\n");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while ((localChoice != 'a') && (localChoice != 'b') && (localChoice != 'c') && (localChoice != 'd'))
            {
                Console.WriteLine("Prosím vyberte možnost a-i");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a':
                    Console.WriteLine("Zadejte tloušťku skvrny μm");
                    double skvrnaTloustka = NewDouble();
                    //WHAT
                    break;
                case 'b'://vlnová délka světla
                    Console.WriteLine("Zadejte frekvenci světla v Hz");
                    double svetloFrek = NewDouble();
                    double svetloFrekVysl = 300000/svetloFrek;
                    Console.WriteLine("Výsledek je {0} nm.\n Stiskem jakékoliv klávesy se vrátítte do hlavního menu", svetloFrekVysl);
                    Console.ReadKey();
                    break;
                case 'c':
                    //vzdálenost předmětu od zrcadla
                    break;
                case 'd':
                    //zvětšení obrazu v zakřiveném zrcadle
                    break;
            }
            Menu();
        }
        public static void Str() //DONE
        {
            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Speciální teorie relativity\nCo počítáme?\na. dilataci času\nb.kontrakci délek");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while ((localChoice != 'a') && (localChoice != 'b'))
            {
                Console.WriteLine("Prosím vyberte možnost a-b");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a':
                    //dilatace času
                    Console.WriteLine("Počítáme čas a.) v klidové soustavě, nebo b.) v soustavě, která se pohybuje\nVyberte možnost 'a' nebo 'b'");
                    char dilataceChoice = char.ToLower(Console.ReadKey().KeyChar);
                    if (dilataceChoice == 'a')
                    {
                        Console.WriteLine("Zadejte dobu trvání události (v sekundách) v soustavě pohybující se rychlostí v");
                        double dilDob1 = NewDouble();
                        Console.WriteLine("Zadejte rychlost pohybu soustavy v km.s^-1");
                        double dilRych = NewDouble();
                        double dilVysledek = dilDob1/(Math.Sqrt(1-((Math.Pow(dilRych, 2))/300000))); //dilRych*dilRych ???
                        Console.WriteLine("Výsledná doba je {0} s.",dilVysledek);
                        Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
                        Console.ReadKey();
                    }
                    else if (dilataceChoice == 'b')
                    {
                        Console.WriteLine("Zadejte dobu trvání události (v sekundách) ve klidové soustavě");
                        double dilDob2 = NewDouble();
                        Console.WriteLine("Zadejte rychlost pohybu soustavy v km.s^-1");
                        double dilRych = NewDouble();
                        double dilVysledek = (Math.Sqrt(1-((Math.Pow(dilRych, 2))/300000)))/dilDob2; //dilRych*dilRych
                        Console.WriteLine("Výsledná doba je {0} s.",dilVysledek);
                        Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
                        Console.ReadKey();
                    }
                    else {Console.WriteLine("Zvolte A nebo B");}
                    break;
                case 'b'://kontrakce délek
                    Console.WriteLine("Zadejte klidovou délku v m");
                    double delkaKlid = NewDouble();
                    Console.WriteLine("Zadejte rychost v km.s^-1");
                    double kontrakceRychlost = NewDouble();
                    double kontrakceVysledek = delkaKlid*Math.Sqrt(1-((Math.Pow(kontrakceRychlost, 2))/300000)); //kontrakceRychlost*kontrakceRychlost
                    Console.WriteLine("Výsledná délka je {0} m.",kontrakceVysledek);
                    Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
                    Console.ReadKey();
                    break;
            }
            Menu();
        }
        public static void Mikro()//DONE
        {
            double planckKonst1 = Math.Pow(10, -34);
            double planckKonst2 = 6.62607015;
            //  double planckovaKonst =(Math.Pow(10, -34))*6.62607015;  ???

            char localChoice; //used to navigate submenu
            Console.Clear();
            Console.WriteLine("Fyzika mikrosvěta\nCo počítáme?\na. délku de Broglieovy vlny\nb. energii fotonů\nc. hybnost fotonů\nd. energii vyletujících elektronů\n");
            localChoice = char.ToLower(Console.ReadKey().KeyChar);
            while ((localChoice != 'a') && (localChoice != 'b') && (localChoice != 'c') && (localChoice != 'd'))
            {
                Console.WriteLine("Prosím vyberte možnost a-i");
                localChoice = char.ToLower(Console.ReadKey().KeyChar);
            }
            switch (localChoice)
            {
                case 'a'://de Broglieova vlna
                    Console.WriteLine("Zadejte urychlovací napětí ve V");
                    double urychlovaciNapeti = NewDouble();
                    double vlnaVysledek = (planckKonst1*planckKonst2)/(Math.Sqrt(urychlovaciNapeti*2.0*9.1*Math.Pow(10.0,-13.0)*1.6*(10^-19)*Math.Pow(10,4)));
                    Console.WriteLine("Výsledná vlnová délka je {0} m.\nStisknutím jakéhokoliv tlačítka se vrátíte do hlavního menu");
                    Console.ReadKey();
                    break;
                case 'b'://energie fotonů
                    Console.WriteLine("Zadejte frekvenci v Hz.");
                    double frekFoton = NewDouble();
                    double frekFotonVys = frekFoton*(planckKonst1*planckKonst2);
                    Console.WriteLine("Výsledná energie je {0} eV.",frekFotonVys);
                    Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
                    Console.ReadKey();
                    break;
                case 'c'://hybnost fotonů
                    Console.WriteLine("Zadejte energii v J.");
                    double energFoton = NewDouble();
                    double energFotonVys = energFoton/300000;
                    Console.WriteLine("Výsledná hybnost je {0} kg.m.s^-1.",energFotonVys);
                    Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
                    Console.ReadKey();
                    break;
                case 'd'://energie vyletujících fotonů
                    Console.WriteLine("Zadejte frekvenci v Hz");
                    double energFoton2 = NewDouble();
                    Console.WriteLine("Zadejte výstupní práci elektronů v eV");
                    double vystupniPrace = NewDouble();
                    Console.WriteLine("Zadejte vlnovou délku v nm");
                    double vlnDelka = NewDouble();
                    double vysledEnergie = ((((planckKonst1*planckKonst2)*300000)/vlnDelka)-vystupniPrace);
                    Console.WriteLine("Výsledná energie je {0} ev.",vysledEnergie);
                    Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu");
                    Console.ReadKey();
                    break;
            }
            Menu();
        }
    }
}