﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Datos.DbOpeaciones;
using ConsultorioPrivado.Utilidad.Datos;

namespace ConsultorioPrivado.Datos.Interface
{
    internal class ExecuteSP : DataAccess_DB
    {
        private StringBuilder cadenaFinal;
        private ExecuteQuery obj_bd;

        public ExecuteSP() {
            obj_bd = new ExecuteQuery();
            cadenaFinal= new StringBuilder();
        }

        public string crearCadenaFinal(E_CODIGO_SP codigo, E_ROL rol) {
            cadenaFinal.Append(codigo);
            cadenaFinal.Append(rol);
            return cadenaFinal.ToString();
        }
            
        public DataTable getTabla(E_ROL rol)
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_GET, rol), lista);
        }

        public DataTable getId(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_GET_ID, rol), lista);
        }

        public bool crear(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_CREA, rol), lista);
        }

        public bool actualiza(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_ACTUALIZA, rol), lista);
        }

        public bool elimina( E_ROL rol, List<CD_Parameter_SP> lista)
        {
            return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_ELIMINA, rol), lista);
        }
        public DataTable buscar(E_ROL rol,List<CD_Parameter_SP> lista)
        {
            return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_BUSCAR, rol), lista);
        }
        public DataTable getNombresCompletos(E_ROL rol)
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_GET_NOMBRES_COM, rol),lista);
        }
    }
}
