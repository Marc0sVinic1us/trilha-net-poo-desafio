namespace DesafioPOO.Models
{
    // Classe abstrata -> modelo de SmartPhone
    public abstract class Smartphone
    {
        // Propriedades públicas e protegidas -> encapsulamento
        public string Numero { get; set; }
        protected string Modelo;
        protected string Imei;
        protected int Memoria;

        // Construtor da classe
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        // Métodos globais de ambos SmartPhones
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato para ser sobre-escrito pelas classes filhas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}