using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class DetallePedidoDto : BaseDto
    {
        public int  CodigoPedido{ get; set; }
        public string FechaPedido { get; set; }
    }
}