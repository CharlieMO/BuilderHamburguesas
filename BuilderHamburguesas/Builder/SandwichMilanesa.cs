using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class SandwichMilanesa : SandwichBuilder
    {
        public SandwichMilanesa(CarneEnum carne, PanEnum pan)
        {
            _sandwich = new Sandwich
            {
                Carne = carne,
                Pan = pan,
                Nombre = "SandwichMilanesa",
                Foto = "https://media.minutouno.com/adjuntos/150/imagenes/028/983/0028983751.jpg",
                Costo = 35.00,
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
        }
        public override void AñadirJitomate()
        {
        }
        public override void AñadirSalsa()
        {
            _sandwich.Ingredientes.Add("Tinta de mar");
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
