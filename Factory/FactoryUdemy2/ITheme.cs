using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryUdemy2
{
    public interface ITheme
    {
        string TextColor { get; }
        string BgrColor { get; }
    }
}
