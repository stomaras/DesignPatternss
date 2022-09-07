using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MotorCycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        
        public DateTime CreatedDateTime { get; set; }
    }
}
