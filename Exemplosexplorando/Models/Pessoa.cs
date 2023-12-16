namespace Exemplosexplorando.Models
{
    public class Pessoa
    {
        private string_Nome;
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}