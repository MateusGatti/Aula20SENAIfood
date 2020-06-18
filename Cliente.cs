namespace Aula20SENAIfood
{
    public class Cliente
    {

        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }


        public Cliente(string nome, string enderecoatual){

            this.Nome = nome;
            this.EnderecoAtual = enderecoatual;

        }

        public string MostrarDados(){

            return $"Seu nome é: {Nome}, e seu endereço atual é: {EnderecoAtual}";

        }

    }
}