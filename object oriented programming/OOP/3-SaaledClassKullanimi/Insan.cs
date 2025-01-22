using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SaaledClassKullanimi
{
    public class Insan
    {
        public string Adi {  get; set; }

        public string SoyAdi { get; set; }

        public DateTime DogumTarihi { get; set; }


    }


    public class Personel : Insan
    {
        public double Maas { get; set; }

        public string Meslek { get; set; }
    }

    public class Ogrenci : Insan
    {
        public double NotOrtalamasi { get; set; }

        public void DersCalis()
        { 

        }


        public void OdevYap()
        {

        }


        public void TekrarEt()
        {

        }

        

    }


    public class Ogretmen : Personel
    {
       
    }


    public class Yonetici : Personel 
    {
        public void MaasOde()
        {

        }

    }

}
