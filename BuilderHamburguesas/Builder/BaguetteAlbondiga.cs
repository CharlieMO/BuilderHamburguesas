using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public class BaguetteAlbondiga : BaguetteBuilder
    {
        public BaguetteAlbondiga(CarneEnum carne, PanEnum pan)
        {
            _baguette = new Baguette
            {
                Carne = carne,
                Pan = pan,
                Nombre = "BaguetteAlbondiga",
                Foto = "https://cdn2.cocinadelirante.com/sites/default/files/styles/gallerie/public/images/2017/06/baguettedealbondigas.jpg",
                Costo = 50.50,
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
            _baguette.Ingredientes.Add("Salsa de albóndiga");
            _baguette.Costo += 2.50;
        }
        public override void AñadirPapas()
        {
            _baguette.Papas = true;
        }
        public override void AñadirCatsup()
        {
        }
    }
}
