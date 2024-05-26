using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    public class Medico : Persona,IEntidad
    {
        private Especialidad especialidad;
        public Medico()
        {
            especialidad = new Especialidad();
        }
        /*private int id;
        private string nombre;
        private string apellido;
        private int telefono;
        private string correo;*/
        public Medico(int id, 
                      string cedula,
                      string nombre, 
                      string apellido, 
                      Especialidad especialidad, 
                      string correo, 
                      string telefono,
                      List<Direccion>listaDireccion)
            : base(id, cedula, nombre, apellido, correo, telefono,listaDireccion)
        {
            this.especialidad = especialidad;
            /*this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Correo = correo;*/
        }
        /*public int Id { getTabla => id; set => id = value; }
        public string Nombre { getTabla => nombre; set => nombre = value; }
        public string Apellido { getTabla => apellido; set => apellido = value; }
        public int Telefono { getTabla => telefono; set => telefono = value; }
        public string Correo { getTabla => correo; set => correo = value; }*/
        internal Especialidad Especialidad { get => especialidad; set => especialidad = value; }
    }
}
