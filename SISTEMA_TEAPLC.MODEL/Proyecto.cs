using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_TEAPLC.MODEL
{
    public class Proyecto
    {
        public int Id_Proyecto { get; set; }        
        public int Id_Empresa { get; set; }
        public int Id_Encargado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
