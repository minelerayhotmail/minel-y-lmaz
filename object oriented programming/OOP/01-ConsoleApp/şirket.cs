using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConsoleApp
{
    internal class şirket
    {

        //şirket isimli classımı oluşturdum. erişim belirleyici otomotik olarak internal oldu. bunu secmemiş olsak da otomatik olarak internal oluyor.
        //şuanda aynı projenın içinde kullanacagım için public olarak degıstırmeme gerek yok.
        //classlibraryde olustursaydım publıc yapmak durumundaydım. direkt prop yazarak properyleri olusturmustuk burda da sting adi dedık şirketin adı olsun bu. ardından bir tane daha ekliyorum
        //buna adres dıyorum. bu propertylerin kısaca tanımlanmıs hali ama aslında bu get ve set metotlarının açılmış halleri var.
        //bunun için de direkt propfull deyıp taba bastıgımızda oluşturabiliyoruz. bu tam ve uzun hali.

        public string adi { get; set; }
        public string adres { get; set; }

        private int _PostaKodu;

        public int _postaKodu
        {
            get { return _PostaKodu; }
            set { _PostaKodu = value; }
        }


        //buna deyelim ki posta kodu olsun.
        //classların içinde bizim ilk üyelerimizden biri değişkenlerdi. biz c# tarafında property tanımladığımızda
        //arka tarafta illaki bi private olarak bizim dışardan erişemediğimiz bir değişken tutuluyor. bu değişken mutlaka tutuluyor.
        //profull oluşturduğumuzda ilk cıkan yanı yukardakı private int postakodu denen yer.
        //biz sadece kısa property yazsak bile get set acılımı olmayan o arkada bu kodu yazıyor mutlaka açılımlı sekılde. derleyici bunu derlediğinde bilgisayarın bunu anlayabilmesi için mutlaka bunu parçalı olarak ayrı ayrı yazması gerekiyor. o yüzden arka tarafta mutlaka değişken var.
        //biz yazarken sadece kısa halini yazabiliriz. illa uzun halini yazmamıza gerek yok. ikisinin arasında harici bir fark da yok, ikisi de aynı mantıkla kullanılabilir.
        //dolayısıyla biz burdaki uzun propertyle classın içindeki bir faylın içine  değer atamak ve değeri okumak için bu propertyi kullanabiliyoruz deyebiliriz.
        //bunun için bir geliştirme yapılmış çünkü sen illaki doğrudan değişkenin içini değiştirme sana ben get ve set metotlarıyla bunun içine değer atamasını ve değer alabilmeni sağlayacağım demiş.
        //normalde burdaki get ve set metotlarınde derleyici derlediğinde bilgisayarın bunu anlaması için buraya ekstradan metotlar var, burdaki get ve set için. örneğinburdaki propertymiz ve buna bağlı olan değişkenimiz int tipinde olduğu için int tipinde geri değer döndüren bir get metodu var, GetPostakodu()
        //bunun içinde de dolayısıyla napıyor return bizim yukardaki değişkenimizin değerini geriye döndürüyor. bizim ana verileri işlediğimiz çektiğimiz aslında üye bu: "private int _PostaKodu;". postakodu diye bir üye yok noırmal sartlarda arka tarfta tutulan fayl üzerinden işlemler yürüyor.
        //yine aynı şekilde set içinde bir tane public, bunlar publıc ki ben bunlara dışardan müdahale edebileyim., bu değeri değiştirebileyim diye bunların public olması önemli.
        //bu da set metodu olacak dolayısıyla set metodunda geriye değer döndürmesine gerek yok, amacımız burdakı faylın içine deger atamak, o yüzden bu metodun geriye deger döndürmemesi lazım, public void setpostakodu() diyorum ve bunun içine artık bir tane int tipinde value alması lazım ki aldığımız veriyi yukardaki değişkenin içine yazabilelim. o yuzden mutlaka bir value parametresi var.
        //ve gelen parametreyi bizim yukardaki değişkenimizin içine eşitliyoruz postakodu = value, burdaki set metodu da aslına bu işi yapıyor.
        //yani aslına biz örneğin yukarda bir adres tanımladığımızda o aslında arka tarafta böyle biraz daha uzun şekilde bu yazdıklarımızın hepsini de arka tarfta tutuyor.
        //biz "public string adres { get; set; }" bunu yazdıgımızda bilgisayar derlediği anda bilgisayarın çalıştırabilmesi için kendisi uzun halini çıkartıyor get set metotlarını ekliyor
        //ve o zaman bilgisayar bu kodu çalıştırabiliyor hale geliyor. bunlar neden var, neden böyle yapılmış netice biz yukardaki değişkeni public yapsak dışardan bunun içine bir değer ataması yapabilirdik yine onun içinden de değer okuyabilirdik publıc yaparsak. neden bu yapılmış
        //burdaki get set metotlarıyla araya girebilmek için. aslında en son yaptıgımız get set metotlarının açılımı aslında yok bunu görmek için yazdık yani aslında bu metotların açılımı bu diye görebilmek için, örnek olarak elimizde kalabilir.
        //şimdi örneğin deyelimki kare sınıfımız olsun bir tane hemen tanımlıyorum sınıfımız class başına ınternal yazmamıza gerek yok varsayılan olarak geliyordu. ismi kare olsun ve buraya bır tane olusturuyorum. şimdi bunun neden get ve set metotları var onu açıklamak için yapıyoruz.
        //bizim bir kare sınıfımız var ve bunun içinde de propertysi olsun full olarak bunu yazıyoruz. deyelim ki buna kenaruzunlugu aynı şekilde propertynin ismini de değiştiriyorum karıştırmamak adına. çünkü ben bunu program.cs nin içinde kullandığımda bu tarafa bir tane kare tanımlıyorum newlemiz gerekiyordu.
        //ardından kare.kenaruzunlugu başında o _ olmayan şeklıyle ben bu tarafta public olan kısmı görebiliyorum prıvate olan kısmı göremiyorum. ben publıc olan property üzerinden prıvate olan değişkene deger ataması ve cıkarması yapabiliyorum. şimdi deyelim ki kareye bir deger ataması atamak istediğimizde örneğin 100 den büyükse biz atama yaptırmak istemiyoruz ya da 100den büyükse 100 olarak varsaymak istiyoruz daha büyüğünü girmesini istemiyoruz kullanıcının
        //normalde bunu yazılımcıya hiçbir şekilde anlatamayız ancak bir yerlere not almamız lazım yazan kişiye de bunları belirtmemiz lazım işte bunu yapmamak adına bize get ve set metotları verilmiş. bizim amacımız set atarken yani 100 degerını içine yazarken kontrol yapmak oldugu için set metodunu acarak kullanabılıyoruz yanı actıgımızda aslında bır metot oldugunu görebiliyoruz. aynı sekılde get için de gecerlı normal bızım metotlarımız gıbı sadece basında voıd yok ve parantez acıp kapama yok o kadar onun harıcınde get gerıye deger donduren set ise geriye deger dondurmeyen metot
        //artık ben set metodunun içinde sunu deyebılırım artık set metodunun içinde kod yazıyorum normalde bunu yapamazdım. deyelimki ben kenaruzunluguna bır limit koymak istiyorsam bunu yazılımcının gözune bır yerde sokmam lazım, yazmam lazım. cunku yanlışlıkla 100den buyuk deger  gırmesın cunku deger ataması yaparken bu ifi yazmak zorunda kalıyor. o yuzden onun unutabilecegını düşünerek bız kontrolumuzu burda kendimiz yapıyoruz if yanı bana gelen deger atama yapmak ıstedıgım deger value burda value olarak buna erişebiliyorum. buraya varsayılan olarak value parametresi geliyor bu baska bır yerde yazmaz bunu bilmemiz gerekiyor.
        //if value büyüktür 100se value 100den buyukse sen gıt valueyı 100den buyuk yapma eşit eşit 100 yap. şimdi ben böyle yaptıgımda ne oldu program.cs ye geldım ben kenaruzunlugunu 120 gırmek ıstıyorum. yanı 120 degeri gönderdim hiç farkında degılım. artık uyarmama gerek yok cunku 120de gırse artık arka tarafta kontrolunu yapıcam ve bunu 100 olarak ben cevırecegım. o yuzden 100den buyuk bır deger gırmesine imkan yok. ekrana yazdırıyorum CW ile kenaruzunlugu + kare.kenaruzunlugu şimdi ben burda 120 degerı göndermiş olmama ragmen calıştırdıgımda ekranda bana cıktı olarak 100ü verdi. 
        //dolayısıyla ben burdaki değişkenin içine bir deger ataması yaparken bunun içine erişmiş oldum. içindeki değere değer ataması yaparken erişerek araya girdim ve orda belli kurallar yazabildim. burdaki basit bir kontrolümüz, ihtiyaca göre uzun bir kontrol de yapılabilir. önemli olan biz burda bir tane fayt kullansaydık boyle bır kontrol yapma sansımız yoktu yazılımcıya özellikle dememiz gerekirdi sen buna deger atarken atadıgın her yere gıt bu kontrolu yap ona gore 120 gırerse sen 100 gönder dememiz lazımdı. o da 10 tane yerde kullanıyorsa 10 tane yerde bu degısıklıgı yapmak zorundaydı. dolayısıyla bız burda tek set metodunun içinde degısıklıgı yaptık ve bu faylda 100ün üzerinde bir deger gırmesine izin vermedik.
        //100ün altında oldugu zaman herhangıbır ifin içine girmeyecek dolayısıyla value neyse örn. 90 gönderdiysek 90ı aynı şekilde propertynin içine atama yapıyor olacak. burda amaç faytlara deger ataması yaparken araya girip ilgili kontroller ilgili kodlar yazabilmek adına böyle bir property geliştirilmesi yapılmış. propertyler karsımıza sık sık cıkacak uzun uzun yazmamıza gerek yok hıcbır yerde egerkı böyle set metoduyla arasına gırmemize gerek yoksa  uzun uzun yazmamıza gerek yok hemen kısa halıyle kullanabılırız.
        //yine burdaki propertylerden varsayılan bır defalt deger atamak istiyorum, o da kullanılabilir. örn. şirketin adına herhangırsey yazılmadıgı muddetce ben bunun codove olarak kalmasını ıstıyorum adının.burda "public string adi { get; set; }" bu kısma eşittir deyerek yani sankı bır degısken tanımlamısız ve ben onun içine deger ataması yapıyormusum gıbı süslü parantezlerin sonunda eşittir ilgili degerı verebılırız intse int tıpınde datetıme ıse datetıme tıpınde bır deger verebılırız.
        //şimdi biz program.cs kısmında şirkket üretmedik burda bir şirket sınıfından nesne üretiyorum örn. şirketin postakodu vardı postakoduna 34560; oolarak tanımlıyorum. herhangıbır şirket adı gırmedim
        //şimdi ekrana yazdırmaymı deneyelim console.wrıteline("şirket adi = " + sırket.adi); şirket adı dedeım ve artından da sırket nesnemızın ıcındekı adi propertysinin içindeki degerı yazdıralım. ekrana yazdırdıgımda burda bır şirket adı tanımlaması yapmamama ragmen bana şirketın adı olarak codove gelıyor oldu. egerkı ben sırket adını burdan tanımlıyor yanı gırıyor olsaydım program.cs kısmındayım dsırket adı = "acunmedya akademı" dedım şimdi calıstırdıgımda artık o benım default olarak verdıgım degerı ezip en son atama yaptıgım degeri ilgili propertynın içine yazıyor olacak. o yuzden varsayılan olarak deger atamak ıstedıgımızde bu şekilde atamalar yapabılırız. yine null gecılebılır bır property olusturmak ıstıyorsanız aynı mantıkla normal degıskenlerde soru işareti ile null yapabılıyorduk aynı mantıkla propertylerde de bunu yapabılıyoruz.
        //propertyler bu şekilde. bunlara aslında ENKAPSULATİON deniyor. BU MÜLAKAT SORUSU OLARAK GELEBİLİR. ENKAPSULATİON NEDİR DİYE.





       
    }
}
