namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, int imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string iosApp)
        {
            Console.WriteLine("Instalando aplicativo" + iosApp + " em dispositivo Iphone");
        }
    }
}