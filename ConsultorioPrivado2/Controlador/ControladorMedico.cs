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
    public class ControladorMedico:I_Controlador<Medico>
    {
        private DataAccess_DB interfaceDatos;
        private string error;
        private string rol;
        public ControladorMedico() 
        {
            error = "Error"; interfaceDatos = new ExecuteSP(); rol = E_ROL._MEDICO.ToString();  
        }
        /*
         * ACTUALIZAR
         */
        public bool actualizar(Medico objeto)
        {
            try
            {
                List<CD_Parameter_SP> lista =
            [
                new CD_Parameter_SP("@parametro0", objeto.Id, SqlDbType.Int),
                new CD_Parameter_SP("@parametro1", objeto.Cedula, SqlDbType.Text),
                new CD_Parameter_SP("@parametro2", objeto.Nombres, SqlDbType.Text),
                new CD_Parameter_SP("@parametro3", objeto.Apellidos, SqlDbType.Text),
                new CD_Parameter_SP("@parametro4", objeto.Correo, SqlDbType.Text),
                new CD_Parameter_SP("@parametro5", objeto.Telefono, SqlDbType.Text),
                new CD_Parameter_SP("@parametro6", objeto.Especialidad, SqlDbType.Text)
            ];
                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.actualiza(E_ROL._MEDICO, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al actualizar el " + rol + " " + ex.Message);
            }
        }
        /*
         * BUSCAR
         */
        public DataTable buscar(Medico objeto)
        {
            try
            {
                List<CD_Parameter_SP> lista = [
                    new CD_Parameter_SP("@parametro0", objeto.Id, SqlDbType.Int)
                ];
                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.buscar(E_ROL._MEDICO, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al buscar el " + rol + " " + ex.Message);
            }
        }
        /*
         * CREAR
         */
        public bool crear(Medico objeto)
        {
            try
            {
                List<CD_Parameter_SP> lista =
            [
                new CD_Parameter_SP("@parametro1", objeto.Cedula, SqlDbType.Int),
                new CD_Parameter_SP("@parametro2", objeto.Nombres, SqlDbType.Text),
                new CD_Parameter_SP("@parametro3", objeto.Apellidos, SqlDbType.Text),
                new CD_Parameter_SP("@parametro4", objeto.Correo, SqlDbType.Text),
                new CD_Parameter_SP("@parametro5", objeto.Telefono, SqlDbType.Text),
                new CD_Parameter_SP("@parametro6",objeto.Especialidad,SqlDbType.Text)
            ];

                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.crear(E_ROL._MEDICO, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al guardar un nuevo " + rol + " " + ex.Message);
            }
        }
        /*
         * ELIMINAR
         */
        public bool eliminar(Medico objeto)
        {
            try
            {
                List<CD_Parameter_SP> lista = [
                    new CD_Parameter_SP("@parametro0", objeto.Id, SqlDbType.Int)
                ];
                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.elimina(E_ROL._MEDICO, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al eliminar el " + rol + " " + ex.Message);
            }
        }
        /*
         * OBTENER TABLA
         */
        public DataTable getTabla()
        {
            try
            {
                return interfaceDatos.getTabla(E_ROL._MEDICO);
            }
            catch(Exception ex) 
            {
                throw new Exception(error + " al obtener tabla de " + rol + " " + ex.Message);
            }
        }
        public DataTable getId(Medico objeto)
        {
            throw new NotImplementedException();
        }
    }
}
