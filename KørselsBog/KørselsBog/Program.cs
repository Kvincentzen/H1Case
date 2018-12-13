using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KørselsBog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Menu M = new Menu();
            Sql_Methods.Select("Select * from kunder");
            Console.ReadKey();
        }
    }
}
