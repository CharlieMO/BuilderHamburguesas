using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class FancyBurger : HamburguesaBuilder
    {
        public FancyBurger(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "FancyBurger",
                Foto = "https://ls.imgix.net/recipes/thumbnails/BAKEOFF_S02E05_SIGNATURE_JEREMY_1.jpg?w=620&h=310&auto=compress,format&fit=crop",
                Costo = 150.50,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _hamburguesa.Ingredientes.Add("Lechuga VIP");
            _hamburguesa.Costo += 10.50;
        }
        public override void AñadirQueso()
        {
            _hamburguesa.Ingredientes.Add("Queso dorado");
            _hamburguesa.Costo += 10.50;
        }
        public override void AñadirJitomate()
        {
            _hamburguesa.Ingredientes.Add("Jitomate VIP");
            _hamburguesa.Costo += 10.50;
        }
        public override void AñadirSalsa()
        {
            _hamburguesa.Ingredientes.Add("Salsa de dólar");
            _hamburguesa.Costo += 20.00;
        }
        public override void AñadirPapas()
        {
            _hamburguesa.Papas = true;
        }
        public override void AñadirCatsup()
        {
            _hamburguesa.Ingredientes.Add("Catsup Premium");
            _hamburguesa.Costo += 10.50;
        }
    }
}

