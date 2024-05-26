using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    public class Direccion
    {
        private string ciudad;
        private string calle;
        public Direccion()
        {
            ciudad = string.Empty;
            calle = string.Empty;
        }
        public Direccion(string ciudad, string calle)
        {
            this.ciudad = ciudad;
            this.calle = calle;
        }
        public string Ciudad { get=>ciudad; set=>ciudad = value; }
        public string Calle { get=>calle; set=>calle = value; }
    }
}
