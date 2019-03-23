using LP.Domain.Contratos;

/*
 *  Classe com a implementação do usuario do sistema
 * 
 */

namespace LP.Domain.Implementacao
{
    public class Usuario : IResource        
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }
    }
}
