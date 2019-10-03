using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Models
{
    public class Hamburguesa
    {
        public PanEnum Pan { get; set; }
        public double Costo { get; set; }
        public string Nombre { get; set; }
        public CarneEnum Carne { get; set; }
        public string Foto { get; set; }
        public List<string> Ingredientes { get; set; }
        public bool Papas { get; set; }

        public Hamburguesa()
        {

        }

        public Hamburguesa(PanEnum pan, double costo, string nombre, CarneEnum carne, string foto, List<string> ingredientes, bool papas)
        {
            Pan = pan;
            Costo = costo;
            Nombre = nombre;
            Carne = carne;
            Foto = foto;
            Ingredientes = ingredientes;
            Papas = papas;
        }

        public override string ToString()
        {
            if (Papas)
                return $"-Hamburguesa {Nombre}, Pan:  {Pan}, Carne: {Carne}, Ingredientes: {string.Join(", ", Ingredientes)}, Papas: Sí, Costo: ${Costo}";
            else
                return $"-Hamburguesa {Nombre}, Pan:  {Pan}, Carne: {Carne}, Ingredientes: {string.Join(", ", Ingredientes)}, Papas: No, Costo: ${Costo}";
        }
    }
}
