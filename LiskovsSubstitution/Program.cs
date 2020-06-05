using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovsSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterColored pc = new PrinterColored();
            
            pc.RenkliYaz();
            pc.Yaz();

            Printer p = new Printer();

            p.Yaz();

            OnlyColored oc = new OnlyColored();

            oc.Yaz();

            Console.ReadLine();
        }
    }
}
