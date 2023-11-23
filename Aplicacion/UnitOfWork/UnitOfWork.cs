using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Dominio.Interfaces;

namespace Aplicacion.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public IClienteInterface _Cliente;
        public IGamaProductInterface _GamaProducto;
        public IEmpleadoInterface _Empleado;
        public IOficinaInterface _Oficina;
        public IPagoInterface _Pago;
        public IProductoInterface _Producto;
        public IDetallePedidoInterface _DetallePedido;
        public IPedidoInterface _Pedido;

    }
}