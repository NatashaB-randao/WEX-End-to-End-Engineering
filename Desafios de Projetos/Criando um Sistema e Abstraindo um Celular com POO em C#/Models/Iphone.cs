namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {
        }
        // Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        }
    }
}