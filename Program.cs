using System;
using System.Collections.Generic;

namespace FornavnEfternavn
{
    class Program
    {
        static void Main(string[] args)
        {
            NameSpc name = new NameSpc();
            bool løkke = true;
            string FNavn1;
            string ENavn1;
            string Alias1;
            string FuldNavn;
            List<string> Navnelist = new List<string>();
            Dictionary<string, int> NavneDic = new Dictionary<string, int>(); 

            do
            {
                Console.WriteLine("Tast A for at tilføje flere navne");
                Console.WriteLine("Tast P for at printe listen ud");
                Console.WriteLine("Tast Q for at lukke");
                string svar = Console.ReadLine();

                switch (svar)
                {
                    case "a":
                        Console.WriteLine("Indtast Fornavn(e)");
                        FNavn1 = Console.ReadLine();
                        Console.WriteLine("Indtast Efternavn");
                        ENavn1 = Console.ReadLine();
                        Alias1 = FNavn1.Substring(0, 2) + ENavn1.Substring(0, 2);
                        if (NavneDic.ContainsKey(Alias1))
                        {
                            NavneDic[Alias1]++;
                        }
                        else
                        {
                            NavneDic.Add(Alias1,1);
                        }
                        FuldNavn = name.Navne(ENavn1, FNavn1, Alias1);
                        Navnelist.Add(FuldNavn);
                        break;
                    case "p":
                        Navnelist.Sort();
                        foreach (string Listen in Navnelist)
                        {
                            Console.WriteLine(Listen);
                        }
                        foreach (var ID in NavneDic)
                        {
                           Console.WriteLine(ID);
                        }
                        break;
                    case"q":
                        løkke = false; 
                        break;
                    default:
                        
                        break;
                }
            
            
            } 
            while (løkke);
            {
               Console.WriteLine("Du har nu lukket for programmet, lukker af sig selv om 5 sekunder");
            }
            System.Threading.Thread.Sleep(5000);

        }
    }
}
