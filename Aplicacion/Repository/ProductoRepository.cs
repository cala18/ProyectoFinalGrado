using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic;
using Persistencia.Data;
using Persistencia.Entities;

namespace Aplicacion.Repository;

public class ProductoRepository : IEntityTypeConfiguration<Producto>
{
    public readonly ProyectoFinalContext _context;

    public ProductoRepository(ProyectoFinalContext context)
    {
        _context = context;
    }
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
    }
    // // #5
    // public async Task<IEnumerable<object>> ConsultaFive()
    // {
    //     var ConsultaFive = from Producto in _context.Productos
                           


    //     }
}
