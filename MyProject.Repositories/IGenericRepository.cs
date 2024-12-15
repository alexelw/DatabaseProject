using MyProject.Data;
namespace MyProject.Data.Repositories
{
public interface IGenericRepository<T> where T : class
{
    Task<List<T>> GetAllAsync();
}
}