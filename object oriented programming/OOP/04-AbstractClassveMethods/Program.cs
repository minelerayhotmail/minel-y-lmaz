namespace _04_AbstractClassveMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cihaz cihaz = new cihaz();
            Elektronik elektronik = new Elektronik();
            elektronik.Barkod = "34567899";
            elektronik.CPU = "cpu";
            elektronik.RAM = "memory";

            elektronik.BarkodYaz();
            
        }
    }
}