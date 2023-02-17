using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class VentaDetalleRepositorio : Repositorio<VentaDetalle>, IVentaDetalleRepositorio
    {

        private readonly ApplicationDbContext _db;

        public VentaDetalleRepositorio(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Actualizar(VentaDetalle ventaDetalle)
        {
            _db.Update(ventaDetalle);
        }

        
    }
}
