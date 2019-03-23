using LP.Domain.Contratos;

/*
 *  Classe com a implementação de parte das senhas  dos usuários do sistema
 */

namespace LP.Domain.Implementacao
{
    public class Key : IResource
    {
        public long Id { get; set; }

        public long UsuarioId { get; set; }

        public string KeyString { get; set; }

        public virtual Usuario Usuario { get; set; }


    }
}
