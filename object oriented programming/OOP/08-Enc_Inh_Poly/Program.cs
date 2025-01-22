namespace _08_Enc_Inh_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    //ENCAPSULATION (KAPSÜLLEME):
    //Bir class oluşturduğumda propertyfull dediğimde ben bunun alanlarını burda tek
    //tek yazabiliyorum. bu propertynin uzun yazılmış hali. burdaki get set methodlarına
    //müdahale edebiliyorduk. bu şekilde araya get ve set methodlarıyla girmemize
    //encapsulatıon deniyor.
    //buna encapsulatıon- kapsulleme deniyor.
    //Classların içerisindeki fieldlara değer atama ve okuma işlemi sırasında 
    //araya girebilme işlemine denir (properties).
    public class Kare
    {
        private int _KenarA;

        public int KenarA
        {
            get { return _KenarA; }
            set { _KenarA = value; }
        }

    }
    //INHERİTANCE (MİRAS ALMA):
    //Classların birbiri üzerinden miras alınarak özelliklerinin genişletilebilmesi
    //işlevlerinin geliştirilebilmesine ınherıtance denir.
    //interfaceler ya da normal classlar ile miras alarak classların öğelerinin 
    //genişletilebilmesine denir.

    //POLYMORPHİSM (ÇOK BİÇİMLİLİK):
    //
    //Bir methodun miras alınan sınıfta ezilmesi ve şeklşnin değiştirilmesi.
    //YANİ ÖRNEĞİN BİZİM ABSTRACT CLASSLARIMIZ VARDI ve içinde de abstract methodlar
    //vardı. dolayısıyla biz bu abstract methodları kodu olmayan haliyle override 
    //komutuyla ezerek içindeki kod bloğunu değiştiriyorduk. işte buna da 
    //polymorphism deniyor.
    //Bir methodun miras alınan sınıfta ezilerek (override) şeklinin ya da görevinin
    //değiştirilme işlemine denir (virtual metohod, abstract metohod).




}


