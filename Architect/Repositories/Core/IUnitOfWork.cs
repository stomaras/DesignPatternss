using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICarRepository Cars { get; }
        IMotorRepository Motors { get; }
        IDoorRepository Doors { get; }
        IEngineRepository Engines { get; }
        IEngineMotorRepository EngineMotors { get; }
        IWheelRepository Wheels { get; }
        IWheelMotorRepository MotorWheels { get; }
        int Complete();
    }
}
