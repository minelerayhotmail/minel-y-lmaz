using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _3_SaaledClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cihaz cihaz = new cihaz();
            cihaz.BarKod = "12312";

            Console.WriteLine("hello, world!");

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.

        }



    }


    //miras alınamaz classlardır deyebiliriz.
    public sealed class cihaz
    {
        public string BarKod { get; set; }
    }


    public class Elektronik
    {

    }

}