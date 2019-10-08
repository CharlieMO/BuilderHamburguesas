using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public abstract class Platillo
    {
        public abstract IComida PrepararPlatillo();
    }
}
