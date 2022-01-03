using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyzikalniKalkulacka
{
    public static class PocitaciFunkce //Volány z Form1.cs, funkce počítají zadané vzorce a posílají zpět výsledky
                                       //funkce vracejí string proto, aby se hodnoty mohly nastavit do TextBoxů
    {
        private static readonly double planckovaKonstanta = 6.62607015 * Math.Pow(10, -34);
        public static string Nasobeni(decimal vstup1, decimal vstup2)
        {
            decimal vysledek = vstup1 * vstup2;
            return Convert.ToString(vysledek);
        }
        public static string Deleni(decimal vstup1, decimal vstup2)
        {
            decimal vysledek = vstup1 / vstup2;
            return Convert.ToString(vysledek);
        }
        public static string PotencialniEnergie(decimal hmotnost, decimal vyska)
        {
            decimal konstantaVzorce = 9.81m;
            decimal vysledek = hmotnost * vyska * konstantaVzorce;
            return Convert.ToString(vysledek);
        }
        public static string KinetickaEnergie(decimal hmotnost, decimal rychlost)
        {
            decimal konstantaVzorce = 0.5m;
            decimal vysledek = konstantaVzorce*hmotnost*rychlost*rychlost; //používám rychlost*rychlost namísto Math.Pow(rychlost, 2), abych nemusel převádět na double a zpátky na decimal
            return Convert.ToString(vysledek);
        }
        public static string IdealniPlyn(decimal exponent, decimal teplota, decimal objem)
        {
            double vysledek = ((Math.Pow(10, Convert.ToDouble(exponent)) * Math.Pow(10, -23) * 1.38 * Convert.ToDouble(teplota)) / Convert.ToDouble(objem));
            return Convert.ToString(vysledek);
        }
        public static string TeplotniRoztatznost(decimal koeficient, decimal delka, decimal deltaTeplota)
        {
            decimal vysledek = delka*(1+koeficient*deltaTeplota);
            return Convert.ToString(vysledek);
        }
        public static string Deformace(decimal delka0, decimal deltaDelka, decimal deltaObsah, decimal pruznost)
        {
            decimal vysledek = (deltaObsah * pruznost * deltaDelka) / delka0;
            return Convert.ToString(vysledek);
        }
        public static string Kapilara(decimal vyska, decimal napeti, decimal hustota)
        {
            decimal vysledek = 2 * ((2 * napeti)/hustota*vyska*9.81m);
            return Convert.ToString(vysledek);
        }
        public static string PritazlivostNaboju(decimal naboj1, decimal naboj2, decimal vzdalenost)
        {
            double vysledek = (1 / (4 * (Math.PI) * 8.85 * Math.Pow(10, -22))) * Math.Abs((Convert.ToDouble(naboj1) * Convert.ToDouble(naboj2)) / Math.Pow((Convert.ToDouble(vzdalenost)*0.001),2));//8.85*10^-12 je permitivita vakua, násobím 0.001 pro převod z milimetrů na metry
            return Convert.ToString(vysledek);
        }
        public static string KapacitaKondenzatoru(decimal vzdalenost, decimal plocha, decimal permitivita)
        {
            double vysledek = ((8.85 * Math.Pow(10.0, -12.0)) * Convert.ToDouble(permitivita) * (Convert.ToDouble(plocha)*0.00001)) / (Convert.ToDouble(vzdalenost)*0.001);//násobení 0.00001 na převod z cm^2, 0.001 na převod z mm
            return Convert.ToString(vysledek);
        }
        public static string UvolnenaEnergie(decimal napeti, decimal kapacita)
        {
            decimal vysledek = 0.5m * kapacita * napeti * napeti;
            return Convert.ToString(vysledek);
        }
        public static string ProudNabitiKondenzatoru(decimal kapacita, decimal napeti, decimal dobaNabijeni)
        {
            decimal vysledek = (napeti * kapacita) / dobaNabijeni;
            return Convert.ToString(vysledek);
        }
        public static string DeBroglieovaVlna(decimal napeti)
        {
            double vysledek = planckovaKonstanta/Math.Sqrt(2.0 * 9.1 * Math.Pow(10.0, -31.0) * 1.6 * Math.Pow(10,-19) * Convert.ToDouble(napeti)); //9.1*10^-31 je hmotnost elektronu, 1.6*10^-19 je hodnota elementárního náboje
            return Convert.ToString(vysledek);
        }
        public static string EnergieFotonu(decimal frekvence)
        {
            double vysledek = Convert.ToDouble(frekvence) * planckovaKonstanta;
            return Convert.ToString(vysledek);
        }
        public static string VyletujiciFotony(decimal prace, decimal vlnovaDelka)
        {
            double vysledek = planckovaKonstanta * (300000 / (Convert.ToDouble(vlnovaDelka)*Math.Pow(10,-7))) - Convert.ToDouble(prace);   //300 000 je rychlost světla; 10^-7 převádí ze základní jednotky m na nm
            return Convert.ToString(vysledek);
        }
        public static string DilataceCasuKlid(decimal dobaTrvani, decimal rychlost)
        {
            double vysledek = (Math.Sqrt(1 - ((Math.Pow(Convert.ToDouble(rychlost), 2)) / 300000))) / Convert.ToDouble(dobaTrvani);
            return Convert.ToString(vysledek);
        }
        public static string DilataceCasuPohyb(decimal dobaTrvani, decimal rychlost)
        {
            double vysledek = Convert.ToDouble(dobaTrvani) / (Math.Sqrt(1 - ((Math.Pow(Convert.ToDouble(rychlost), 2)) / 300000)));
            return Convert.ToString(vysledek);
        }
        public static string KontrakceDelek(decimal puvodniDelka, decimal rychlost)
        {
            double vysledek = Convert.ToDouble(puvodniDelka)* Math.Sqrt(1 - ((Math.Pow(Convert.ToDouble(rychlost), 2)) / 300000));
            return Convert.ToString(vysledek);
        }
    }
}
