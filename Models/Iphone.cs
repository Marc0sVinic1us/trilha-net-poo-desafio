namespace DesafioPOO.Models
{
    // Herança das propriedades e métodos da classe SmartPhone
    public class Iphone : Smartphone
    {
        // Construtor da classe
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Polimorfismo do método InstalarAplicativo da classe mãe
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no iPhone");
        }
    }
}