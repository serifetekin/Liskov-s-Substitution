using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovsSubstitution.Klasik
{
    interface IPrinter
    {
        void Yaz();
        void RenkliYaz();
        void Tara();
    }

    class Printer : IPrinter
    {
        public void Yaz()
        {
            Console.WriteLine("Yazdım");
        }
        public void Tara()
        {
            Console.WriteLine("Bu özellik burda yok");
        }
        public void RenkliYaz()
        {
            Console.WriteLine("Bu özellik burda yok");
        }
    }

    class Tarayici: IPrinter
    {
        public void Yaz()
        {
            Console.WriteLine("Bu özellik burda yok");
        }
        public void Tara()
        {
            Console.WriteLine("Taradım");
        } 
        public void RenkliYaz()
        {
            Console.WriteLine("Bu özellik burda yok");
        }
    } 
    
    class RenkliYazici : IPrinter
    {
        public void Yaz()
        {
            Console.WriteLine("Siyah beyaz yazdım");
        }
        public void Tara()
        {
            Console.WriteLine("Bu özellik burda yok");
        } 
        public void RenkliYaz()
        {
            Console.WriteLine("RenkliYazdım");
        }
    }
}
