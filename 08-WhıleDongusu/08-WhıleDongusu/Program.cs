namespace _08_WhıleDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Whıle Döngüsü: for dongusunde donerken bız bir değişken olusturuyorduk ve baslangıc bitişini ayarlayarak
            //ve nasıl arttıracağını da söylerek otomatik kendisi arttırıyordu. ordaki ilgili şartımız sağlanana kadar sürekli
            //dönüyordu.
            //whıle döngüsünde ise burdaki şart sağlandığı müddetçe sen dön anlamında ve herhangibir arttırma işlemini kendisi
            //burda yapmıyor.
            //yani bizim elimizde bir int i değişkeni olsun ve bız burda i<10 olğu müddetçe dön demiş olduk ama burda i yi
            //otomatik olarak kendisi arttırmıyor. forda olduğu gibi tek tek arttırmıyor.
            //biz burda çalıştırmak istediğimiz kod bloklarını buraya yazıyoruz yanı console wrıtwlinw'nın içine .
            //ne zamanki ilgili kodlarımız bitti artık burdaki arttırma işlemini kendimiz yazıyoruz. ister 1er 1er ister 2şer 2şer
            //. arttırma işlemini ekrana yazdırmadan önce veya ekrana yazdırdıktan sonrası için ekleyebilirim.
            //o şekilde döner kod.
            //artık arttırma işlemini manuel bir şekilde kendimiz yapıyoruz.
            //whıle de sonsuz döngü oluşturmak daha kolaydır.


            //şart sağlandığı müddetçe döngü çalışır
            //ne zamankı şart sağlanmıyor o zaman döngünün içinden çıkar
            //int i = 0;
            //while (i <10)
            //{
                //çalıştırmak istediğimiz kod bloklarını buraya yazıyoruz

                //arttırma veya azaltma işlemi manuel olarak yapılır
                //i++;
            //}


            
            ////!!!SONSUZ DÖNGÜ 1
            //true oldugu müddetçe dön. zaten bu bir true yani sürekli dönecek anlamına gelir. hiçbir sonu yok.
            //while (true)
            //{

            //}


            //!!!SONSUZ DÖNGÜ 2
            //burda i eşit eşit mi 0 a diye bir sorgulama yaptım ve cıktıda sonsuza kadar 0 yazdırır.

            //while (i == 0)
            //{
            //    Console.WriteLine(i);
            //}



            //!!!SONSUZ DÖNGÜ 3
            //yine forda kullandığımız gibi şart işaretini yanlış kullanmıştık. deyelimki i e başlangıçta 5 değeri verdik ve
            //biz burda 
            //i büyük mü 4 ten diye bakıyoruz. dolayısıyla i 4 ten büyük olduğu için yine bu da sürekli çalışacak duruma gelir.
            //bu da sonsuz döngü olur.
            //int i = 5;
            //while (i > 4)
            //{
            //    Console.WriteLine(i);
            //}


            //değişkenimin değeri 0 whıleye baktı sart sağlanıyor mu evet sağlanıyor 10dan kucuk 0 suanda ve içine girdi 1 yaptı
            //cunku 1 arttırıyorum.
            //sonra ekrana 1 yazdı cunku ekrana yazdırmadan once 1 arttırma yaptım. sonra tekrar yukarı geldı 1 sayı hala
            //10dan kucuk devam etti 1 arttırdı 2 oldu. sonra en son 9 oldu sart sağlanıyor 1 arttırdı ve 10 yazdırdı ekrana
            //sonra tekrar yukarı dondu 10 oldugu ıcın sart sağlanmıyor artık cunku 10 dan kucukse dedim esitse koymadım ve
            //11 yapmadan durdu.
            //bu kullanımda 1 ve 10 dahıl sayıların hepsını ekrana yazar.
            //int sayi =  0;
            //while (sayi < 10)
            //{
            //    sayi++;
            //    Console.WriteLine(sayi);
            //}



            //burda ise tek bır sey değiştiriyorum sayının arttıgı yeri değiştırıyorum. öncekinde yazdırmadan once arttırıyordum
            //sımdı yazdırdıktan sonra arttırıyorum.
            //elimizde bir sayı değişkenı var içine girdim 10dan kucuk 0 ekrana 0 ı yazdırdım sonra 1 arttırdım sayım bır oldu.
            //dolayısıyla usttekınde 1 den baslıyordu burda 0 dan baslıyor.
            //en sona geldıgınde ise 9 a geldi 9 10 dan kucuk ekrana yazdı sonra 1 arttırdı 10 oldu artık sartım sağlanmıyor
            //o yuzden 10u ekrana yazdırmadfı cunku 10dan kucukse yazdır dedim, eşitse yazdır demedim.
            //bu kullanımda 0 ve 9 olmak uzere sayıları ekrana yazdırır.
            //int sayi = 0;
            //while (sayi < 10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}



            //9 dan 0a kadar sayıları yan yana yazdıran kod bloğunu yazınız
            //9876543210
            //yan yana yazdırmak istediğim için console.wrıtelıne değil wrıte yapıyorum.

            //int sayi = 9;
            //while (sayi >= 0)
            //{
            //    Console.Write(sayi);
            //    sayi--;
            //}

        }
    }
}