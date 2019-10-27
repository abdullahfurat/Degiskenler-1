using System;

namespace Degiskenler_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tam sayı veri tipleri

            // byte : 8-bit unsigned integer
            //  MaxValue = 255;
            //  MinValue = 0;
            byte s1 = 255;
            // ------------------------------------------------

            // sbyte : 8-bit signed integer.
            // MinValue = -128;
            // MinValue = -128;
            sbyte s2 = 123;
            // ------------------------------------------------

            // short : 16-bit signed integer.
            // MaxValue = 32767;
            // MinValue = -32768;
            short s3 = 24321;
            // ------------------------------------------------

            // ushort : 16-bit unsigned integer.
            // MaxValue = 65535;
            // MinValue = 0;
            ushort s4 = 21321;
            // ------------------------------------------------

            // int : 32-bit signed integer
            // MaxValue = 2147483647;
            // MinValue = -2147483648;
            int s5 = 1231;
            // ------------------------------------------------

            // uint : 32-bit unsigned integer.
            // MaxValue = 4294967295;
            // MinValue = 0;
            uint s6 = 12321;
            // ------------------------------------------------

            // long : 64-bit signed integer.
            // MaxValue = 9223372036854775807;
            // MinValue = -9223372036854775808;
            long s7 = 12312;
            // ------------------------------------------------

            // ulong : 64-bit unsigned integer.
            // MaxValue = 18446744073709551615;
            // MinValue = 0;
            ulong s8 = 2321;



            // Ondalıklı veri tipleri 
            // float
            float o1 = 1.1F;

            // double
            double o2 = 1.1;

            // decimal
            decimal o3 = 1.1M;
             
            // Metinsel veri tipleri
            // char
            char karakter = 'A';  //    65/A


            // string
            string metin = "\tB\n\ti\n\tl\n\tg\n\te\n\tA\n\td\n\ta\n\tm";
            // \n (new line) bir alt satıre geç
            // \t (tab space) bir tab boşluk ekler

            Console.WriteLine(metin);
            Console.ReadLine();
            // Mantıksal veri tipi
            // bool
            bool result = 10 > 1; // true

        }
    }
}
