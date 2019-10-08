using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class BaguettePavo : BaguetteBuilder
    {
        public BaguettePavo(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Carne = carne,
                Pan = pan,
                Nombre = "BaguettePavo",
                Foto = "https://cocinaconalegria.com/media/zoo/images/Img20389_538aa00b8eb6fe265aa2c7e91e4b7621.jpg",
                Costo = 60.50,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _baguette.Ingredientes.Add("Lechuga verde");
        }
        public override void AñadirQueso()
        {
        }
        public override void AñadirJitomate()
        {
            _baguette.Ingredientes.Add("Jitomate rojo");
        }
        public override void AñadirSalsa()
        {
            _baguette.Ingredientes.Add("Salsa de albóndiga");
            _baguette.Costo += 2.50;
        }
        public override void AñadirPapas()
        {
            _baguette.Papas = true;
        }
        public override void AñadirCatsup()
        {
        }
    }
}
