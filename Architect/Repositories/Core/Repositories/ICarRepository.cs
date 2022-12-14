using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core.Repositories
{
    public interface ICarRepository : IGenericRepository<Car>
    {

        IEnumerable<Car> GetCarsWithEverything();

        Car GetCarWithEverything(object id);
    }
}
