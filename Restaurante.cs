namespace Aula20SENAIfood
{
    public class Restaurante
    {
        
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }


        public Restaurante(string nomefantasia, string endereco){

            this.NomeFantasia = nomefantasia;
            this.Endereco = endereco;

        }


        public string MostrarDados(){

            return $"O nome do restaurante é: {NomeFantasia}, e o endereço dele é: {Endereco}";

        }

    }
}