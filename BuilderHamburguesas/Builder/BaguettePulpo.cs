using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class BaguettePulpo : BaguetteBuilder
    {
        public BaguettePulpo(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Carne = carne,
                Pan = pan,
                Nombre = "BaguettePulpo",
                Foto = "https://media-cdn.tripadvisor.com/media/photo-s/12/26/6e/f3/bollo-de-pulpo-al-olivo.jpg",
                Costo = 75.50,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _baguette.Ingredientes.Add("Lechuga de mar");
        }
        public override void AñadirQueso()
        {
            _baguette.Ingredientes.Add("Queso de mar");
        }
        public override void AñadirJitomate()
        {
        }
        public override void AñadirSalsa()
        {
            _baguette.Ingredientes.Add("Salsa de tinta de pulpo");
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
