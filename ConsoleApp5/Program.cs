using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handler;

            handler = new XMLHandler();
            handler.Open();
            handler.Change();
            handler.Create();
            handler.Save();

            handler = new TXTHandler();
            handler.Open();
            handler.Change();
            handler.Create();
            handler.Save();

            handler = new DOCHandler();
            handler.Open();
            handler.Change();
            handler.Create();
            handler.Save();
            Console.ReadKey();
        }
    }
}
