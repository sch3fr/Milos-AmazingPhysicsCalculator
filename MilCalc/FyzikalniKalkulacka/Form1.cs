using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FyzikalniKalkulacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VymazVse();
        }
        public int pocitadlo = 0; //proměnná pomocí které určuji druh provedeného výpočtu

        //Následují funkce upravující rozhraní

        private void VymazVse()
        {
            // inspirace z https://stackoverflow.com/questions/4811229/how-to-clear-the-text-of-all-textboxes-in-the-form
            void funkce(Control.ControlCollection controls)
            {
                foreach (Control prvek in controls)
                    if (prvek is NumericUpDown)
                        (prvek as NumericUpDown).ResetText();
                    else if (prvek is TextBox)
                        (prvek as TextBox).ResetText();
                    else
                        funkce(prvek.Controls);
            }
            funkce(Controls);
        }

        private void Viditelnost2Radku(bool vypinac) //na základě parametru zviditelní nebo schová 2. řádek vstupů kalkulačky
        {
            if (vypinac == true)
            {
                mkrJed2.Visible = true;
                mkrVstup2.Visible = true;
                popisekMkr2.Visible = true;
            }
            else
            {
                mkrJed2.Visible = false;
                mkrVstup2.Visible = false;
                popisekMkr2.Visible = false;
            }
        }
        private void Viditelnost3Radku(bool vypinac) //schová nebo zviditelní 3. řádek
        {
            if (vypinac == true)
            {
                termJed3.Visible = true;
                termVstup3.Visible = true;
                popisekTerm3.Visible = true;

                elJed3.Visible = true;
                elVstup3.Visible = true;
                popisekEl3.Visible = true;
            }
            else
            {
                termJed3.Visible = false;
                termVstup3.Visible = false;
                popisekTerm3.Visible = false;

                elJed3.Visible = false;
                elVstup3.Visible = false;
                popisekEl3.Visible = false;
            }
        }
        private void Viditelnost4Radku(bool vypinac) //schová nebo zviditelní 4. řádek
        {
            if (vypinac == true)
            {
                termJed4.Visible = true;
                termVstup4.Visible = true;
                popisekTerm4.Visible = true;
            }
            else
            {
                termJed4.Visible = false;
                termVstup4.Visible = false;
                popisekTerm4.Visible = false;
            }
        }

        //funkce měnící popisky přijímají jako parametry stringy, které pak nastaví jako popisek
        private void ZmenaPopiskuMechaniky(string prvniPopisek, string druhyPopisek, string jednotka1, string jednotka2, string jednotka3)
        {
            popisekMech1.Text = prvniPopisek;
            popisekMech2.Text = druhyPopisek;
            medJed1.Text = jednotka1;
            medJed2.Text = jednotka2;
            medJed3.Text = jednotka3;
        }
        private void ZmenaPopiskuTermiky(string prvniPopisek, string druhyPopisek, string tretiPopisek, string ctvrtyPopisek, string jednotka1, string jednotka2, string jednotka3, string jednotka4, string jednotka5)
        {
            popisekTerm1.Text = prvniPopisek;
            popisekTerm2.Text = druhyPopisek;
            popisekTerm3.Text = tretiPopisek;
            popisekTerm4.Text = ctvrtyPopisek;
            termJed1.Text = jednotka1;
            termJed2.Text = jednotka2;
            termJed3.Text = jednotka3;
            termJed4.Text = jednotka4;
            termJed5.Text = jednotka5;
        }
        private void ZmenaPopiskuElektriny(string prvniPopisek, string druhyPopisek, string tretiPopisek, string jednotka1, string jednotka2, string jednotka3, string jednotka4)
        {
            popisekEl1.Text = prvniPopisek;
            popisekEl2.Text = druhyPopisek;
            popisekEl3.Text = tretiPopisek;
            elJed1.Text = jednotka1;
            elJed2.Text = jednotka2;
            elJed3.Text = jednotka3;
            elJed4.Text = jednotka4;
        }
        private void ZmenaPopiskuMikrosveta(string prvniPopisek, string druhyPopisek, string jednotka1, string jednotka2, string jednotka3)
        {
            popisekMkr1.Text = prvniPopisek;
            popisekMkr2.Text = druhyPopisek;
            mkrJed1.Text = jednotka1;
            mkrJed2.Text = jednotka2;
            mkrJed3.Text = jednotka3;
        }
        private void ZmenaPopiskuStr(string prvniPopisek, string druhyPopisek, string jednotka1, string jednotka2, string jednotka3)
        {
            popisekStr1.Text = prvniPopisek;
            popisekStr2.Text = druhyPopisek;
            strJed1.Text = jednotka1;
            strJed2.Text = jednotka2;
            strJed3.Text = jednotka3;
        }
        
        //Následující funkce jsou event-handlers pro tlačítka
        //Každé tlačítko upraví rozhraní (labels apod.) a nastaví hodnotu počítadla
        //podle hodnoty počítadla se zavolá speciální funkce, která vezme vstupy a provede výpočet

        private void ButtMechRych_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 2;
            ZmenaPopiskuMechaniky("Dráha", "Čas", "m", "s", "m.s^-1");
        }
        private void ButtMechZrych_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 2;
            ZmenaPopiskuMechaniky("Změna rychlosti", "Čas", "m.s^-1", "s", "m.s^-2");
        }
        private void ButtMechCas_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 2;
            ZmenaPopiskuMechaniky("Dráha","Rychlost", "m", "m.s^-1", "s");
        }
        private void ButtMechDrh_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 1;
            ZmenaPopiskuMechaniky("Rychlost","Čas", "m.s^-1", "s","m");
        }
        private void ButtMechHbn_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 1;
            ZmenaPopiskuMechaniky("Hmotnost","Rychlost","kg", "m.s^-1", "kg.m.s^-1");
        }
        private void ButtMechSla_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 1;
            ZmenaPopiskuMechaniky("Hmotnost", "Zrychlení", "kg", "m.s^-2", "N");
        }
        private void ButtMechVkn_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 2;
            ZmenaPopiskuMechaniky("Práce", "Čas", "J", "s", "W");
        }
        private void ButtMechTlk_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 2;
            ZmenaPopiskuMechaniky("Síla", "Plocha", "N", "m^2", "Pa");
        }
        private void ButtMechHst_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 2;
            ZmenaPopiskuMechaniky("Hmotnost", "Objem", "kg", "m^3", "kg.m^3");
        }
        private void ButtTermPE_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 11;

            Viditelnost3Radku(false);
            Viditelnost4Radku(false);

            ZmenaPopiskuTermiky("Hmotnost tělesa", "Výška polohy", "", "", "g", "m", "", "", "J");
        }
        private void ButtTermKE_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 12;

            Viditelnost3Radku(false);
            Viditelnost4Radku(false);

            ZmenaPopiskuTermiky("Hmotnost tělesa", "Rychlost tělesa", "", "", "g", "m*s^-1", "", "", "J");
        }
        private void ButtTermIP_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 13;

            Viditelnost3Radku(true);
            Viditelnost4Radku(false);

            ZmenaPopiskuTermiky("Teplota", "Objem", "Exponent počtu molekul", "", "K", "m^3", "", "", "Pa");
        }
        private void ButtTermTR_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 14;

            Viditelnost3Radku(true);
            Viditelnost4Radku(false);

            ZmenaPopiskuTermiky("Koeficient teplotní roztažnosti", "Původní délka", "Teplotní rozdíl","","", "m","","", "m");
        }
        private void ButtTermDS_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 15;

            Viditelnost3Radku(true);
            Viditelnost4Radku(true);

            ZmenaPopiskuTermiky("Původní délka objektu", "Změna délky","Obsah objektu","Modul pružnosti tahu", "m", "m", "m^2", "Pa", "N");
        }
        private void ButtTermKap_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 16;

            Viditelnost3Radku(true);
            Viditelnost4Radku(false);

            ZmenaPopiskuTermiky("Výška vzlínání", "Povrchové napětí", "Hustota", "", "mm", "", "kg.m^3", "", "mm");
        }
        private void ButtElPsn_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 21;

            Viditelnost3Radku(true);

            ZmenaPopiskuElektriny("Velikost náboje 1", "Velikost náboje 2", "Vzdálenost", "C", "C", "mm", "N");
        }
        private void ButtElKk_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 22;

            Viditelnost3Radku(true);

            ZmenaPopiskuElektriny("Vzdálenost desek", "Plocha desek", "Permitivita", "mm", "cm^2", "N*A^-2", "F");
        }
        private void ButtElUek_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 23;

            Viditelnost3Radku(false);

            ZmenaPopiskuElektriny("Napětí", "Kapacita kondenzátoru", "", "V", "F", "", "J");
        }
        private void ButtElPnk_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 24;

            Viditelnost3Radku(true);

            ZmenaPopiskuElektriny("Kapacita kondenzátoru", "Napětí", "Doba nabíjení", "F", "V", "S", "J");
        }
        private void ButtElP_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 25;

            Viditelnost3Radku(false);

            ZmenaPopiskuElektriny("Elektrická indukce", "Intenzita el. pole", "", "C.m^2", "N.C^-1", "", "F.m^-1");
        }
        private void ButtMkrDbv_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 31;

            Viditelnost2Radku(false);

            ZmenaPopiskuMikrosveta("Urychlovací napětí", "", "V", "", "m");
        }
        private void ButtMkrEf_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 32;

            Viditelnost2Radku(false);

            ZmenaPopiskuMikrosveta("Frekvence", "", "Hz", "", "eV");
        }
        private void ButtMkrHf_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 33;

            Viditelnost2Radku(false);

            ZmenaPopiskuMikrosveta("Energie", "", "J", "", "kg.m.s^-1");
        }
        private void ButtMkrEvf_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 34;

            Viditelnost2Radku(true);

            ZmenaPopiskuMikrosveta("Práce elektronů", "Vlnová délka", "eV", "nm", "eV");
        }
        private void ButtStrDck_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 41;
            ZmenaPopiskuStr("Doba trvání", "Rychlost pohybu", "s", "km.s^-1", "s");
        }
        private void ButtStrDcp_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 42;
            ZmenaPopiskuStr("Doba trvání", "Rychlost pohybu","s", "km.s^-1", "s");
        }
        private void ButtKd_Click(object sender, EventArgs e)
        {
            VymazVse();
            pocitadlo = 43;
            ZmenaPopiskuStr("Klidová délka", "Rychlost pohybu","m", "km.s^-1", "m");
        }

        //funkce provádějící výpočty
        private void Vypocet_Click(object sender, EventArgs e)
        {
            switch (pocitadlo) //každý druh výpočtu nastaví hodnotu pro pocitadlo, a pak se provede daný výpočet
            {
                case 1: //násobení dvou členů
                    mechVysledek.Text = PocitaciFunkce.Nasobeni(mechVstup1.Value, mechVstup2.Value);
                    break;
                case 2: //dělení dvou členů
                    mechVysledek.Text = PocitaciFunkce.Deleni(mechVstup1.Value, mechVstup2.Value);
                    break;
                case 11: //potenciální energie
                    termVysledek.Text = PocitaciFunkce.PotencialniEnergie(termVstup1.Value, termVstup2.Value);
                    break;
                case 12: //kinetická energie
                    termVysledek.Text = PocitaciFunkce.KinetickaEnergie(termVstup1.Value, termVstup2.Value);
                    break;
                case 13: //tlak ideálního plynu
                    termVysledek.Text = PocitaciFunkce.IdealniPlyn(termVstup3.Value, termVstup1.Value, termVstup2.Value);
                    break;
                case 14: //teplotní roztažnost
                    termVysledek.Text = PocitaciFunkce.TeplotniRoztatznost(termVstup1.Value, termVstup2.Value, termVstup3.Value);
                    break;
                case 15: //deformační síla
                    termVysledek.Text = PocitaciFunkce.Deformace(termVstup1.Value, termVstup2.Value, termVstup3.Value, termVstup4.Value);
                    break;
                case 16: //kapilára
                    termVysledek.Text = PocitaciFunkce.Kapilara(termVstup1.Value, termVstup2.Value, termVstup3.Value);
                    break;
                case 21: //přitažlivost nábojů
                    elVysledek.Text = PocitaciFunkce.PritazlivostNaboju(elVstup1.Value, elVstup2.Value, elVstup3.Value);
                    break;
                case 22: //kapacita kondenzátoru
                    elVysledek.Text = PocitaciFunkce.KapacitaKondenzatoru(elVstup1.Value, elVstup2.Value, elVstup3.Value);
                    break;
                case 23: //energie uvolněná z kondenzátoru
                    elVysledek.Text = PocitaciFunkce.UvolnenaEnergie(elVstup1.Value, elVstup2.Value);
                    break;
                case 24: //proud nabití kondenzátoru
                    elVysledek.Text = PocitaciFunkce.ProudNabitiKondenzatoru(elVstup1.Value, elVstup2.Value, elVstup3.Value);
                    break;
                case 25: //permitivita
                    elVysledek.Text = PocitaciFunkce.Deleni(elVstup1.Value, elVstup2.Value);
                    break;
                case 31: //de Broglieova vlna
                    mkrVysledek.Text = PocitaciFunkce.DeBroglieovaVlna(mkrVstup1.Value);
                    break;
                case 32: //energie fotonů
                    mkrVysledek.Text = PocitaciFunkce.EnergieFotonu(mkrVstup1.Value);
                    break;
                case 33: //hybnost fotonů
                    mkrVysledek.Text = PocitaciFunkce.Deleni(mkrVstup1.Value, 300000);//300 000 je rychlost světla
                    break;
                case 34: //energie vyletujících fotonů
                    mkrVysledek.Text = PocitaciFunkce.VyletujiciFotony(mkrVstup1.Value, mkrVstup2.Value);
                    break;
                case 41: //dilatace času v klidové soustavě
                    strVysledek.Text = PocitaciFunkce.DilataceCasuKlid(strVstup1.Value, strVstup2.Value);
                    break;
                case 42: //dilatace času v pohybující se soustavě
                    strVysledek.Text = PocitaciFunkce.DilataceCasuPohyb(strVstup1.Value, strVstup2.Value);
                    break;
                case 43: //kontrakce délek
                    strVysledek.Text = PocitaciFunkce.KontrakceDelek(strVstup1.Value, strVstup2.Value);
                    break;
            }
        }
    }
}
