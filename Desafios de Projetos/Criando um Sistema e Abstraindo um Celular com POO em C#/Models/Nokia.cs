namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        private string v1;
        private string v2;
        private string v3;
        private int v4;

        // Construtor

        public Nokia(string numero, string modelo, string imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}