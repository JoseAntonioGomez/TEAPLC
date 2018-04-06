using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_TEAPLC.MODEL
{
    public class Prestamo
    {
        public int Id_Prestamo { get; set; }
        public int Id_Colaborador { get; set; }
        public string Descripcion { get; set; }
        public string Monto { get; set; }
        public string MontoPendiente { get; set; }
        public int Id_Estado { get; set; }
    }
}
