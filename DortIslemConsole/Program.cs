using System;

namespace DortIslemConsole
{
    public class Program : Method
    {
        static void Main(string[] args)
        {
            bool hata = false;
            var inputVal = "";
            int sayi1 = 0, sayi2 = 0;


            do
            {
                Console.WriteLine("\n 1. Sayıyı Giriniz ");
                inputVal = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputVal) && IsInt(inputVal))
                {
                    sayi1 = Int32.Parse(inputVal);
                    hata = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n Girilen Değer Tam Sayı Olmalı ");
                    hata = true;
                }

            } while (hata);

            do
            {
                Console.WriteLine("\n 2. Sayıyı Giriniz ");
                inputVal = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputVal) && IsInt(inputVal))
                {
                    sayi2 = Int32.Parse(inputVal);
                    hata = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n Girilen Değer Tam Sayı Olmalı ");
                    hata = true;
                }

            } while (hata);

            var op = "";
            do
            {
                Console.WriteLine("\n Matematiksel Operatörü Giriniz ");
                Console.WriteLine("İstenilen Operatör Tipleri: (+), (-), (/), (*) olmalıdır. \n");
                op = Console.ReadLine();
                if (!string.IsNullOrEmpty(op) && IsOp(op))
                { 
                    hata = false;
                }
                else
                {
                    Console.Clear(); 
                    hata = true;
                }

            } while (hata);

            Console.WriteLine("\nİşlem Görünümü:\n");
            switch (op)
            {
                case "+":
                    Console.WriteLine($"{sayi1} + {sayi2} = {Topla(sayi1, sayi2)}");
                    break;
                case "-":
                    Console.WriteLine($"{sayi1} - {sayi2} = {Cikart(sayi1, sayi2)}");
                    break;
                case "/":
                    Console.WriteLine($"{sayi1} - {sayi2} = {Bol(sayi1, sayi2)}");
                    break;
                case "*":
                    Console.WriteLine($"{sayi1} - {sayi2} = {Carp(sayi1, sayi2)}");
                    break;

                default:
                    Console.Clear(); 
                    Console.WriteLine("Bye Bye");
                    Console.ReadLine();
                    break;
            }

            Console.WriteLine("\nBu Kadar Görüşürüz");
            Console.ReadLine();
            Environment.Exit(0);
            
            
        }
    }
}
