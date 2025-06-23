namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades
        public string Numero { get; set; }
        
        private string Modelo { get; set; }

        private string IMEI { get; set; }

        private string Memoria { get; set; }


        // Construtor
        // Construtor é um método especial que é chamado quando uma instância da classe é criada.
        // Ele é usado para inicializar as propriedades da classe.


        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos
        // Métodos são funções que definem o comportamento da classe.
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}