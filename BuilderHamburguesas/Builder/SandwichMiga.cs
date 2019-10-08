using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class SandwichMiga : SandwichBuilder
    {
        public SandwichMiga(CarneEnum carne, PanEnum pan)
        {
            _sandwich = new Sandwich
            {
                Carne = carne,
                Pan = pan,
                Nombre = "SandwichMiga",
                Foto = "https://placeralplato.com/files/2015/05/Receta-de-sndwiches-de-miga.jpg",
                Costo = 42.50,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _sandwich.Ingredientes.Add("Lecucha miga");
            _sandwich.Costo += 2.50;
        }
        public override void AñadirQueso()
        {
            _sandwich.Ingredientes.Add("Queso de miga");
            _sandwich.Costo += 2.50;
        }
        public override void AñadirJitomate()
        {
            _sandwich.Ingredientes.Add("Jitomate miga");
            _sandwich.Costo += 2.50;
        }
        public override void AñadirSalsa()
        {
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
