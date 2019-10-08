using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class SandwichTernera : SandwichBuilder
    {
        public SandwichTernera(CarneEnum carne, PanEnum pan)
        {
            _sandwich = new Sandwich
            {
                Carne = carne,
                Pan = pan,
                Nombre = "SandwichTernera",
                Foto = "https://t2.rg.ltmcdn.com/es/images/8/7/4/img_sandwich_de_ternera_y_queso_57478_600_square.jpg",
                Costo = 33.50,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _sandwich.Ingredientes.Add("Lecucha de rancho");
            _sandwich.Costo += 2.50;
        }
        public override void AñadirQueso()
        {
        }
        public override void AñadirJitomate()
        {
            _sandwich.Ingredientes.Add("Jitomate de rancho");
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
