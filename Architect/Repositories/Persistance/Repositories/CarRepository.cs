using DAL;
using Entities;
using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repositories.Persistance.Repositories
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(MainDBContext context) : base(context)
        {

        }

        public IEnumerable<Car> GetCarsWithEverything()
        {
            var carsWithEverything = table.Include(x => x.Wheels).Include(y => y.Doors).Include(z => z.Engine).ToList();

            return carsWithEverything;
        }

        public Car GetCarWithEverything(object id)
        {
            var cars = GetCarsWithEverything();

            foreach (var car in cars)
            {
                if (car.Id.Equals(id))
                {
                    return car;
                }
            }
            return null;
        }
    }
}
