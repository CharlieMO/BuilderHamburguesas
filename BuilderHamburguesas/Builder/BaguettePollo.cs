using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class BaguettePollo : BaguetteBuilder
    {
        public BaguettePollo(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Carne = carne,
                Pan = pan,
                Nombre = "BaguettePollo",
                Foto = "https://www.montaditosevilla.com/wp-content/uploads/2018/07/baguette-pollo-empanado.jpg",
                Costo = 43.50,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
        }
        public override void AñadirQueso()
        {
            _baguette.Ingredientes.Add("Queso amarillo");
            _baguette.Costo += 2.50;

        }
        public override void AñadirJitomate()
        {
        }
        public override void AñadirSalsa()
        {
            _baguette.Ingredientes.Add("Salsa de buffalo");
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
