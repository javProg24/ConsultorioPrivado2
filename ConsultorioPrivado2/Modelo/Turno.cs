using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    public class Turno
    {
        private int id;
        private int numeroTurno;
        private string consultorio;
        private string nombresPaciente;
        private string nombresMedico;
        private TimeOnly diaHora;
        public Turno()
        {
            id = 0;
            numeroTurno = 0;
            nombresPaciente = string.Empty;
            consultorio = string.Empty;
            nombresMedico = string.Empty;
            diaHora = new TimeOnly();
        }
        public Turno(int id, int turno, string consultorio, string nombresPaciente, string nombresMedico, TimeOnly diaHora)
        {
            this.id = id;
            this.numeroTurno = turno;
            this.consultorio = consultorio;
            this.nombresPaciente = nombresPaciente;
            this.nombresMedico = nombresMedico;
            this.diaHora = diaHora;
        }
        public int ID { get => id; set => id = value; }
        public int NumeroTurno {  get => numeroTurno; set => numeroTurno = value; }
        public string Consultorio {  get => consultorio; set => consultorio = value; }
        public string NombresPacientes { get => nombresPaciente; set => nombresPaciente = value; }
        public string NombresMedico {  get => nombresMedico; set => nombresMedico = value;}
        public TimeOnly DiaHora { get => diaHora; set => diaHora = value; }
    }
}
