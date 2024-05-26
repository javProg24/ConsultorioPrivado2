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
    public class ControladorPaciente : I_Controlador<Paciente>
    {
        private DataAccess_DB interfaceDatos;
        private string error;
        private string rol;
        public ControladorPaciente()
        {
            error = "Error";
            interfaceDatos = new ExecuteSP();
            rol = E_ROL._PACIENTE.ToString();
        }
        public DataTable getId(Paciente objeto)
        {
            throw new NotImplementedException();
        }
        public DataTable getTabla()
        {
            try
            {
                return interfaceDatos.getTabla(E_ROL._PACIENTE);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al obtener tabla de " + rol + " " + ex.Message);
            }    
        }
        public bool crear(Paciente objeto)
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
            ];

                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.crear(E_ROL._PACIENTE, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al guardar un nuevo " + rol + " " + ex.Message);
            } 
        }
        public bool actualizar(Paciente objeto)
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
            ];
                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.actualiza(E_ROL._PACIENTE, lista);
            }
            catch(Exception ex)
            {
                throw new Exception(error + " al actualizar el " + rol + " " + ex.Message);
            }    
        }
        public bool eliminar(Paciente objeto)
        {
            try
            {
                List<CD_Parameter_SP> lista = [
                    new CD_Parameter_SP("@parametro0", objeto.Id, SqlDbType.Int)
                ];
                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.elimina(E_ROL._PACIENTE, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al eliminar el " + rol + " " + ex.Message);
            }
            //throw new NotImplementedException();
        }
        public DataTable buscar(Paciente objeto)
        {
            try
            {
                List<CD_Parameter_SP> lista = [
                    new CD_Parameter_SP("@parametro0", objeto.Id, SqlDbType.Int)
                ];
                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.buscar(E_ROL._PACIENTE, lista);
            }
            catch( Exception ex )
            {
                throw new Exception(error + " al buscar el " + rol + " " + ex.Message);
            }
        }
    }
}
