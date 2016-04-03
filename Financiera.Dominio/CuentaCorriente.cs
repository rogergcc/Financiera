using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Dominio
{
    public class CuentaCorriente
    {
        ///<sumary>
        
        /// Clase Cuenta Corriente 
        /// </sumary>
        public string NumeroCuenta { get; private set; }
        public decimal Saldo { get; private set; }
        public int CodigoCliente { get; private set; }
        public string EstadoCuenta { get; private set; }
        public virtual Cliente Propietario { get; private set; }
        private CuentaCorriente()
        {
        }
        public static CuentaCorriente Aperturar(string as_num_cuenta, Cliente ao_cliente)
        {
            return new CuentaCorriente()
            {
                NumeroCuenta = as_num_cuenta,
                Propietario = ao_cliente,
                CodigoCliente = ao_cliente.CodigoCliente,
                Saldo = 0,
                EstadoCuenta = "REGISTRADO"
            };
        }
        public void Cancelar()
        {
            EstadoCuenta = "CANCELADO";
        }
    }
}
