
using blazorLabWebutveckling.Entities;
using blazorLabWebutveckling.Repositories.RepositoryInterfaces;
using blazorLabWebutveckling.Services.ServiceInterfaces;




namespace blazorLabWebutveckling.Services
{
    public class CarServices : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarServices(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<IEnumerable<Car>> GetAllCarsAsync()
        {
            return await _carRepository.GetAllCarsAsync();
        }
    }
}
