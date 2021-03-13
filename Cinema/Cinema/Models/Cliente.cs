using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class Cliente
    {
        public int id {
            get;
            set;        
        }
        
        public String nombre {
            get;
            set;
        }

        public int edad
        {
            get;
            set;
        }

        public String telefono
        {
            get;
            set;
        }

        public String DUI
        {
            get;
            set;
        }

        public String direccion
        {
            get;
            set;
        }

    }
}