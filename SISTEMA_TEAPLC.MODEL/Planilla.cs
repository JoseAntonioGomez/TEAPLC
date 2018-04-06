using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_TEAPLC.MODEL
{
    public class Planilla
    {
        public int Id_Planilla { get; set; }
        public int Id_Colaborador { get; set; }
        public int Numero_Horas { get; set; }
        public decimal Precio_Horas { get; set; }
        public decimal Prestamo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
    }
}
