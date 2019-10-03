using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class EggBurger : HamburguesaBuilder
    {
        public EggBurger(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "EggBurger",
                Foto = "https://tmbidigitalassetsazure.blob.core.windows.net/secure/RMS/attachments/37/1200x1200/Gruyere-and-Egg-Burgers_EXPS_THAM18_192202_B12_12_1b.jpg",
                Costo = 50.00,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _hamburguesa.Ingredientes.Add("Lechuga clásica");
            _hamburguesa.Costo += 2.50;
        }
        public override void AñadirQueso()
        {
            _hamburguesa.Ingredientes.Add("Queso base");
            _hamburguesa.Costo += 2.50;
        }
        public override void AñadirJitomate()
        {
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Costo += 2.50;
        }
        public override void AñadirSalsa()
        {
            _hamburguesa.Ingredientes.Add("Salsa roja");
            _hamburguesa.Costo += 2.50;
        }
        public override void AñadirPapas()
        {
            _hamburguesa.Papas = false;
        }
        public override void AñadirCatsup()
        {
            _hamburguesa.Ingredientes.Add("Catsup");
            _hamburguesa.Costo += 2.50;
        }
    }
}

