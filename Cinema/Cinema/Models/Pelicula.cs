using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class Pelicula
    {
        public int id {
            get;
            set;
            }

        public String nombre {
            get;
            set;
            }

        public String genero {
            get;
            set;
            }

        public int anioLanzamiento {
            get;
            set;
        }

        public String clasificacion {
            get;
            set;
        }

    }
}