using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistencia.Data;
using Persistencia.Entities;

namespace Aplicacion.Repository;

public class OficinaRepository : IEntityTypeConfiguration<Oficina>
{
    public readonly ProyectoFinalContext _context;

    public OficinaRepository(ProyectoFinalContext context)
    {
        _context = context;
    }
    public void Configure(EntityTypeBuilder<Oficina> builder)
    {
    }
    //#3
public async Task<IEnumerable<object>> ConsultaThree()
{
    var ConsultaThree = from Oficina in _context.Oficinas
                        join Empleado in _context.Empleados
                        on Oficina.Id equals Empleado.CodigoEmpleado
                        select new
                        {
                            OficinaEmple = Oficina.CodigoOficina,
                        };

    var resultados = await ConsultaThree.ToListAsync();

    foreach (var resultado in resultados)
    {
        
        
    }

    return resultados;
}
}
