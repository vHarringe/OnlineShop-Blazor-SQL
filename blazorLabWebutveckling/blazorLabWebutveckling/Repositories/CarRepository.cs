using blazorLabWebutveckling.Data;
using blazorLabWebutveckling.Entities;
using blazorLabWebutveckling.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;


namespace blazorLabWebutveckling.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _data;

        public CarRepository(ApplicationDbContext data)
        {
            _data = data;
        }

        public async Task<IEnumerable<Car>> GetAllCarsAsync()
        {
            return await _data.Cars.ToListAsync();
        }

        public async Task<Car> GetCarById(int id)
        {
            var car = await _data.Cars.FirstOrDefaultAsync(c => c.Id == id);
            return car ?? new Car();
            

        }
    }
}
