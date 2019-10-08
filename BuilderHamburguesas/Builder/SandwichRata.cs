using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class SandwichRata: SandwichBuilder
    {
        public SandwichRata(CarneEnum carne, PanEnum pan)
        {
            _sandwich = new Sandwich
            {
                Carne = carne,
                Pan = pan,
                Nombre = "SandwichRata",
                Foto = "https://image.tmdb.org/t/p/w780/Aas5fA8NN5vGyFaUNpxLnZ1Ozkc.jpg",
                Costo = 20.00,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
        }
        public override void AñadirQueso()
        {
        }
        public override void AñadirJitomate()
        {
        }
        public override void AñadirSalsa()
        {
        }
        public override void AñadirPapas()
        {
            _sandwich.Papas = true;
            _sandwich.Costo += 15.00;
        }
        public override void AñadirCatsup()
        {
        }
    }
}
