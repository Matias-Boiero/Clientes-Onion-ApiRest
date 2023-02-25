using Ardalis.Specification;

namespace Application.Interfaces
{
    //Utilizo los repoitorios genericos de Ardalis

    //Repositorio de acciones Crud 
    public interface IRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {
    }

    //Repositorio de acciones lectura u obtención de regisrtos
    public interface IReadRepositoryAsync<T> : IReadRepositoryBase<T> where T : class
    {

    }
}
