using System.ComponentModel.Design;

namespace MantıksalOperatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //Console.WriteLine("kullanıcı adı giriniz..");
            //string kullaniciAdi = Console.ReadLine();
            //Console.WriteLine("şifre giriniz ");
            //string sifre = Console.ReadLine();

            // == bu ise, else değil ise demek. kullanıcı adını doğru girdiğinde : Console.WriteLine("kullanıcı adınız doğru "); alanına girer.
            //hatalı girersen o kısma hiç girmez direkt else girer.
            //if (kullaniciAdi == "minel")
            //{
            //    Console.WriteLine("kullanıcı adınız doğru ");
            //}
            //else
            //{
            //    Console.WriteLine("kullanıcı adı hatalı ");
            //}

            // == eşit ise demek, != eşit değil ise demek.
            //if (kullaniciAdi != "minel")
            //}
            //  Console.WriteLine("kullanıcı adınız hatalı");
            // }

            //if (kullaniciAdi == "minel")
            //    Console.WriteLine("kullanıcı adı dogru ");
            //else
            //    Console.WriteLine("kullanıcı adın hatalı ");

            //if (sifre == "123")
            //    Console.WriteLine("şifre doğru");
            //else
            //    Console.WriteLine("şifre hatalı");

            //Console.WriteLine("Hello, World!");



            // if içinde if yazma, kullanıcı adımın yazdığı bloğun içine şifre doğrulama kodlarını giriyorum. eğer kullanıcı adını doğru
            // girersem onu kontrol eder sonra şifreyi kontrol eder, en alttaki kullanıcı adı elsine hiç bakmaz, doğru girdiğim için
            // kullanıcı adını yanlış girersem artık şifreyi hiç kontrol etmez direkt en alttaki kullanıcı adı else çalışır ve 
            // kullanıcı adı hatalı der. şifre hatalı veya doğru demez.
            //if (kullaniciAdi == "minel")
            //{
            //    Console.WriteLine("kullanıcı adınız doğru ");


            //    if (sifre == "123")
            //        Console.WriteLine("şifre doğru");
            //    else
            //        Console.WriteLine("şifre hatalı");

            //}

            //else
            //{
            //    Console.WriteLine("kullanıcı adı hatalı ");
            //}


            //kullanıcının 4 sayı girmesini isteyelim
            //negatif bir sayı girdi ise uyarı verip uygulamyı bitirelim
            //pozitif sayı girdi ise, ikinci sayıyı girmesini isteyelim
            //ikinci sayıda negatif bir sayı girdi ise uyarı verip uygulamayı bitirelim
            //pozitif sayı girdi ise iki sayının çarpımını ekrana yazdıran kod bloğu

            //birkaç yöntemle yapılabilir. içi boş olacak şekilde bir değişken oluşturabilirim ve çift sayıları bunu içine atmam yeterli olur.
            // sayi1 % 2 == 0 bu kavram syı bir eğer 2 ve katlarına eşitse demek oluyor.
            //her biri için ayrı ayrı if yazıyorum elseyi kullanmıyorum eğer şart tutmaz else girerse 
            //kodu sonlandırır. ama ben tüm sayıları kontrol etmek istiyorum.
            Console.WriteLine("birinci sayıyı giriniz..");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayıyı giriniz..");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("üçüncü sayıyı giriniz..");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dördüncü sayıyı giriniz..");
            int sayi4 = Convert.ToInt32(Console.ReadLine());

            string sonuc = "";

            if (sayi1 % 2 == 0)
               sonuc += sayi1 + ", ";

            if (sayi2 % 2 == 0)
                sonuc += sayi2 + ", ";

            if (sayi3 % 2 == 0)
               sonuc += sayi3 + ", ";

            if (sayi4 % 2 == 0)
               sonuc += sayi4 + ", ";

            Console.WriteLine(sonuc);


            //bunu birde hiç değişken kullanmadan yapabiliriz. writeline metodumuz alt alta yazma işlemi yaparken write metodumuz
            //yan yana yazma işlemi yapar. dolayısıyla bunu write metoduyla yapabiliriz.


            Console.WriteLine("birinci sayıyı giriniz..");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayıyı giriniz..");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("üçüncü sayıyı giriniz..");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dördüncü sayıyı giriniz..");
            int sayi4 = Convert.ToInt32(Console.ReadLine());



            if (sayi1 % 2 == 0)
                Console.Write(sayi1 + ", ");


            if (sayi2 % 2 == 0)
                Console.Write(sayi2 + ", ");


            if (sayi3 % 2 == 0)
                Console.Write(sayi3 + ", ");

                    
            if (sayi4 % 2 == 0)
                Console.Write(sayi4 + ", ");







            Console.ReadKey();


                

            //burda & simgesi ile iki şeyi sorgulatabilirim. kullanıcı adı ve şifreyi ayrı ayrı sorgulatıp, ayrı ayrı örneğin kullanıcı adı
            //doğru şifre hatalı gibi bir sonuç almadım. iki şartı birlikte girip eğer buysa giriş yapabilir yazdığım için şartların birini yanlış
            // girersem kullanıcı adı veya sifre yanlı diyor. hangisinin atalı olduğunu bilmiyorsun.
         ///    if (kullaniciAdi == "minel" & sifre == "123")

         //        Console.WriteLine("giriş başarılı");
         ///    else
         ///        Console.WriteLine("kullanıcı adı veya şifre hatalı ");





            //if'te boll kullanımı. boll yalnızca true ya da false değer alabiliyordu.

            
            bool EvliMi = false;
            
            //if (EvliMi == true)
            //{
            //    console.WriteLine("Evli");
            //}
            //if (EvliMi == false)
            //{
            //    console.wrıteline("EvliDeğil");
            //}
            //if (EvliMi != true)
            //{
            //    console.wrıteline("EvliDeğil");
            //}
            //if (EvliMi != false)
            //{
            //    console.wrıtelıne("Evli");
            //}
            //if (EvliMi)
            //{
            //    console.wrıteline("Evli");
            //}
            //if (!EvliMi)
            //{
            //    console.wrıteline("EvliDeğil");
            //}

            //burda if (EvliMi) diye de sorgulatabiliriz sadece bunu evli mi == true olarak algılar.bunun tam tersi de if (!EvliMi)
            //bu da başına ünlem eklediğimde evli  değile karşılık, yani evli mi == false ile aynı işlem.





            //ternary operator: tek satırda if ve else'yi yazma durumu. bu durumu eğer kodum tek satırdan oluşuyorsa kullanabilirim
            //yani evli mi değil mi tek satır. ama iki satır olursa olmaz.
            //burda ? işareti if anlamına geliyor yani buysa : işareti ise else anlamına geliyor yani değilse.
            string sonuc = EvliMi ? "evli" : "evli değil";



        }





    }
}