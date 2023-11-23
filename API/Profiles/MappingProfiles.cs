using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Persistencia.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<DetallePedido, DetallePedidoDto>().ReverseMap();
            CreateMap<DetallePedido, DetallePedido>().ReverseMap();
            CreateMap<Empleado, EmpleadoDto>().ReverseMap();
            CreateMap<Oficina, OficinaDto>().ReverseMap();
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Pago, PagoDto>().ReverseMap();

        }
    }
}