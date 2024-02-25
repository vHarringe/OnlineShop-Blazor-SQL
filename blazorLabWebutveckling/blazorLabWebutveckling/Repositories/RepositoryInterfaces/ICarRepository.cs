

using blazorLabWebutveckling.Entities;

namespace blazorLabWebutveckling.Repositories.RepositoryInterfaces
{
    public interface ICarRepository
    {
        public Task<IEnumerable<Car>> GetAllCarsAsync();
        public Task<Car> GetCarById(int id);
    }
}
