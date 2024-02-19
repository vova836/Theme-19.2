using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open DOC document format");
        }
        public override void Change()
        {
            Console.WriteLine("Change DOC document format");
        }
        public override void Create()
        {
            Console.WriteLine("Create DOC document format");
        }
        public override void Save()
        {
            Console.WriteLine("Save DOC document format");
        }
    }
}
