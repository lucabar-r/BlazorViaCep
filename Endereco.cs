namespace BlazorViaCep.Models
{
    public class Endereco
    {
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Localidade { get; set; }
        public string? Uf { get; set; }
        public bool Erro { get; set; } // A API devolve esta propriedade como 'true' se o CEP não existir
    }
}