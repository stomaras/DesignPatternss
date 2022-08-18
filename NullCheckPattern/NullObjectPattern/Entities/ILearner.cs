using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Entities
{
    public interface ILearner
    {
        int Id { get; }
        string UserName { get; }
        int CoursesCompleted { get; }
    }
}
