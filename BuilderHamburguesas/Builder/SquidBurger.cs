using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class SquidBurger : HamburguesaBuilder
    {
        public SquidBurger(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "SquidBurger",
                Foto = "https://media-cdn.tripadvisor.com/media/photo-s/0d/90/10/ed/squid-burger-with-lettuce.jpg",
                Costo = 100.00,
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
            _hamburguesa.Ingredientes.Add("Salsa de tinta de pulpo");
            _hamburguesa.Costo += 20.00;

        }
        public override void AñadirPapas()
        {
            _hamburguesa.Papas = true;
        }
        public override void AñadirCatsup()
        {
            _hamburguesa.Ingredientes.Add("Catsup de mar");
            _hamburguesa.Costo += 20.00;
        }
    }
}