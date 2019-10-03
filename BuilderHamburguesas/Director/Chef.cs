using BuilderHamburguesas.Builder;
using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Director
{
    public class Chef
    {
        private HamburguesaBuilder _hamburguesaBuilder;

        public void OrdenHamburguesa(HamburguesaBuilder hamburguesaBuilder)
        {
            _hamburguesaBuilder = hamburguesaBuilder;
        }

        public void CocinarHamburguesaPasoAPaso()
        {
            _hamburguesaBuilder.AñadirLechuga();
            _hamburguesaBuilder.AñadirQueso();
            _hamburguesaBuilder.AñadirJitomate();
            _hamburguesaBuilder.AñadirSalsa();
            _hamburguesaBuilder.AñadirPapas();
            _hamburguesaBuilder.AñadirCatsup();
        }

        public Hamburguesa HamburgesaTermianda => _hamburguesaBuilder.TerminaPizza();

        public Hamburguesa PrepararHamburguesa(HamburguesaBuilder hamburguesaBuilder)
        {
            hamburguesaBuilder.AñadirLechuga();
            hamburguesaBuilder.AñadirQueso();
            hamburguesaBuilder.AñadirJitomate();
            hamburguesaBuilder.AñadirSalsa();
            hamburguesaBuilder.AñadirPapas();
            hamburguesaBuilder.AñadirCatsup();
            return hamburguesaBuilder.TerminaPizza();
        }
    }
}
