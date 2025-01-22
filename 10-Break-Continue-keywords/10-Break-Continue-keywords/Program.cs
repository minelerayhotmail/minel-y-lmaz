namespace _10_Break_Continue_keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Break: Döngünün içinden çıkmak istenildiğinde kullanılır.


            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);




            //}
            //break istediğimiz şart sağlandıktan sonra döngünün bitmesini istediğimiz zaman kullanılır.burda i değeri 0
            //i 5 küçük ise bir arttırarak dön diyorum. burda 0 dan 4e gelinceye kadar ekrana yazdırır. daha sonra if şartı ile
            //i 3e eşit olduğunda bırak demek için break komutunu kullanıyorum. if i == 3 ve ardından break ekliyorum
            //ekrana 012 yazdırıyor 3'e geldiğinde break komutuyla uygulamadan çıkıyor.


            //WHİLE İLE BİR ÖRNEK DENEDİĞİMİZDE

            //int i = 0;
            //while (i < 20)
            //{
            //    if (i == 10)
            //        break;
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while de ise i değerim küçük ise 20 den 1 arttırarak dön diyorum. yine if şartı ile i eşit olduğunda 10a break diyorum
            //ve i 10a eşit oldugunda döngüden çıkıyor. ekrana 0dan 9a yazdırıyor.



            //CONTİNUE:döngüde bir sonraki adıma geçmek için kullanılır.

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                
                    Console.WriteLine(i);
                
            }
            //burda 10 0 dan büyük oldugunda dön diyen bir döngüm var. if ile i eşit olduğunda 5e continue diye bir şart ekliyorum. 
            //burda artık şöyle çalışacak ne zamanki i 5e eşit oldu continue içine girecek aşağıdaki kodları çalıştırmadan döngünün 
            //tekrar başına geliyor olacak. yani ekrana yazdırdığımızda 5 hariç hepsini yazdırır. çünkü geldi baktı 5e kadar olan
            //şartlar sağlanıyor onları yazdırdı 5 olan şart çalışmıyor onu geçti sonra tekrar başa gelip arttırma işlemi ile koda devam etti
            //continue burda tamamen kodu durdurmuyor sadece kendinden sonraki kodları çalıştırmıyor. kendinden sonraki kodları çalıştırmadan
            //başa dönüyor ve ordaki kodları çalıştırıyor. bizim şart olarak girdiğimiz değeri es geçiyor yani.
            //break komutu döndüyü direkt kırıyordu. döngüden tamamen çıkıyordu ama continue sadece o ilgili döngünün o anki aşamasını
            //artık continue kodundan sonrasını çalıştırmıyor sadece bir sonraki adımına geçirtiyor.



        }
    }
}