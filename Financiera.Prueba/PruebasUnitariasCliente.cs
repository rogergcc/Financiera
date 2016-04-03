using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financiera.Dominio;
using Financiera.Infraestructura;
namespace Financiera.Prueba
{
    [TestClass]
    ///<sumary>
    /// 
    /// </sumary>
    public class PruebasUnitariasCliente
    {
        [TestMethod]
        public void AgregarCliente()
        {
            var lo_cliente = Cliente.Agregar(1, "Christian Roger", DateTime.Parse("17-12-1990"));
            using (var lo_contexto = new FinancieraContexto())
            {
                lo_contexto.Clientes.Add(lo_cliente);
                lo_contexto.SaveChanges();
            }
            Assert.IsTrue(lo_cliente.CodigoCliente == 1);
        }
    }
}
