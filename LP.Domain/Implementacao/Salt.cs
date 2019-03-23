using LP.Domain.Contratos;

/*
 *  Classe que implementa os registros com o Salt e a parte final da Key do usuário
 *  
 *  A ideia é que esta tabela esteja em um banco de dados isolado para que, caso haja algum
 *  tipo de vazamento da tabela com as keys parte da chave e os salts fiquem protegidos
 *  
 *  Para simplificar a implementação manterei essa entidade no mesmo contexto
 *  
 */

namespace LP.Domain.Implementacao
{
    public class Salt : IResource
    {
        public long Id { get; set; }

        public long KeyId { get; set; }

        public string Salt1 { get; set; }

        public string Salt2 { get; set; }

        public string FinalKeyString { get; set; }
    }
}
