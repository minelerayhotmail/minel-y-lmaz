namespace _05_SwitchCaseKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //swıtch kısmına kontrol etmek istediğim değeri yazıyorum,case kısmına ise eğer buysa şartını yazıyorum. yani örneğin
            //switch sayi1 case 1 = eğer sayi1 1 ise demek oluyor. altına console writwline ile "pazartesi" yazdırıyorum.
            //if komutları gibi düşünebiliriz. default ise ifin else komutu gibi yani değilse bunu yazdır demek.
            //break komutu ise süslü parantezin içindeki bloğu bırak artık diğer bloğa geç demek. bir sonraki bloğa geçmesini sağlıyor.
            //ifin farklı bir kullanımı diyebiliriz. biraz daha kontrollü ve yazımı daha kısa.
            //int sayi1 = 9;

            //switch (sayi1)
            //{
            //    case 1:
            //        Console.WriteLine("pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("pazar");
            //        break;

            //     default: Console.WriteLine("hatalı giriş yaptınız");
            //        break;

            //}


            //kullanıcıdan bir ay girmesini isteyelim. girdiği ayın mevsimini dönelim.
            //kullanıcıdan bir ay giriniz diye istemem gerektiği için bunu console wrıteline ile yazdırıyorum.
            //kullanıcıdan yazı biçiminde ay girmesini istediğim istediğim için
            //string tipte bir değişken atıyorum ve "ay" olarak değişken atıyorum ve değerini console.readlıne yapıyorum kı
            //kullanıcının girdiği veriyi almak için.
            //swıtch nin yanına parantez içinde değişkenimi giriyorum. daha sonra caselerimi yazmaya başlıyorum.
            //caseleri art arda yazıp sonra console wrıteline ile eğer bunlarsa ...ayı girdiniz yazabilirim. bu ifteki eğer 
            //girilen değer 5 veya 3 ve 0sa bunu yazdır demek gibi.
            //string değerin içine süslü parantez ile bir değer atayabiliyorum. ve başına dolar simgesi koymam gerekiyor o olmazsa
            //süslü parantezle değer atayamam. burda amacım string ifadeyi özelleştirmek. string ifadenin içine değer atayabilmek 
            //bunu şu şekilde de yapabilirdim : (ay + "ayı kış mevsimindendir")

            #region UzunVersiyon
            //Console.WriteLine("bir ay giriniz");
            //string ay = Console.ReadLine();

            //switch (ay)
            //{
            //    case "ocak":
            //        Console.WriteLine("kış");
            //        break;
            //    case "şubat":
            //        Console.WriteLine("kış");
            //        break;
            //    case "mart":
            //        Console.WriteLine("ilkbahar");
            //        break;
            //    case "nisan":
            //        Console.WriteLine("ilkbahar");
            //        break;
            //    case "mayıs":
            //        Console.WriteLine("ilkbahar");
            //        break;
            //    case "haziran":
            //        Console.WriteLine("yaz");
            //        break;
            //    case "temmuz":
            //        Console.WriteLine("yaz");
            //        break;
            //    case "ağustos":
            //        Console.WriteLine("yaz");
            //        break;
            //    case "eylül":
            //        Console.WriteLine("sonbahar");
            //        break;
            //    case "ekim":
            //        Console.WriteLine("sonbahar");
            //        break;
            //    case "kasım":
            //        Console.WriteLine("sonbahar");
            //        break;
            //    case "aralık":
            //        Console.WriteLine("kış");
            //        break;

            //    default:
            //        Console.WriteLine("hatalı giriş yaptınız");
            //        break;

            //}
            #endregion

            #region KısaVersiyon

            ////Console.WriteLine("bir ay giriniz");
            ////string ay = Console.ReadLine();

            ////switch (ay)
            ////{
            ////    case "ocak":
            ////    case "şubat":
            ////    case "aralık":
            ////        Console.WriteLine($"{ay}ayı kış mevsimindendir");
            ////        break;
            ////    case "nisan":
            ////    case "mayıs":
            ////    case "mart":
            ////        Console.WriteLine($"{ay} ayı ilkbahar mevsimindendir");
            ////        break;
            ////    case "temmuz":
            ////    case "ağustos":
            ////    case "haziran":
            ////        Console.WriteLine($"{ay} ayı yaz mevsimindendir");
            ////        break;
            ////    case "ekim":
            ////    case "kasım":
            ////    case "eylül":
            ////        Console.WriteLine($"{ay}ayı kış mevsimindendir");
            ////        break;

            ////    default:
            ////        Console.WriteLine("hatalı giriş yaptınız");
            ////        break;

            //}

            #endregion


            //bu caseleri if komutlarıyla yapalım.
            //burda else if kullanmamın amacı ilk kullandığım ifteki koşul yanlışsa, başka bir koşul belirlemek amacıyla kullanılır.


            Console.WriteLine("bir ay adı giriniz..");
            string ay = Console.ReadLine();

            if (ay == "aralık" || ay == "ocak" || ay == "şubat")
                Console.WriteLine($"{ay} ayı kış mevsimindendir..");

           else if (ay == "mart" || ay == "nisan" || ay == "mayıs")
                Console.WriteLine($"{ay} ayı ilkbahar mevsimindendir..");

           else if (ay == "haziran" || ay == "temmuz" || ay == "ağustos")
                Console.WriteLine($"{ay} ayı yaz mevsimindendir");

           else if (ay == "eylül" || ay == "ekim" || ay == "kasım")
                Console.WriteLine($"{ay} ayı sonbahar mevsimindendir..");
            else
                Console.WriteLine("hatalı giriş yaptınız..");
            


            Console.ReadKey();













        }
    }
}