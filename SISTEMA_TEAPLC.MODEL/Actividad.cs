using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_TEAPLC.MODEL
{
    public class Actividad
    {
        public int Id_Actividad { get; set; }
        public int Id_Colaborador { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Finaliza { get; set; }
    }
}
