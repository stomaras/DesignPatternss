using DAL;
using Entities.VehicleParts;
using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance.Repositories
{
    public class EngineMotorRepository : GenericRepository<EngineMotors>, IEngineMotorRepository
    {
        public EngineMotorRepository(MainDBContext context): base(context)
        {

        }
    }
}
