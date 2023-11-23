﻿using System;
using System.Collections.Generic;
using Dominio.Entities;

namespace Persistencia.Entities;

public partial class Pago : BaseEntity
{
    public int CodigoCliente { get; set; }

    public string FormaPago { get; set; } = null!;

    public string IdTransaccion { get; set; } = null!;

    public DateOnly FechaPago { get; set; }

    public decimal Total { get; set; }

    public virtual Cliente CodigoClienteNavigation { get; set; } = null!;
}
