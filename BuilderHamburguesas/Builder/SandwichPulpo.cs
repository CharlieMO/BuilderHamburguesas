using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class SandwichPulpo : SandwichBuilder
    {
        public SandwichPulpo(CarneEnum carne, PanEnum pan)
        {
            _sandwich = new Sandwich
            {
                Carne = carne,
                Pan = pan,
                Nombre = "SandwichPulpo",
                Foto = "https://media-cdn.tripadvisor.com/media/photo-s/0a/8e/9d/9f/sandwich-de-pulpo.jpg",
                Costo = 75.50,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _sandwich.Ingredientes.Add("Lecucha clásica");
            _sandwich.Costo += 2.50;
        }
        public override void AñadirQueso()
        {
            _sandwich.Ingredientes.Add("Queso clásico");
            _sandwich.Costo += 2.50;

        }
        public override void AñadirJitomate()
        {
            _sandwich.Ingredientes.Add("Queso clásico");
            _sandwich.Costo += 2.50;

        }
        public override void AñadirSalsa()
        {
            _sandwich.Ingredientes.Add("Mostaza");
            _sandwich.Costo += 2.50;

        }
        public override void AñadirPapas()
        {
            _sandwich.Papas = true;
            _sandwich.Costo += 10.00;
        }
        public override void AñadirCatsup()
        {
        }
    }
}
