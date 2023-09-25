namespace AspNetCoreIdentity.Mvc.Habilitar.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string Curso { get; set; } = string.Empty;
    }
}
