namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        
        public override void InstalarAplicativo(string androidApp)
        {
            Console.WriteLine("Instalando" + androidApp + " em dispositivo Nokia");
        }
    }
}