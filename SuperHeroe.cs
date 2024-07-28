﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    class SuperHeroe
    {
        public string nombre;
        public string identidadSecreta;
        public string ciudad;
        public bool puedeVolar;
        public SuperPoder superPoder;

        public SuperHeroe( string nombre, string identidadSecreta,
            string ciudad, bool puedeVolar, SuperPoder superPoder)

        {
            this.nombre = nombre;
            this.identidadSecreta = identidadSecreta;
            this.ciudad = ciudad;
            this.puedeVolar = puedeVolar;
            this.superPoder = superPoder;

        }
    }
}
