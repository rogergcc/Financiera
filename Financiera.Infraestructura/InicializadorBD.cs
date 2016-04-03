using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Financiera.Infraestructura
{
    public class InicializadorBD : CreateDatabaseIfNotExists<FinancieraContexto>
    {
        protected override void Seed(FinancieraContexto context)
        {
            base.Seed(context);
        }
    }
}
