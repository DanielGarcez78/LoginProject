/*
 * Interface que define as classes de dominio
 * 
 * A ideia é possuir uma interface com a qual todas as classes de dominio
 * serão implementadas desta forma possibilitando a inverssão de controle
 *  
 * */
namespace LP.Domain.Contratos
{
    public interface IResource
    {
        // Toda classe de dominio deve implementar a propriedade Id
        long Id { get; set; }
    }
}
