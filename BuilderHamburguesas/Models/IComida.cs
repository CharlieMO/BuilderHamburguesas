using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Models
{
    public interface IComida
    {
        PanEnum Pan { get; set; }
        double Costo { get; set; }
        string Nombre { get; set; }
        CarneEnum Carne { get; set; }
        string Foto { get; set; }
        List<string> Ingredientes { get; set; }
        bool Papas { get; set; }
    }
}
