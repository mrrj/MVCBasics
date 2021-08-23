using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Models
{
    public class Doctor
    {
        public static bool HasFever(double temperature)
        {
            if (temperature > 37.5) return true;
            else return false;

        }

    }
}
