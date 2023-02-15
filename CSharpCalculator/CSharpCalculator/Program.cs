using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdWeekP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0, num2 = 0, result = 0;

                Console.WriteLine("---------------------");
                Console.WriteLine("---Hesap Makinası---");
                Console.WriteLine("---------------------");

                Console.Write("Birinci sayıyı giriniz : ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci sayıyı giriniz : ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Yapılabilecek İşlemler : ");
                Console.WriteLine("\t+ : Ekle");
                Console.WriteLine("\t- : Çıkart");
                Console.WriteLine("\t* : Çarp");
                Console.WriteLine("\t/ : Böl");

                Console.Write("İşlem seçiniz : ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"İşlemin Sonucu : {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"İşlemin Sonucu : {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"İşlemin Sonucu : {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"İşlemin Sonucu : {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Geçersiz İşlem!");
                        break;
                }
                Console.WriteLine("İşleme Devam Etmek ister misiniz? ( E = Evet , H = Hayır) :  ");
            } while (Console.ReadLine().ToUpper() == "E");

            Console.ReadKey();





        }
    }
}