﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class ProductoViewModel
    {
        public Guid Id { get; set; }
        public string Tipo { get; set; }
        public bool Activo { get; set; }
        public double Precio { get; set; }
    }
}
