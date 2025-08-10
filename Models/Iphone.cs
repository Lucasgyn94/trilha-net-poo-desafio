namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Iphone Instalando aplicativo {nomeApp}");
        }
        
        public override string ToString()
        {
            string texto = $"Número: {this.Numero}" + "\n" +
                           $"Modelo: {this.Modelo}" + "\n" +
                           $"IMEI: {this.IMEI}" + "\n" +
                           $"Memória: {this.Memoria}";
            return texto;
        }
    }
}