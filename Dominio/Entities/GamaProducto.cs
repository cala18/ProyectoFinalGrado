﻿using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class GamaProducto : BaseEntity
{
    public string Gama { get; set; } = null!;

    public string? DescripcionTexto { get; set; }

    public string? DescripcionHtml { get; set; }

    public string? Imagen { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
