using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            string str1 = string.Empty;
            str1 = "Ali Barkın Kara";
            string ad = "Ali Barkın";
            string soyad = "Kara";
            string tamisim = ad + " " + soyad;
            Console.WriteLine(tamisim);


            //
            int sayi1 = 5;
            int sayi2 = 10;
            int sayi3 = sayi1 * sayi2;
            Console.WriteLine(sayi3);

            //
            string str4 = "200";
            int int4 = 20;
            string yeni=str4+ int4.ToString();
            Console.WriteLine(yeni);

            //
            int int5=int4+ Convert.ToInt32(str4);
            Console.WriteLine(int5);

            //

           
        }

    }
}
