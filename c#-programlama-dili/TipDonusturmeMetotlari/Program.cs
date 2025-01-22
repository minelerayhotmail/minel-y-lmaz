namespace TipDonusturmeMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("1. sınav notunu giriniz..");
            //int not1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2. sınav notunu giriniz..");
            //int not2 = int.Parse(Console.ReadLine());

            //double notortalaması = (((double)not1) + ((double)not2)) / 2;
            //Console.WriteLine("not ortalaması : " + notortalaması.ToString("n2"));


            //int sayi1 = 10;
            //int sayi2 = 20;

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("sayı1 büyüktür..");
            //}
            //else if (sayi1 == sayi2)
            //{
            //    Console.WriteLine("sayılar eşittir.");
            //}
            //else
            //{
            //    Console.WriteLine("sayı2 büyüktür..");
            //}



            //if (sayi1 > sayi2)
            //    Console.WriteLine("sayı1 büyüktür");
            //else if (sayi1 == sayi2)
            //    Console.WriteLine("sayılar eşittir");
            //else
            //    Console.WriteLine("sayı2 büyüktür");
            // burda da tek satırım varsa eğer süslü parantez acmadan kodumu yazabilirim. daha kısa yöntemi. eğer tek satır değilse bunu yapamam.
            // değerlerime ve,  veya gibi eklemeler yapabilirim örneğin (sayi1>sayi2 && sayi1 > 0) burda iki şarta bakar. eğer sayı1 sayı2 den
            // buyukse ve aynı zamanda sayı1 0 dan buyuk ise burdaki şart sağlanır. biri sağlanmıyorsa sağlanmamış olur.




            //ÖRNEK
            //kullanıcıdan bir sayı girmesini isteyelim.
            //negatif bir sayı girdi ise uyarı verip uygulamayı bitirelim
            //pozitif sayı girdi ise, ikinci sayıyı girmesini isteyelim.
            //ikinci sayıda negatif bir sayı girdi ise uyarı verip uygulamayı bitirelim.
            //pozitif bir sayı girdi ise iki sayının çarpımını ekrana yazdıran kod bloğu





            //Console.WriteLine(" lütfen birinci sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());


            //if (sayi1 <= 0)
            //{
            //    Console.WriteLine("negatif sayı girdiniz ");
            //} 
            //else
            //{
            //    Console.WriteLine("ikinci sayıyı giriniz ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    if (sayi2 <= 0)
            //    {
            //        Console.WriteLine("negatif sayı girdiniz ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("sayıların çarpımı = " + (sayi1 * sayi2));
            //    }
            //}

            // console.writeline ile kullanıcıdan bir sayı istiyorum
            //kullanıcının gireceği değer sayısal bir değer olacagı için önce bunu int değer olarak almam gerekiyor. console.readlıne 
            //ile kişinin girdii değeri alabiliriz. farkı şudur console readlıne strıng değer döndürüyor o yuzden bunu convert etmemiz gerekiyor.
            //daha sonra mantıksaal operatorlerle <= işaretini kullanıp pozzıtıf değer girmesini kontrol edeceğim için girilen sayı 0 veya 0dan 
            //küçük ise uyarı verdiriyorum. else yani değil ise metodunda ise ikinci sayıyı istiyorum. ikinci sayıyı almam gerekiyor bunun icin 
            //int sayı2 diyorum ve convert etmem gerekiyor. yine sayı ıkı negatıf bır deger mi degil mi diye if ile kontrol ediyorum. negatıfse
            //uyarı verdim. deger else'deyse yanı pozıtıfse consele writeline ile bunların carpımını yaptırıyorum. console wrıteline parantezinin 
            // içinde sayı1 ve sayı2 için bır parantez daha acıyorum kı bunların birleştirme işlemini yapmasın, çarpımını yapsın.
            //ifi şu şekilde de yazabilirdik: (sayi1 > 0) sayı1 buyukse 0dan dıye kodu çalıştırabilirdim. burda da kucukse 0 dan negatıf değer 
            // girdiniz diye uyarı verdirebiliriz.




            //Console.WriteLine("sayı giriniz.");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 % 2 == 0)
            //{
            //    Console.WriteLine(" " + sayi1);
            //}
            //else Console.WriteLine(" ");

            //Console.WriteLine("sayı giriniz.");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //if (sayi2 % 2 == 0)
            //{
            //    Console.WriteLine("," + sayi2);
            //}
            //else Console.WriteLine(" ");

            //Console.WriteLine("sayı giriniz. ");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //if (sayi3 % 2 == 0)
            //{
            //    Console.WriteLine("," + sayi3);
            //}
            //else Console.WriteLine(" ");

            //Console.WriteLine("sayı giriniz.");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());
            //if (sayi4 % 2 == 0)
            //{
            //    Console.WriteLine("," + sayi4);
            //}
            //else
            //    Console.WriteLine(" ");






            //ÖRNEK2
            //öncelikle kullanıcıdan tek tek sayıları girmesini istiyorum. sonra sayıların tek mi çift mi olması gerektiğini kontrol etmem 
            //gerekiyor.bunun birkaç yöntemi vardır. birinci yöntem burda string tipinde sonuç diye bir değişken oluşturabilirim. içini boş 
            //bıraktım, herhangibir değer ataması yapmadım. dolayısıyla benim artık çift sayıları bulup bunun içine atmam yeterli. en sonunda da
            //consola bunu yazdırırım. kontrol etmek için if i kullanıyorum. fakat elsesini burda kullanmıyorum çünkü else kullanma durumunda 
            //üsttekine girme durumunda elseye girmez. else girersede alttakilere girmez. tüm sayıları kontrol etmek istediğim için her birini 
            //else ile kontrol etmem gerekiyor. herhangibir else burda kullanılmaz.
            //whıtelıne alt alta yazma işlemi yapar, whıte ise yan yana yazar. ikinci bir yapma yöntemi ise hıç sonuc değişkeni atamadan bunları
            //wrıte ile yan yana yazdırabiliriz. en sonda console wrıteline kodu kullanmıyorum çunku sonuç degişkeni ataması yapmadım.


            //Console.Write("4 adet sayı giriniz.");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //int sayi4 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 % 2 == 0)
            //{
            //    Console.Write($" {sayi1}" );
            //}
            //else 
            //    Console.WriteLine($" ");
            //if (sayi2 % 2 == 0)
            //{
            //    Console.Write($"{sayi2}" );
            //}
            //else
            //    Console.Write(" ");
            //if (sayi3 % 2 == 0)
            //{
            //    Console.Write($"{sayi3}" );
            //}
            //else
            //    Console.Write(" ");
            //if (sayi4 % 2 == 0)
            //{
            //    Console.Write($"{sayi4}" );
            //}
            //else
            //    Console.Write(" ");






            Console.WriteLine("lütfen baslangıc değeri giriniz");
            int baslangıc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen bitis değeri giriniz");
            int bıtıs = Convert.ToInt32(Console.ReadLine());



            for (int i = baslangıc; i <= bıtıs; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            Console.ReadKey();









        }
















    }
}