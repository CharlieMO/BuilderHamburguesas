using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class HawaiiBurger : HamburguesaBuilder
    {
        public HawaiiBurger(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "HawaiiBurger",
                Foto = "https://thepioneerwoman.com/wp-content/uploads/2016/03/dsc_1187.jpg?resize=780%2C519",
                Costo = 99.50,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _hamburguesa.Ingredientes.Add("Lechuga Hawaiana");
            _hamburguesa.Costo += 8.50;
        }
        public override void AñadirQueso()
        {
            _hamburguesa.Ingredientes.Add("Queso volcánico");
            _hamburguesa.Costo += 6.50;
        }
        public override void AñadirJitomate()
        {
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Costo += 5.50;
        }
        public override void AñadirSalsa()
        {
            _hamburguesa.Ingredientes.Add("Salsa de lava");
            _hamburguesa.Costo += 7.50;
        }
        public override void AñadirPapas()
        {
            _hamburguesa.Papas = false;
        }
        public override void AñadirCatsup()
        {
        }
    }
}

