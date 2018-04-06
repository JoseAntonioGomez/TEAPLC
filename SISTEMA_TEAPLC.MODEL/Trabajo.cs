using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_TEAPLC.MODEL
{
    public class Trabajo
    {
        public int Id_Trabajo { get; set; }
        public int Id_Proyecto { get; set; }
        public string Tipo_Trabajo { get; set; }
        public int Id_Tipo_Forro { get; set; }
        public string Area { get; set; }
        public string Precio { get; set; }
        public string Monto_Total { get; set; }
    }
}
