using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class MexBurger : HamburguesaBuilder
    {
        public MexBurger(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "MexBurger",
                Foto = "https://t1.rg.ltmcdn.com/es/images/6/1/2/img_hamburguesa_mexicana_12216_600.jpg",
                Costo = 80.50,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _hamburguesa.Ingredientes.Add("Lechuga romana");
            _hamburguesa.Costo += 4.25;
        }
        public override void AñadirQueso()
        {
            _hamburguesa.Ingredientes.Add("Queso oaxaca");
            _hamburguesa.Costo += 5.50;
        }
        public override void AñadirJitomate()
        {
            _hamburguesa.Ingredientes.Add("Jitomate verde");
            _hamburguesa.Costo += 3.75;
        }
        public override void AñadirSalsa()
        {
            _hamburguesa.Ingredientes.Add("Guacamole");
            _hamburguesa.Costo += 5.50;
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
