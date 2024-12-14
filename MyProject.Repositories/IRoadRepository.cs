using MyProject.Models;

namespace MyProject.Data.Repositories
{
    public interface IRoadRepository
    {
        // Method to get a list of roads to avoid based on traffic conditions and roadworks
        Task<List<Road>> GetRoadsToAvoidAsync();
    }
}
