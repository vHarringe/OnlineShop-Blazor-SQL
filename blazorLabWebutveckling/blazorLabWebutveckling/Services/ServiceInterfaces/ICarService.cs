
using blazorLabWebutveckling.Entities;

namespace blazorLabWebutveckling.Services.ServiceInterfaces
{
    public interface ICarService
    {
        public Task<IEnumerable<Car>> GetAllCarsAsync();
    }
}
