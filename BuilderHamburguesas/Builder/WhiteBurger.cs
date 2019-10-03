using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class WhiteBurger : HamburguesaBuilder
    {
        public WhiteBurger(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "WhiteBurger",
                Foto = "https://img.buzzfeed.com/thumbnailer-prod-us-east-1/01efeca916c14c9ebcea7c4e6dada880/BFV38278_FriedChickenRiceBurger_FBFINAL_FINAL.jpg",
                Costo = 83.50,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _hamburguesa.Ingredientes.Add("Lechuga asiática");
            _hamburguesa.Costo += 3.50;
        }
        public override void AñadirQueso()
        {
            _hamburguesa.Ingredientes.Add("Queso oriental");
            _hamburguesa.Costo += 4.50;
        }
        public override void AñadirJitomate()
        {
        }
        public override void AñadirSalsa()
        {
            _hamburguesa.Ingredientes.Add("Salsa de soya");
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