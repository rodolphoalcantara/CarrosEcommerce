using Eccomerce.Domain.Enums;

namespace Eccomerce.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Telefone { get; set; }
        public UserTipoEnum Tipo { get; set; }
        public String Senha { get; set; }

    }
}
