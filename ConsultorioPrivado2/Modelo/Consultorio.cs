using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    public class Consultorio
    {
        private string nombre;
        private string ruc;
        private string telefono;
        private Direccion direccion;
        
        private Consultorio()
        {
            nombre = string.Empty;
            ruc = string.Empty;
            telefono = string.Empty;
            direccion = null;
             
        }
        public Consultorio(string nombre, string ruc,
                           string telefono,
                           Direccion direccion
                           )
        {
            this.nombre = nombre;
            this.ruc = ruc;
            this.telefono = telefono;
            this.direccion = direccion;
            
        }
        public string Nombre { get => nombre; set=> nombre = value; }
        public string Ruc { get => ruc; set=> ruc = value; }
        public string Telefono {  get => telefono; set=> telefono = value; }
        public Direccion Direccion { get => direccion; set=> direccion = value; }
        
    }
}
