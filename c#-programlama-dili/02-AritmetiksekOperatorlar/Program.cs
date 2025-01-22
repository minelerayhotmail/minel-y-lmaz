using System;

namespace _02_AritmetiksekOperatorlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (+)OPERATÖRÜ
            // sayısal değerlerde toplama işlemi yapmak için kullanılır.
            // metinsel değerleri birleştirmek için kullanılır.

            int toplam = 5 + 10 + (8 + 4);
            Console.WriteLine("sonuç =" + toplam);


            decimal fiyat1 = 125.53M;
            decimal fiyat2 = 25.21M;

            decimal toplamFiyat = fiyat1 + fiyat2;
            Console.WriteLine("Toplam Ücret = " + toplamFiyat + " TL");
            Console.WriteLine("toplam ücret = " + (fiyat1 + fiyat2) + " TL");

            Console.WriteLine("toplam ücret = " + fiyat1 + fiyat2 + "TL");
            Console.WriteLine(fiyat1 + fiyat2 + " TL");
            Console.WriteLine(" " + fiyat1 + fiyat2);
            Console.WriteLine(fiyat1+ fiyat2);
            Console.WriteLine(fiyat1 + fiyat2 + 10);

            // + operatörü kullanmadan metinsel deerlerin birleştirilmesi
            Console.WriteLine($"toplam ücret =  {toplamFiyat} TL");


            string adi = "minel";
            string soyadi = "yilmaz";
            Console.WriteLine(adi + " " + soyadi);


            #endregion

            #region (-)operatörü
            // sayısal değerlerde çıkarma işlemi yapmak için kullanılır, metinsel değerlerde kullanılmaz.
            int sayi1 = 24;
            int sayi2 = 14;
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("sonuç = " + sonuc);
            Console.WriteLine("sonuç = " + (sayi2 - sayi1));
            Console.WriteLine(((sayi2 - sayi1) + (50 + 20)) + " sonuç");

           

            #endregion

            #region (*)operatörü
            // sayısal değerlerde çarpma işlemi yapmak için kullanılır, metinsel deerlerde kullanılmaz.

            sayi1 = 24;
            sayi2 = 14;
            sonuc = sayi1 * sayi2;
            Console.WriteLine("sonuç = " + sonuc);
            Console.WriteLine("sonuç = " + (sayi2 * sayi1));
            Console.WriteLine(((sayi2 * sayi1) + (50 + 20)) + " sonuç");

            // + operatörü kullanmadan metinsel deerlerin birleştirilmesi
            Console.WriteLine($"toplam ücret =  {sayi1 * sayi2} TL sayıların farkı = {sayi1 - sayi2} sayıların toplamı = {sayi1 + sayi2}");
            #endregion


            #region (/)operatörü
            // sayısal değerlerde bölme işlemi yapmak için kullanılır, metinsel değerlerde kullanılmaz.
            sayi1 = 5;
            sayi2 = 3;
            sonuc = sayi1 / sayi2;
            Console.WriteLine("sonuç = " + sonuc);

            decimal uzunluk1 = 5;
            decimal uzunluk2 = 3;
            Console.WriteLine("sonuç = " + (uzunluk1 / uzunluk2));

            #endregion

            #region (%)operatörü
            // sayısal değerler arasında mod alma işlemi yapmak için kullanılır, metinsel değerlerde kullanılmaz.
            // iki sayının değerinden kalan bölümü verir.

            sayi1 = 5;
            sayi2 = 3;
            Console.WriteLine("sonuç = " + (sayi1 % sayi2));
            #endregion

            #region İKİLİ OPERATÖR KULLANIMI
            int yas = 35;
            yas++;
            yas++;

            yas--;

            Console.WriteLine("sonuç = " + yas);

            int sayi5 = 65;
            --sayi5;
            ++sayi5;
            Console.WriteLine("sonuç = " + sayi5);

            int sayi6 = 36;
            sayi6 += 10;
            Console.WriteLine("sonuç = " + sayi6);
            sayi6 -= 10;
            Console.WriteLine("sonuç = " + sayi6);
            sayi6 *= 10;
            Console.WriteLine("sonuç = " + sayi6);
            sayi6 /= 10;
            Console.WriteLine("sonuç = " + sayi6);
            #endregion

            #region BOLL
            bool evlimi = true;
            Console.WriteLine("Evli mi =" + evlimi);
            Console.WriteLine("Evli mi =" + !evlimi);
            #endregion

            string sayi7 = "5";
            string sayi8 = "6";

            int eldekı = Convert.ToInt32(sayi7) + Convert.ToInt32(sayi8);

            Console.WriteLine($" sonuç = {eldekı}");
            Console.WriteLine($" sonuç = {sayi7 + sayi8}");
            int üst = Convert.ToInt32("78") - Convert.ToInt32(Convert.ToInt32(sayi7) + Convert.ToInt32(sayi8));
            Console.WriteLine($" sonuç = {üst}");

            Console.WriteLine("birinci sayıyi giriniz..");
            string sayi9 = Console.ReadLine();
            Console.WriteLine("ikinci sayıyi giriniz..");
            string sayi10 = Console.ReadLine();
            Console.WriteLine("toplam sayi " + {sayi9 + sayi10});






            Console.WriteLine("birinci sayıyı giriniz..");
            int birincisayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz..");
            int ikincisayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("girdiğin sayıların ortalaması..");

            // herhangi bir tuşa basılana dek console ekranı açık kalması için aşağıdaki kod satırı kullanılır.

            Console.ReadKey(); 
        }
    }

   
       
   
}
