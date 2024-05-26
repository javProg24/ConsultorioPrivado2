using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    public class Paciente :Persona, IEntidad
    {
        /*private int id;
        private string cedula;
        private string nombre;
        private string apellido;
        private string correo;
        private int telefono;*/
        public Paciente()
        { 
        }

        public Paciente(int id, 
                        string cedula, 
                        string nombre, 
                        string apellido, 
                        string correo, 
                        string telefono,
                        List<Direccion>listaDireccion)
            : base(id, cedula, nombre, apellido, correo, telefono,listaDireccion)
        {
            /*this.id = id;
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.telefono = telefono;*/
        }
/*
        public int Id { getTabla => id; set => id = value; }
        public string Cedula { getTabla => cedula; set => cedula = value; }
        public string Nombre { getTabla => nombre; set => nombre = value; }
        public string Apellido { getTabla => apellido; set => apellido = value; }
        public string Correo { getTabla => correo; set => correo = value; }
        public int Telefono { getTabla => telefono; set => telefono = value; }*/
    }
}
