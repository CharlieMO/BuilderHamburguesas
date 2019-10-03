using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class BurgerBurger : HamburguesaBuilder
    {
        public BurgerBurger(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Carne = carne,
                Pan = pan,
                Nombre = "BurgerBurger",
                Foto = "https://dam.cocinafacil.com.mx/wp-content/uploads/2018/06/hamburguesa-mexicana.jpg",
                Costo = 75.50,
                Ingredientes = new List<string>()
            };
        }

        public override void AñadirLechuga()
        {
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Costo += 5.50;
        }
        public override void AñadirQueso()
        {
            _hamburguesa.Ingredientes.Add("Queso amarillo");
            _hamburguesa.Costo += 3.25;
        }
        public override void AñadirJitomate()
        {
            _hamburguesa.Ingredientes.Add("Jitomate cherry");
            _hamburguesa.Costo += 4.25;
        }
        public override void AñadirSalsa()
        {
            _hamburguesa.Ingredientes.Add("Salsa original");
            _hamburguesa.Costo += 2.50;
        }
        public override void AñadirPapas()
        {
            _hamburguesa.Papas = false;
        }
        public override void AñadirCatsup()
        {
            _hamburguesa.Ingredientes.Add("Catsup");
            _hamburguesa.Costo += 1.50;
        }
    }
}
