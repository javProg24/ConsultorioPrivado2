using ConsultorioPrivado.Datos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador
{
    public interface I_ControladorOpc<T>
    {
        bool guardar(T objeto);
        DataTable buscar(T objeto);
        DataTable getTabla();
        DataTable getTurno();
    }
}
