﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Modelos.ViewModels
{
    public class ProductoVM
    {

        public Producto Producto { get; set; }

        public IEnumerable<SelectListItem>? CategoriaLista { get; set; }

        public IEnumerable<SelectListItem>? TipoAplicacionLista { get; set; }


    }
}
