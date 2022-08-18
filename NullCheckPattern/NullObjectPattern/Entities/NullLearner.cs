using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Entities
{
    public class NullLearner : ILearner
    {
        public int Id => -1;

        public string UserName => "Just Browsing";

        public int CoursesCompleted => 0;
    }
}
