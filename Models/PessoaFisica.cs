namespace Projeto1.Models
{
    public class PessoaFisica: Pessoa // herança da classe Pessoa
    {
        public DateTime Nascimento { get; set; }
        public string? Celular { get; set; } 
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public string? CNH { get; set; }
        public string? CNH_Categoria { get; set; }

        public PessoaFisica()
        {
            Celular = Email; // atribuindo o valor da propriedade Email da classe base Pessoa   
        }
    }
}