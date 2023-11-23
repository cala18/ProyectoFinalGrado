using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistencia.Data;
using Persistencia.Entities;

namespace Aplicacion.Repository;

public class ClienteRepositoy : IEntityTypeConfiguration<Cliente>
{
    public readonly ProyectoFinalContext _context;

    public ClienteRepositoy(ProyectoFinalContext context)
    {
        _context = context;
    }
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
    }
    //#1
    public async Task<IEnumerable<object>> ConsultaOne()
    {
        var consultaOne = from cliente in _context.Clientes
                          join pedido in _context.Pedidos
                          on cliente.CodigoCliente equals pedido.CodigoCliente
                          select new
                          {
                              CodigoCliente = cliente.CodigoCliente,
                              PedidoProducto = pedido.CodigoPedido,
                              FechaEsperada = pedido.FechaEsperada,
                              FechaDeEntregada = pedido.FechaEntrega,
                              FechaATiempo = pedido
                          };


        return await consultaOne.ToListAsync();
    }
    //#2
    public async Task<IEnumerable<object>> ConsultaTwo()
    {
        var ConsultaTwo = from Cliente in _context.Clientes
                          join Empleado in _context.Empleados
                          on Cliente.CodigoCliente equals Empleado.CodigoEmpleado
                          select new
                          {
                            ClienteMora = Cliente.CodigoEmpleadoRepVentas,
                            ClienteNoPago = Cliente.Pagos
                          };
                          return await ConsultaTwo.ToListAsync();
    }





}
