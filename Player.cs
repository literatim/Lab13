using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    abstract class Player
    {
        public string UserName { get; set; }
        public string RoshamboValue { get; set; }

        public abstract string GenerateRoshambo();
    }
}
