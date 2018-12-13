using System;
namespace KørselsBog
{
    public class Menu
    {
        public Menu()
        {
            ConsoleKey key = new ConsoleKey();
            do {
                Console.Clear();
                Console.WriteLine("1.Bil\n2.Kunde");
                key = Console.ReadKey().Key;
                Console.Clear();
                if (key == ConsoleKey.D1) {
                    Bil();
                } else if (key == ConsoleKey.D2) {
                    Console.WriteLine("Kunde");
                } else {
                    Console.WriteLine("Indtast gyldig værdi");
                }
                Console.ReadKey();
            } while (key != ConsoleKey.D1 && key != ConsoleKey.D2);
        }
        public void Bil()
        {
            ConsoleKey key = new ConsoleKey();
            string KundeID, RegNr, Mærke, Model, Brændstoffstype, OprettelsesDato;
            double KmKørt;
            int Årgang;
            do
            {
                Console.Clear();
                Console.WriteLine("Bil");
                Console.WriteLine("1.Opret Bil\n2.Opdater Bil\n4.Slet Bil\n5.Vis Bil\n6.Vis Værkstedsbesøg");
                key = Console.ReadKey().Key;
                Console.Clear();
                if (key == ConsoleKey.D1)
                {
                    Console.WriteLine("Opret Bil");
                    Console.WriteLine("Indtast KundeID");
                    KundeID = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast RegNr");
                    RegNr = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Mærke");
                    Mærke = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Model");
                    Model = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Brændstoffstype");
                    Brændstoffstype = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast OprettelsesDato");
                    OprettelsesDato = Convert.ToString(DateTime.Now.ToString("d/M/yyyy"));
                    Console.Clear();
                    Console.WriteLine("Indtast Kmkørt");
                    KmKørt = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Indtast Årgang");
                    Årgang = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Her er informationen der er registeret.\nTjek om oplysningerne stemmer overens med det ønskede,\nhvis ikke kan du rette det herunder.\n");
                        Console.WriteLine($"Kunde ID : {KundeID}");
                        Console.WriteLine($"Registreringsnummer : {RegNr}");
                        Console.WriteLine($"Mærke : {Mærke}");
                        Console.WriteLine($"Model : {Model}");
                        Console.WriteLine($"Brændstoffstype : {Brændstoffstype}");
                        Console.WriteLine($"OprettelsesDato : {OprettelsesDato}");
                        Console.WriteLine($"Kilometer kørt : {KmKørt}");
                        Console.WriteLine($"Årgang : {Årgang}");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n\n [r]ediger eller [o]k");
                        key = Console.ReadKey().Key;
                        Console.Clear();
                        if (key == ConsoleKey.R)
                        {
                            Console.Clear();
                            Console.WriteLine("Indtast linje nr på det der skal rettes\n");
                            Console.WriteLine($"1.Kunde ID : {KundeID}");
                            Console.WriteLine($"2.Registreringsnummer : {RegNr}");
                            Console.WriteLine($"3.Mærke : {Mærke}");
                            Console.WriteLine($"4.Model : {Model}");
                            Console.WriteLine($"5.Brændstoffstype : {Brændstoffstype}");
                            Console.WriteLine($"6.OprettelsesDato : {OprettelsesDato}");
                            Console.WriteLine($"7.Kilometer kørt : {KmKørt}");
                            Console.WriteLine($"8.Årgang : {Årgang}");
                            key = Console.ReadKey().Key;
                            Console.Clear();
                            if (key == ConsoleKey.D1)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast KundeID");
                                KundeID = Console.ReadLine();
                            }
                            else if (key == ConsoleKey.D2)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast RegNr");
                                RegNr = Console.ReadLine();
                            }
                            else if (key == ConsoleKey.D3)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast Mærke");
                                Mærke = Console.ReadLine();
                            }
                            else if (key == ConsoleKey.D4)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast Model");
                                Model = Console.ReadLine();
                            }
                            else if (key == ConsoleKey.D5)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast Brændstoffstype");
                                Brændstoffstype = Console.ReadLine();
                            }
                            else if (key == ConsoleKey.D6)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast OprettelsesDato format: dag-måned-år");
                                OprettelsesDato = Console.ReadLine();
                            }
                            else if (key == ConsoleKey.D7)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast Kmkørt");
                                KmKørt = Convert.ToDouble(Console.ReadLine());
                            }
                            else if (key == ConsoleKey.D8)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast Årgang");
                                Årgang = Convert.ToInt16(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Indtast gyldig værdi");
                                Console.ReadKey();
                            }
                        }
                        else if (key == ConsoleKey.O)
                        {
                        }
                        else
                        {
                            Console.WriteLine("Indtast gyldig værdi");
                            Console.ReadKey();
                        }
                    } while (key != ConsoleKey.O);

                    Sql_Methods.opretBil(KundeID,RegNr,Mærke,Model,Brændstoffstype,OprettelsesDato,KmKørt,Årgang);
                }
                else if (key == ConsoleKey.D2)
                {
                    Console.WriteLine("Opdater Bil");
                    Console.WriteLine("Indtast RegNr");
                    RegNr = Console.ReadLine();
                    Sql_Methods.Select(RegNr);
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Indtast gyldig værdi");
                }
                Console.ReadKey();
            } while (key != ConsoleKey.D1 && key != ConsoleKey.D2);
        }
    }
}
