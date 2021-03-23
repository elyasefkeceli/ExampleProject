using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary sınıfı içinde belirlenen bir key e uygun olarak değer saklar.
            //key türünü belirlememiz şart.(int,string....)
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            AdYas.Add("faruk",25);
            AdYas.Add("furkan",26);
            AdYas.Add("fatih",30);

            foreach (var degerOku in AdYas)
            {
                Console.WriteLine(degerOku);
            }
            //değer sayma özelliği
            var item = AdYas.Count;
            Console.WriteLine();
            Console.WriteLine("eleman sayisi :" + item );

            //silme işlemi
            AdYas.Remove("furkan");
            Console.WriteLine();
            foreach (var degerOku in AdYas)
            {
                Console.WriteLine(degerOku);
            }
        }
    }
}
