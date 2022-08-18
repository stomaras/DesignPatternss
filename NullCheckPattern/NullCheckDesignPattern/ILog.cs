using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheckDesignPattern
{
    public interface ILog
    {
        void Info(string message);
        void warn(string message);
    }
}
