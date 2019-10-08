using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class BaguetteSubway : BaguetteBuilder
    {
        public BaguetteSubway(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Carne = carne,
                Pan = pan,
                Nombre = "Subway",
                Foto = "https://www.maritimefun.com/marinerscove/wp-content/uploads/sites/7/2019/05/Subway.-Sandwich.jpg",
                Costo = 50.00,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _baguette.Ingredientes.Add("Lechuga Subway");
            _baguette.Costo += 2.50;
        }
        public override void AñadirQueso()
        {
            _baguette.Ingredientes.Add("Queso Subway");
            _baguette.Costo += 2.50;
        }
        public override void AñadirJitomate()
        {
            _baguette.Ingredientes.Add("Jitomate Subway");
            _baguette.Costo += 2.50;
        }
        public override void AñadirSalsa()
        {
            _baguette.Ingredientes.Add("Salsa de Subway");
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
