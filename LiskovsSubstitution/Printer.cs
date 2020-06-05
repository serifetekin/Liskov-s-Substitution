using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovsSubstitution
{
    // Liskovs Substitution kullanılarak çözülmüş hali
    interface IPrinter
    {
        void Yaz();
    }
    interface IScanner
    {
        void Tara();
    }
    interface IPrinterColored
    {
        void RenkliYaz();
    }

    class Printer : IPrinter
    {
        public void Yaz()
        {
            Console.WriteLine("Yazdım");
        }
    }

    class Scanner : IScanner
    {
        public void Tara()
        {
            Console.WriteLine("Taraım");
        }
    }

    class PrinterColored : IPrinter, IPrinterColored
    {
        public void Yaz()
        {
            Console.WriteLine("Yazdım");
        }
        
        public void RenkliYaz()
        {
            Console.WriteLine("RenkliYaz Yazdım");
        }
    } 
    
    class OnlyColored : PrinterColored
    {
        private void Yaz() // private olduğunda üst sınıfının içeriğini kullanır.!!
        {
            Console.WriteLine("OnlyColored YAZ");
        }
        
    }
}
