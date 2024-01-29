using System;
namespace Bussen
{
    class Buss
    {
        //Initierar arrayer och variabler för att spara passagerare i
        public int[] passagerarÅlder = new int[25];
        public int totalÅlder;
        public string[] passagerarNamn = new string[25];
        public int antal_passagerare;
        public int max_passagerare = 25;
        public double medelÅlder;
        //metoden som körs
        public void Run()
        {
            //Initierar menyn och tar emot användarinput som i sin tur kallar på den metod som skall användas med en switch-case meny.
            Console.WriteLine("Välkommen ombord på bussen!");
            int meny;
            do
            {
                
                


                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║Välj ett alternativ:                      ║");
                    Console.WriteLine("╚══════════════════════════════════════════╝");
                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║1. Lägg till passagerare.                 ║");
                    Console.WriteLine("╚══════════════════════════════════════════╝");
                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║2. Lista alla passagerare.                ║");
                    Console.WriteLine("╚══════════════════════════════════════════╝");
                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║3. Skriv ut passagerarnas totala ålder.   ║");
                    Console.WriteLine("╚══════════════════════════════════════════╝");
                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║4. Beräkna genomsnittlig ålder.           ║");
                    Console.WriteLine("╚══════════════════════════════════════════╝");
                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║5. Skriv ut den äldsta passageraren.      ║");
                    Console.WriteLine("╚══════════════════════════════════════════╝");
                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║6. Hitta passagerare efter ålder.         ║");
                    Console.WriteLine("╚══════════════════════════════════════════╝");
                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║7. Sortera passagerare efter ålder.       ║");
                    Console.WriteLine("╚══════════════════════════════════════════╝");
                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║8. Avsluta programmet.                    ║"); 
                    Console.WriteLine("╚══════════════════════════════════════════╝"); 

                try
                {
                    meny = int.Parse(Console.ReadLine());



                    switch (meny)
                    {
                        case 1:
                            add_passenger();
                            break;

                        case 2:
                            print_buss();
                            break;

                        case 3:
                            calc_total_age();

                            break;

                        case 4:
                            calc_average_age();
                            break;

                        case 5:
                            max_age();
                            break;

                        case 6:
                            find_age();
                            break;

                        case 7:
                            sort_buss();
                            break;

                        case 8:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Felaktig inmatning, var god försök igen!");
                            break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Inkorrekt inmatning" + e.StackTrace);
                    return;
                    
                }
                
            } while (meny != 0);

        }
        //Lägger till passagerare med ålder och namn
        public void add_passenger()
        {
            if (antal_passagerare == max_passagerare)
            {
                Console.WriteLine("Tyvärr, nu är bussen full!");
            }
            else
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Skriv in passagerarens ålder:");
                        passagerarÅlder[antal_passagerare] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Felaktig inmatning, var god försök igen." + e.StackTrace);
                        return;
                    }
                    Console.WriteLine("Skriv in passagerarens namn:");
                    passagerarNamn[antal_passagerare] = Console.ReadLine();
                    antal_passagerare++;
                    return;
                }
            }
            
        }
        public void print_buss()
        {
            //Skriver ut alla passagerare
            for (int i = 0; i < antal_passagerare; i++)
            {
                Console.WriteLine("Passagerarens namn: " + passagerarNamn[i] + "." + " Passagerarens ålder: " + passagerarÅlder[i] + ".");
            }
            Console.WriteLine("Antal passagerare: " + antal_passagerare);
        }
        public int calc_total_age()
        {
            //Beräknar den totala åldern på alla passagerare
            int totalÅlder = 0;
            for (int i = 0;i < antal_passagerare; i++)
            {
                totalÅlder += passagerarÅlder[i];
                
            }
            Console.WriteLine("Passagerarnas totala ålder är:" + totalÅlder + " år.");
            return totalÅlder;
        }
        public double calc_average_age()
        {
            // Beräknar medelåldern på alla passagerare och skriver ut den med 1 decimal
            
            for (int i = 0; i <= antal_passagerare; i++)
            {
                totalÅlder += passagerarÅlder[i];
            }
            double totalÅlder1 = Convert.ToDouble(totalÅlder);
            double medelÅlder = totalÅlder1 / antal_passagerare;
            medelÅlder = Math.Round(medelÅlder, 1);
            Console.WriteLine("Medelåldern på bussen är:" + medelÅlder + ".");
            return medelÅlder;
        }
        public int max_age()
        {
            //Tar fram passageraren med högst ålder
            int högstÅlder = 0;
            int högstÅlderIndex = 0;
            for (int i = 0; i < antal_passagerare; i++ )
            {
                if (passagerarÅlder[i] > högstÅlder)
                {
                    högstÅlder = passagerarÅlder[i];
                    högstÅlderIndex = i;
                }
            }
            Console.WriteLine("Passageraren med högst ålder är " + passagerarNamn[högstÅlderIndex] + " som är " + högstÅlder + " år gammal.");
            return högstÅlder;
        }
        public void find_age()
        {
            //Sök på passagerare med en viss ålder med hjälp med av undre och en övre åldergräns
            try
            {


                Console.WriteLine("Mellan vilka åldrar vill du söka?");
                Console.WriteLine("Skriv in undre åldersgräns:");
                int lägstaÅlder = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv in övre åldersgräns:");
                int högstaÅlder = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < antal_passagerare; i++)
                {
                    if (passagerarÅlder[i] > lägstaÅlder && passagerarÅlder[i] < högstaÅlder)
                    {
                        Console.WriteLine("Passagerarna inom det spannet du angett är:");
                        Console.WriteLine(passagerarNamn[i] + ". Hen är " + passagerarÅlder[i] + " år gammal.");
                    }
                }
            }
            catch (Exception e) 
            { 
                Console.WriteLine("Felaktig inmatning!" + e.StackTrace); 
            }
        }
        public void sort_buss()
        {
            //Sortera bussen efter ålder med bubblesort
            bool sort = true;
            for (int i = 0; i < antal_passagerare - 1 && sort; i++)
            {
            for (int j = 0; j < antal_passagerare - i - 1; j++)
                {
                    if (passagerarÅlder[j] > passagerarÅlder[j + 1])
                    {
                        sort = true;
                        int temp = passagerarÅlder[j+1];
                        passagerarÅlder[j + 1] = passagerarÅlder[j];
                        passagerarÅlder[j] = temp;
                        string tempNamn = passagerarNamn[j+1];
                        passagerarNamn[j + 1] = passagerarNamn[j];
                        passagerarNamn[j] = tempNamn;


                    }
                }

            }

        }
       
    }
    class Program
    {
        public static void Main(string[] args)
        {
           var minbuss = new Buss();
            minbuss.Run();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}
