﻿using Microsoft.AspNetCore.Mvc.Rendering;
using AccesoDatos.Datos.Repositorio.IRepositorio;
using Modelos;
using Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Datos.Repositorio
{
    public class VentaRepositorio : Repositorio<Venta>, IVentaRepositorio
    {

        private readonly ApplicationDbContext _db;

        public VentaRepositorio(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Actualizar(Venta venta)
        {
            _db.Update(venta);
        }

        
    }
}
