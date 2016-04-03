using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Financiera.Dominio;
using Financiera.Infraestructura;
namespace Financiera.Prueba
{
    [TestClass]
    public class PruebasIntegralesCliente
    {
        [TestMethod]
        public void AgregarCliente()
        {
            using(var lo_contexto = new FinancieraContexto())
            {
                var lo_cliente = Cliente.Agregar(1, "Kevin Cutipa Chambilla", DateTime.Parse("22/08/1992"));
                lo_contexto.Clientes.Add(lo_cliente);
                lo_contexto.SaveChanges();
            }
        }
    }
}
