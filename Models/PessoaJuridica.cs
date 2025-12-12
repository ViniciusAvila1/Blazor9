namespace Projeto1.Models
{
    public class PessoaJuridica : Pessoa // herança da classe Pessoa
    {
        public string? CNPJ { get; set; }
        public string? InscricaoEstadual { get; set; }
        public string? RazaoSocial { get; set; }
        public string? NomeFantasia { get; set; }
        public string? TelefoneComercial { get; set; }

        public PessoaJuridica()
        {
            NomeFantasia = Nome; // atribuindo o valor da propriedade Nome da classe base Pessoa   
        }
    }
}