using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_TEAPLC.MODEL
{
    public class Cuenta
    {
        public int Id_Cuenta { get; set; }        
        public string Numero_Cuenta { get; set; }
        public long Numero_Cuenta_Cliente { get; set; }
        public int Id_Banco { get; set; }
        public int Id_Tipo_Cuenta { get; set; }
        public int Id_Moneda { get; set; }
        public int Id_Colaborador { get; set; }
    }
}
