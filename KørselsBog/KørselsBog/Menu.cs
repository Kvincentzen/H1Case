using System;
namespace KørselsBog
{
    public class Menu
    {
        public Menu()
        {
            ConsoleKey key = new ConsoleKey();
            Console.WriteLine("1.Kunde\n2.Medarbejder");
            if(key == ConsoleKey.D1){
                
            }else if(key == ConsoleKey.D2){
                
            }else{
                Console.WriteLine("Indtast gyldig værdi");
            }
        }
    }
}
