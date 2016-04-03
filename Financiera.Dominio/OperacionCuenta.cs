using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Dominio
{
    public class OperacionCuenta
    {
        public int NumeroOperacion { get; private set; }
        public string NumeroCuenta { get; private set; }
        public virtual CuentaCorriente Cuenta { get; private set; }
        public string TipoOperacion { get; private set; }
        public DateTime FechaOperacion { get; private set; }
        public decimal Monto { get; private set; }
        private OperacionCuenta()
        {
        }
        public static OperacionCuenta Adicionar(int ai_num_operacion, CuentaCorriente ao_cuenta, string as_tipo, decimal ao_monto)
        {
            return new OperacionCuenta()
            {
                NumeroOperacion = ai_num_operacion,
                Cuenta = ao_cuenta,
                TipoOperacion = as_tipo,
                Monto = ao_monto
            };
        }
    }
}
