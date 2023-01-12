using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Coche
    {
        int puertas = 0;

        public int IncrementoPuertas()
        {
            puertas++;
            return puertas = +puertas;
        }

        public int TotalPuertas()
        {
            return puertas;
        }

    }


}
