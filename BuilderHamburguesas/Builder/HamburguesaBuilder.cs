using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHamburguesas.Builder
{
    public abstract class HamburguesaBuilder
    {
        protected Hamburguesa _hamburguesa;

        public string Carne { get; set; }
        public string Pan { get; set; }
        public Hamburguesa TerminaPizza() { return _hamburguesa; }

        public virtual void AñadirLechuga()
        {

        }
        public virtual void AñadirQueso()
        {

        }
        public virtual void AñadirJitomate()
        {

        }
        public virtual void AñadirSalsa()
        {

        }
        public virtual void AñadirPapas()
        {

        }

        public virtual void AñadirCatsup()
        {

        }

    }
}
