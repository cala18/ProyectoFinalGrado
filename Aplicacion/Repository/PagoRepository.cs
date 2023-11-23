using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistencia.Entities;

namespace Aplicacion.Repository
{
    public class PagoRepository : IEntityTypeConfiguration<Pago>
    {
        public void Configure(EntityTypeBuilder<Pago> builder)
        {
            
        }
    }
}