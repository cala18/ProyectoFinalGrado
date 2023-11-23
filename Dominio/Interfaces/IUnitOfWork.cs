
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
         IClienteInterface Cliente{get;}
        IDetallePedidoInterface Detalle{get;}
        IEmpleadoInterface Empleado{get;}
        IGamaProductInterface GamaProduct{get;}
        IOficinaInterface Oficina{get;}
        IPagoInterface Pago{get;}
        IProductoInterface Producto{get;}
        
    }
}