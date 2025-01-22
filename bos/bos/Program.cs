namespace bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan bır metın girmesini istetelim
            //kaç sefer ekrana yazdırmak istiyorsun?


            //kullanıcıdan bır metın istıyorum, bu metne bır değişken atamam gerekiyor kı gırılen degerı o değişken ile
            //for dongusunde ekrana yazdırabılıyım.
            //daha sonra kac kez tekrar etmek ıstedıgını soruyorum. buna da deger ataması yapıyorum o degerı alıp ekrana yazabılmek
            //ıcın.
            //burda convert ışlemi yapıyorum cunku kullanıcıdan bır sayı ıstedım strıngı ınte ceviriyorum.
            //int i yi 0 tanımladım ve eğer sayım buyukse 0 dan atadıgım deger olan sayi kadar tekrarla demiş oldum.
            //ekrana yazması ıcın de metın değerini girdim.
            //Console.WriteLine("bir metin giriniz");
            //string metın = Console.ReadLine();
            //Console.WriteLine("kac sefer tekrar etmek istiyorsun?");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < sayi;  i++)
            //{
            //    Console.WriteLine(metın);
            //}



            //forlarda da iç içe kullanma yapabiliyoruz. alt alta for atadığımda atadıgım deışken isimlerini değiştiriyorum.
            //farklı farklı değişkenler atıyorum
            //cunku bız bır parantez içinde aynı ısımle bır değişken tanımlayabiliyorduk.
            //burda i değişkenin adını değiştirip adını sayı yapmak istiyorsam, int yanına sayı olarak yazıyorum ve ctrl. yapıyorum
            //burda menu cıkyor ve i değişkenını sayı olarak değiştır diyor tum i degışkenlerini sayı olarak değiştiriyor.
            //önce ilk for da sayı değişkeni ile birlikte bir dongu olusturdum ve 1 den 15e kadar donuyorum.
            //iççine yazdığım forda harf değişkenini atıyorum.
            //kod calıştıgında sayı 1 oldugunda asagıdakı koda gectıgınde a dan k ya kadar donuyor. ardından bu fordan cıkıp
            //asagı geldıgınde
            //tekrar yukarı donuyor ve 1i 2 yapıp tekrar a dan k ya kadar donuyor. sonra tekrar yukarı cıkıyor ve 3 yapıyor
            //asagıda a dan kya kadar donuyor.
            //yukardakı kod 1 den 15 tane yazdırıyor asagı ındıgınde ıse adan k ya kadar olan harfleri sırayla 1lerin karsısına
            //yazdırıyor.

            //for (int sayi = 1; sayi < 15; sayi++)
            //{
            //    for (char harf = 'A'; harf < 'K'; harf++)
            //    {
            //        Console.WriteLine($"Sayı={sayi}-Harf={harf}");
            //    }
            //}



            //1*1=
            //1*2=2
            //1*3=3
            //**
            //2*1=2
            //2*2=4 diye ekrana yazdır.
            //burda benim ilk once 1leri 10 kere alt alta yazdırmam lazım. yanına da 123 dıye tekrardan yazmamız gerekiyor.
            //dolayısıyla benım ılk dongum alt alta 1 yazdıran dongum olması lazım.
            //soldakılerın carpılan olması gerekır buna carpılan dıye değer atıyorum. baslayacagı deger de 1 olması lazım
            //ve 10a kadar devam ettırıyorum.
            //altına da for içine for eklıyorum ve carpan değişkenı atıyorum.1den baslayacak ve 10a kadar devam edecek.
            //ve console.wrıtelıne ıle ekrana carpılan * carpan = carpılan* carpan olarak en son ışlem sonucunu yazdıyorum.

            for (int carpılan = 1; carpılan <= 10; carpılan++)
            {
                for (int carpan = 1; carpan <= 10; carpan++)
                {
                    Console.WriteLine($"{carpılan}*{carpan}={carpılan * carpan}");
                }
            }


            //for (int sayi = 1; sayi < 10; sayi++)
            //{
            //    for ( int sayi2 = 1; sayi2 < 10 ; sayi2++)
            //    {
            //        Console.WriteLine(sayi = sayi2);
            //    }
            //}





            Console.ReadKey();

        }
    }
}