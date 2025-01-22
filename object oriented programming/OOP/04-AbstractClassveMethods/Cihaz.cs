using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AbstractClassveMethods
{
    //abstract classlar soyut class anlamına gelir. newlenemez sadece miras alınabilir.
    //abstract clasını bazı clasların içine miras alabiliyorum. onun haricinde hiçbir şey yapamıyorum.
    //birde abstract methodlar var. bunlar da abstract classın içinde oluşturulabiliyor sadece. ve başında
    //mutlaka erişim belirleyicisi olması gerekiyor. classın kendisinde erişim belirleyici girmesek de olabiliyor
    //ama abstact methodda girmek zorunlu çünkü burda kullandıgım abstact methodun bir kod blogu yok. burda olusturdugum
    //abstract methodu mutlaka miras alınan clastada olusturup kod blogunu yazabiliyor olmam lazım. yoksa uygulama hata verir.  
    //dolayısıyla bunu baska bır yerde de kullanma zorunlulugum oldugu ıcın publıc olarak gırmrm lazım.
    //publıc olmazsa erişemem.
    //eger abstract methodda kod tanımlayacaksak bunu miras alınan kodda tanımlayabiliriz. abstract classın içinde tanımlayamayız.
    abstract class Cihaz
    {
        public string Barkod { get; set; }


        public string BarkodGetir()
        {
            return "Barkod=" + this.Barkod;
        }

        //mutlaka public erişim belirleyicisi olmak zorundadır.
        //mutlaka içinde bulunduğu sınıf abstract olması gerekiyor.
        //hiçbir şekilde kod bloğu bulunmaz.
        //miras alınan sınıfta override edilerek kod bloğunun oluşturulması zorunludur.
        public abstract void BarkodYaz();

        public abstract string Birlestir(string deger1,  string deger2);
    }

    class Elektronik : Cihaz
    {
        public string CPU { get; set; }
        public string RAM { get; set; }

        public override void BarkodYaz()
        {
            Console.WriteLine(BarkodGetir());
        }

        public override string Birlestir(string deger1, string deger2)
        {
            return deger1 + deger2;
        }
    }

}

