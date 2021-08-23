using System;

namespace consoleMAPC
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quitSwitch = false;
            char choice;
            string menu = "\n1. Mechanika\n2. Molekulová fyzika a termika\n3. Mechanické kmitání a vlnění\n4. Elektřina a magnetismus\n5. Optika\n6. Teorie relativity\n7. Fyzika mikrosvěta\n8. Astrofyzika";

            Console.WriteLine("Milošova kvalitní fyzikální kalkulačka <3 v 1.0");
            Console.WriteLine("\nVyberte si obor, z něhož je váš příklad.");
            Console.WriteLine(menu);

            do
            {
                choice = Console.ReadKey().KeyChar;
                switch (choice) 
                {
                    case '1':
                        //idk
                        break;
                    case '2':
                        //idk
                        break;
                    case '3':
                        //idk
                        break;
                    case '4':
                        //idk
                        break;
                    case '5':
                        //idk
                        break;
                    case '6':
                        //idk
                        break;
                    case '7':
                        //idk
                        break;
                    case '8':
                        //idk
                        break;
                    default:
                        Console.WriteLine("Dobrej pokus, ale prosím zadej číslo od 1 - 8.");
                        break;
                }
            } while (quitSwitch == false);

        }
        
    }
}
