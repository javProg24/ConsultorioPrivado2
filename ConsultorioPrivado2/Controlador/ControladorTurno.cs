using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador
{
    public class ControladorTurno : I_ControladorOpc<Turno>
    {
        private DataAccess_DB interfaceDatos;
        private string error;
        private string rol;
        private int variable;
        public ControladorTurno()
        {
            error = "Error";
            interfaceDatos = new ExecuteSP();
            rol = E_ROL._TURNO.ToString();
            variable = 0;
        }

        public DataTable buscar(Turno objeto)
        {
            try
            {
                List<CD_Parameter_SP> lista =
                [
                    new CD_Parameter_SP("parametro1", objeto.NumeroTurno, SqlDbType.Int)
                ];
                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.buscar(E_ROL._TURNO, lista);
            }
            catch(Exception ex)
            {
                throw new Exception(error + " al buscar el " + rol + " " + ex.Message);
            }
        }

        public bool guardar(Turno objeto)
        {
            try
            {
                List<CD_Parameter_SP> lista = 
                [
                    new CD_Parameter_SP("parametro1", objeto.NumeroTurno, SqlDbType.Int),
                    new CD_Parameter_SP("parametro2", objeto.NombresPacientes, SqlDbType.Int),
                    new CD_Parameter_SP("parametro3", objeto.Consultorio, SqlDbType.Text),
                    new CD_Parameter_SP("parametro4", objeto.NombresMedico, SqlDbType.Text),
                    new CD_Parameter_SP("parametro5", objeto.DiaHora, SqlDbType.Text), //Fecha
                    new CD_Parameter_SP("parametro6", objeto.DiaHora, SqlDbType.Text), //Hora
                ];
                DataAccess_DB interfaceDatos=new ExecuteSP();
                return interfaceDatos.crear(E_ROL._TURNO,lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al guardar un nuevo " + rol + " " + ex.Message);
            }   
        }

        public DataTable getTabla()
        {
            try
            {
                return interfaceDatos.getTabla(E_ROL._TURNO);
            }
            catch(Exception ex)
            {
                throw new Exception(error + " al obtener tabla de " + rol + " " + ex.Message);
            }
        }
        //Obtener Nombres y Apellidos juntos en una sola tabla
        public DataTable obtenerNombresPaciente()
        {
            try
            {
                return interfaceDatos.getNombresCompletos(E_ROL._PACIENTE);
            }
            catch(Exception ex) 
            {
                throw new Exception(error + " al obtener nombres y apellidos de " 
                    + E_ROL._PACIENTE + " " + ex.Message);
            }
        }
        public DataTable obtenerNombresMedico()
        {
            try
            {
                return interfaceDatos.getNombresCompletos(E_ROL._MEDICO);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al obtener nombres y apellidos de "
                    + E_ROL._MEDICO + " " + ex.Message);
            }
        }

        public DataTable getTurno()
        {
            throw new NotImplementedException();
        }
        //Se activara cuando demos clic y se cambiara el valor de 0 a 1
        public int crearTurno(int generar)
        {
            
            for(int i= 0;i< variable; i++) 
            { 
                
            }
        }
        public int Variable { get=>variable; set=>variable = value; }
    }
}
