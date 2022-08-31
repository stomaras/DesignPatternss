using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TShirt
    {
        public int Id { get; set; }
        public Color Color { get; set; }
        public Fabric Fabric { get; set; }
        public Size Size { get; set; }
    }
}
