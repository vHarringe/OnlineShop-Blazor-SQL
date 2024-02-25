
using blazorLabWebutveckling.Entities;

namespace blazorLabWebutveckling.Services.ServiceInterfaces
{
    public interface ICarService
    {
        public Task<IEnumerable<Car>> GetAllCarsAsync();
        public Task<Car> GetCarById(int id);
        public Task HonkCar(Car car);
    }
}
