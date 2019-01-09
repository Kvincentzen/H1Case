using System;
namespace KørselsBog
{
    public class Menu
    {
        #region Hovedmenu
        public void Hovedmenu()
        {   
            ConsoleKey key = new ConsoleKey();
            do {
                Console.Clear();
                Console.WriteLine("1.Bil\n2.Kunde\n3.Kundeoversigt");
                key = Console.ReadKey().Key;
                Console.Clear();
                if (key == ConsoleKey.D1) {
                    Bil();
                } else if (key == ConsoleKey.D2) {
                    Kunde();

                }
                else if (key == ConsoleKey.D3)
                {
                    Kundeoversigt();
                }
                else {
                    Console.WriteLine("Indtast gyldig værdi");
                }
                Console.ReadKey();
            } while (key != ConsoleKey.D1 && key != ConsoleKey.D2);
        }
        #endregion
        #region Bilmenu
        private void Bil()
        {
            ConsoleKey key = new ConsoleKey();
            string KundeID, RegNr, Mærke, Model, Brændstoffstype, OprettelsesDato;
            int KmKørt;
            int Årgang;
            do
            {
                Console.Clear();
                Console.WriteLine("Bil");
                Console.WriteLine("1.Opret Bil\n2.Opdater Bil\n3.Slet Bil\n4.Vis Bil\n5.Vis Værkstedsbesøg\n6.Opret Værkstedsbesøg\n7.Slet Værkstedsbesøg\n8.Tilbage til hovedmenuen");
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
                    Console.WriteLine("Indtast Brændstofstype");
                    Brændstoffstype = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast OprettelsesDato");
                    OprettelsesDato = Convert.ToString(DateTime.Now.ToString("d/M/yyyy"));
                    Console.Clear();
                    Console.WriteLine("Indtast Kmkørt");
                    KmKørt = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Indtast Årgang");
                    Årgang = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Her er informationen der er registeret.\nTjek om oplysningerne stemmer overens med det ønskede,\nhvis ikke kan du rette det herunder.\n");
                        Console.WriteLine($"Kunde ID : {KundeID}");
                        Console.WriteLine($"Registreringsnummer : {RegNr}");
                        Console.WriteLine($"Mærke : {Mærke}");
                        Console.WriteLine($"Model : {Model}");
                        Console.WriteLine($"Brændstofstype : {Brændstoffstype}");
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
                            Console.WriteLine($"5.Brændstofstype : {Brændstoffstype}");
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
                                Console.WriteLine("Indtast Brændstofstype");
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
                                KmKørt = Convert.ToInt32(Console.ReadLine());
                            }
                            else if (key == ConsoleKey.D8)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast Årgang");
                                Årgang = Convert.ToInt32(Console.ReadLine());
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
                    Console.Clear();
                    Console.WriteLine("Indtast KundeID");
                    KundeID = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Mærke");
                    Mærke = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Model");
                    Model = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Brændstofstype");
                    Brændstoffstype = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast OprettelsesDato");
                    OprettelsesDato = Convert.ToString(DateTime.Now.ToString("d/M/yyyy"));
                    Console.Clear();

                    Console.WriteLine("Indtast Kmkørt");
                    KmKørt = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Indtast Årgang");
                    Årgang = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Sql_Methods.UpdateBil(RegNr, KundeID, Mærke, Model, Brændstoffstype, OprettelsesDato, KmKørt.ToString(),Årgang);
                    Bil();
                }
                else if (key == ConsoleKey.D3)
                {
                    Console.WriteLine("Slet Bil");
                    Console.WriteLine("Indtast RegNr");
                    RegNr = Console.ReadLine();
                    Sql_Methods.DeleteFromBil(RegNr);
                    //SLET BIL MED DET RegNr
                }
                else if (key == ConsoleKey.D4)
                {
                    Console.WriteLine("Vis Bil");
                    Console.WriteLine("Indtast RegNr");
                    RegNr = Console.ReadLine();
                    Console.Clear();
                    Sql_Methods.SelectBil($"SELECT * FROM Bil WHERE RegNr = '" +RegNr+"'");
                }
                else if (key == ConsoleKey.D5)
                {
                    Console.WriteLine("Vis Værkstedsbesøg");
                    Console.WriteLine("Indtast RegNr");
                    RegNr = Console.ReadLine();
                    Console.Clear(); 
                    Sql_Methods.SelectVærksted($"SELECT * FROM Værkstedsbesøg WHERE regnr = '" + RegNr + "'");
                }
                else if (key == ConsoleKey.D6)
                {
                    string DatoAnkomst, Datoafgang, Mekaniker;
                    Console.WriteLine("Opret Værkstedsbesøg");
                    Console.WriteLine("Indtast RegNr");
                    RegNr = Console.ReadLine();
                    Console.WriteLine("Indtast DatoAnkomst");
                    DatoAnkomst = Console.ReadLine();
                    Console.WriteLine("Indtast Datoafgang");
                    Datoafgang = Console.ReadLine();
                    Console.WriteLine("Indtast Mekaniker");
                    Mekaniker = Console.ReadLine();
                    Sql_Methods.opretVærkstedsbesøg(DatoAnkomst, Datoafgang, Mekaniker, RegNr);
                }
                else if (key == ConsoleKey.D7)
                {
                    Console.WriteLine("Slet Værkstedsbesøg");
                    Console.WriteLine("Indtast RegNr");
                    RegNr = Console.ReadLine();
                    //Sql_Methods.SelectVærkstedsbesøg(RegNr);
                }
                else if (key == ConsoleKey.D8)
                {
                    Hovedmenu();
                }
                else
                {
                    Console.WriteLine("Indtast gyldig værdi");
                }
                Console.ReadKey();
            } while (key != ConsoleKey.D1 && key != ConsoleKey.D2 && key != ConsoleKey.D3);
        }
        #endregion
        #region Kundemenu
        private void Kunde()
        {
            ConsoleKey key = new ConsoleKey();
            string KundeID, navn, adr, fødselsdagsdat, OprettelsesDato;
            do
            {
                Console.Clear();
                Console.WriteLine("Kunde");
                Console.WriteLine("1.Opret Kunde\n2.Opdater Kunde\n3.Slet Kunde\n4.Vis Kunde\n5.Tilbage til hovedmenuen");
                key = Console.ReadKey().Key;
                Console.Clear();
                if (key == ConsoleKey.D1)
                {
                    Console.WriteLine("Opret Kunde");
                    Console.WriteLine("Indtast KundeID");
                    KundeID = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Navn");
                    navn = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Adresse");
                    adr = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Fødselsdagsdato");
                    fødselsdagsdat = Console.ReadLine();
                    Console.Clear();
                    OprettelsesDato = Convert.ToString(DateTime.Now.ToString("d/M/yyyy"));
                    Console.Clear();
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Her er informationen der er registeret.\nTjek om oplysningerne stemmer overens med det ønskede,\nhvis ikke kan du rette det herunder.\n");
                        Console.WriteLine($"Kunde ID : {KundeID}");
                        Console.WriteLine($"Navn : {navn}");
                        Console.WriteLine($"Adresse : {adr}");
                        Console.WriteLine($"Fødselsdag : {fødselsdagsdat}");
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
                            Console.WriteLine($"2.Navn : {navn}");
                            Console.WriteLine($"3.Adresse : {adr}");
                            Console.WriteLine($"4.Fødselsdag : {fødselsdagsdat}");
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
                                Console.WriteLine("Indtast Navn");
                                navn = Console.ReadLine();
                            }
                            else if (key == ConsoleKey.D3)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast Adresse");
                                adr = Console.ReadLine();
                            }
                            else if (key == ConsoleKey.D4)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast Fødselsdag");
                                fødselsdagsdat = Console.ReadLine();
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

                    Sql_Methods.opretKunde(KundeID, navn, adr, fødselsdagsdat,OprettelsesDato);
                }
                else if (key == ConsoleKey.D2)
                {
                    Console.WriteLine("Opdater Kunde");
                    Console.WriteLine("Indtast KundeID");
                    KundeID = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Navn");
                    navn = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Adresse");
                    adr = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Indtast Fødselsdagsdato");
                    fødselsdagsdat = Console.ReadLine();
                    Console.Clear();
                    Sql_Methods.UpdateKunde(KundeID, navn, adr, fødselsdagsdat);
                }
                else if (key == ConsoleKey.D3)
                {
                    Console.WriteLine("Slet Kunde");
                    Console.WriteLine("Indtast Kunde ID");
                    KundeID = Console.ReadLine();
                    Sql_Methods.DeleteFromBil(KundeID);
                    Sql_Methods.DeleteFromKunder(KundeID);
                }
                else if (key == ConsoleKey.D4)
                {
                    Console.WriteLine("Vis Kunde");
                    Console.WriteLine("Indtast Kunde ID");
                    KundeID = Console.ReadLine();
                    Console.Clear();
                    Sql_Methods.SelectKunder($"SELECT * FROM Kunder WHERE KundeID = " + KundeID);
                }
                else if (key == ConsoleKey.D5)
                {
                    Hovedmenu();
                }
                else
                {
                    Console.WriteLine("Indtast gyldig værdi");
                }
                Console.ReadKey();
            } while (key != ConsoleKey.D1 && key != ConsoleKey.D2);
        }
        #endregion
        public void Kundeoversigt()
        {
            Console.WriteLine("Kundeoversigt");
            Console.WriteLine("-------------");
            Sql_Methods.SelectKunder($"SELECT KundeID, Navn, Adresse, Fødselsdato FROM Kunder ORDER BY Navn ASC");
        }
    }
}
