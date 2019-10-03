using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class QuesosBurger : HamburguesaBuilder
    {
        public QuesosBurger(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "QuesosBurger",
                Foto = "https://i.ytimg.com/vi/2a9gxcKVNyI/maxresdefault.jpg",
                Costo = 45.50,
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
            _hamburguesa.Ingredientes.Add("Salsa Bufalo");
            _hamburguesa.Costo += 7.50;
        }
        public override void AñadirPapas()
        {
            _hamburguesa.Papas = true;
            _hamburguesa.Costo += 25.50;
        }
        public override void AñadirCatsup()
        {
        }
    }
}

