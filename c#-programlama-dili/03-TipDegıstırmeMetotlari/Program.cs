using System;

namespace _03_TipDegıstırmeMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Convert sınıfı ile tip değiştirme

            string sayi1 = "5";
            string sayi2 = "6";

            int toplam = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);

            Console.WriteLine($" sonuç = {toplam}");
            Console.WriteLine($" sonuç = {sayi1 + sayi2}");

            //int sonuc = Convert.ToInt32("78") - Convert.ToInt32("20");
            //int sonuc = Convert.ToInt32("78") - Convert.ToInt32(Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2));

            char karakter = Convert.ToChar(sayi1);
            // bu şekildde convert ederek sayı1'i char tipine de dönüştürebilirim. 
            //ama char tipine 5p gibi bir değer veremem,  char tipi tek bir değer alır iki tane almaz.

            int birincisayi = 8;
            int ikincisayi = 9;
            //double sonuc = birincisayi / ikincisayi; // int tipinde değerler olduğu için sonuç virgüllü olarak bize dönmez.

            double sonuc = Convert.ToDouble(birincisayi) / Convert.ToDouble(ikincisayi);
            Console.WriteLine($" sonuç = {sonuc}");
            // burda ise convert işlemi ile ınt değerleri doubleye çevirdiğim için virgüllü sayı alırım.


            int a = 0;
            int b = 1;
            bool c = Convert.ToBoolean(a);
            bool d = Convert.ToBoolean(b);

            #endregion

            //toplam = int.Parse(sayi1) + int.Parse(sayi2);
            //Console.WriteLine("sonuç = " + toplam);

            //decimal virgullusonuc = decimal.Parse(sayi1) / decimal.Parse(sayi2);
            //Console.WriteLine("sonuç = " + virgullusonuc);

            Console.WriteLine("birinci sayıyı giriniz..");
            int birincisayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz..");
            int ikincisayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("girdiğin sayıların ortalaması..");
            //int sonuc = (birincisayi1 + ikincisayi2 (sonuc /);
            //int ortalama = int.Parse(birincisayi1) + int.Parse(ikincisayi2) / sonuc;


        }


            


    }


            Console.ReadKey();




}