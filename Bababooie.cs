using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Bababooie
    {
        public static int GetRoshamboValue()
        {
            var rnd = new Random();
            return rnd.Next(Enum.GetNames(typeof(Roshambo)).Length);
        }
    }
}
