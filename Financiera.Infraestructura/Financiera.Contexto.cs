using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Financiera.Dominio;


namespace Financiera.Infraestructura
{
    public class FinancieraContexto : DbContext, IDisposable
    {
        public FinancieraContexto() : base("Conexion")
        {
            Database.SetInitializer<FinancieraContexto>(new InicializadorBD());
        }
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaCorriente> Cuentas { get; set; }
        public DbSet<OperacionCuenta> Operaciones { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().HasKey(k => k.CodigoCliente);
            modelBuilder.Entity<CuentaCorriente>().HasKey(k => k.NumeroCuenta);
            modelBuilder.Entity<OperacionCuenta>().HasKey(k => k.NumeroOperacion);
            ///mapera llaves foraneas
            /// identity
        }

    }
    
}
