﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAcoes.Domain.Entidades
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public decimal ValorDeMercado { get; set; }
    }
}
