using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConsoleApp
{

    //INHARİTANCE(KALITIM)= miras alma işlemi
    //Bir class sadece bir classı miras alabilir. ikinci bir classı miras alamaz.
    //cihaz isminde bir class oluşturdum. burdaki amacımız şu örn. ben elektronik telefon bilgisayar gibi bazı kategoriler bazı ürünler oluşturmak istiyorum yani veritabanında böyle bilgiler tutacağım. dolayısıyla hem bir telefonun hem bir elektronik cihazın ortak özellikleri vardır. örn. telefonla bilgisayarı kıyasladığımızda ikisininde işlemcisi vardır ikisinin de ramı vardır gibi belli özellikleri vardır. o yüzden böyle ortak özellikleri bir classta birleştirerek ardından da o classı diğerlerine miras ederek classın özelliklerini genişletmemizi sağlayan bir yapı
    //cihaz isminde bir class oluşturdum. amacım bir elektronik birde telefon diye iki tane daha class yapmak yani en neticede benim amacım bir telefon bilgisini oluşturmak ya da aynı zamanda bir bilgisayar classını oluşturmak. ama bu ikisinin ortak özellikleri vardı. birebir bütün özellikleri de aynı olmayabilir. şimdi ben ikisinde de ortak olan bilgileri burdaki ilk cihaz isimli classın içine yazıyor olacağım. örneğin bir tane property ekleyelim. hepsinde bir tane barkod bilgisi olması gerekir. ürünlerin hepsinin barkodu vardır. o yüzden barkod olarak buraya ekleyebiliriz.
    // yine bunun içine metot ekleyebiliriz.netice bu bir class ve miras olarak başkasına verdiğimizde içindeki bütün öğeleri de karşı tarafa miras etmiş oluruz. o yüzden örnek olarak bir tane de metot ekleyelim. public geriye string döndürsün örn. burdaki barkodu barkodyaz isimli bir metot ile herhangibir parametre almasın return diyorum geriye string olarak ilgili barkodu dönsün. return "barkod=" yanına da artı bizim içinde bulunduğumuz mevcut classın barkod propertysiini geriye dönsün. yine burda this i kullanabilirdik ama kullanmadık cunku bır tane var ama kullanıladabilir.
    //classımızın tipi internal ya da public olabilir cunku dıger taraftan erişebilmemiz için olması gerekiyor. şimdi buraya bir tane daha class oluşturuyorum ve diyorumki public elektronik. elektronik classını oluşturdum yanına bir tane de telefon classı olusturdum. dolayısıyla bu ikisinde de barkod propertysi var. ve barkodyaz metoduna da ikisinde de ihtiyacım var. dolayısıyla benim bu barkodu hepsine tek tek tanımlamak yerine bu ınheritance dediğimiz kavramla classın ismini yazdıktan sonra iki nokta üst üste ekleyip hangi classı miras almak istiyorsak, burda bizim ana classımız
    //üst taraftaki cihaz classı. elektronik ve telefon public oldugu için cihaza da public vermemiz gerekiyor. şimdi elektronik classına cihaz tanımladım ve demiş oldum ki sen burdaki elektronik classına ne zaman erişmeye çalışsan cihazın içindeki bütün özelliklere bütün propertylere metotlara artık ne varsa öğelerin hepside bunun içine geçmiş oldu. hemen program.cs ye gelip bir bakalım burda cihazı newlememize gerek yok çünkü ben burda cihazı kullanmayacagım onu elektronıgın içine verdim. o yüzden elektronikten bir tane oluşturalım. elektronık eşittir new elektronik dedim bir tane ınstınsını olusturdum.
    //miras alma işlemi yaparak elimizdeki classları birbirine bağlamış oluyoruz.
    //ortak noktaları birbirinden miras aldık. fakat clasların kendine özgü özellikleriolabilir onları da içine ayrı ayrı tanımlayabiliriz. örn. telefonun aramayap gibi.

    public class cihaz
    {
        public string BarKod { get; set; }

        public string BarKodYaz()
        {
            return "barkod =" + BarKod;
        }

        //bu metoda sadece miras alan class üzerinden erişebilir.
        //classın içindeki protected bir metoda nereden erişebilirsiniz?
        protected void Yaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        public cihaz(string barkod, string seriNo)
        {
            this.BarKod = barkod;
        }

    }



    public class Elektronik : cihaz
    {
        public Elektronik(string barkod, string seriNo) : base(barkod, seriNo)
        {
        }

        public string CPU { get; set; }

        public string RAM { get; set; }
    }


    public class Telefon : Elektronik
    {
        public Telefon(string barkod,  string seriNo) : base(barkod, seriNo)
        {
        }

        public string Renk { get; set; }

        public void AramaYap()
        {
            Console.WriteLine(base.BarKodYaz());
            Console.WriteLine("Arama Yapıldı");
        }
    }


    public class Bilgisayar : Elektronik
    {
        public Bilgisayar(string barkod, string seriNo) : base (barkod, seriNo)
        {

        }

    }

    public class Monitör : cihaz
    {
        public Monitör(string barkod, string seriNo) : base(barkod, seriNo)
        {

        }

    }

    

    //this keywordunu classtakı elemanlara erişebilmek için kullandık.
    //cihazda ilk oluşturdugumuz classın içinde bir tane conturaksır olusturabılırız. içine de parametreler alıyoruz örn. string barkod ve bunu da bızım yukardakı barkod propertysine yazdıralım thıs.barkod=barkod dıyorum. böyle yaptıgımızda artık ben cihazı olustururken cihaz classında herhangıbır yerde ınstınsını olustururken yannı newlemem işlemi yaparken artık barkodu gırmek zorunda kalıyordum. barkod gırmeden bu cıhaz sınıfını newleyemiyorum. asagıdada dırekt bunun hatası cıktı asagıdakılere de bu barkodu gırmem gerekıyor.
    //dolayısıyla biz ana classta bır sey degıstırdıgımızde diğerlerini de değiştirmek zorundayız.
    //deyelimki biz bunları böyle yapmamış olsaydık diğerlerinden miras almayıpta her birine aynı propertylerı eklemıs olsaydık yarın bu barkod zorunlu bır alan oldugunda  tum classların ıcınde manuel bunnu eklemek zorundaydık.
    //base keywordu ilgili classın içine gelip base. dedıgımde o classta miras alınan classın içindeki öğeleri bana gösteriyor, getiriyor.
    //artık tüm classlar bırbırıne baglı sekılde ve hızlıca bırbırlerıne bagımlı olarak hızlı bır sekılde olusmus oldu. program.cs kısmana geldıgımde de bır barkod ve bır serıno benden ıstıyor. bunları gırmeden olusturamıyorum. dolayısıyla ekıp calısmasında telefona bakan yazılımcı da elektronıge bakan da ilgili degişikliklerı yapması gerekecek. dolayısıyla bır kod butunlugu saglamıs olduk.
