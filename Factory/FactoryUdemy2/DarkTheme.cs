using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryUdemy2
{
    public class DarkTheme : ITheme
    {
        public string TextColor => "White";

        public string BgrColor => "Dark Gray";
    }
}
