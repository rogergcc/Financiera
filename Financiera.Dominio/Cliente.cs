using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Dominio
{
    public class Cliente
    {
        public int CodigoCliente { get; private set; }
        public string NombreCliente { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        private Cliente()
        {
        }
        public static Cliente Agregar(int ai_cod_cliente, string as_nom_cliente, DateTime adt_fec_nacimiento)
        {
            return new Cliente()
            {
                CodigoCliente = ai_cod_cliente,
                NombreCliente = as_nom_cliente,
                FechaNacimiento = adt_fec_nacimiento
            };
        }
    }
}
