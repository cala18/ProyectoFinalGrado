using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PagoDto : BaseDto
    {
        public int CodigoCliente { get; set; }
        public string FormaPago { get; set; }
        
    }
}