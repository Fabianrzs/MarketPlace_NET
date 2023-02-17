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
    public class OrdenDetalleRepositorio : Repositorio<OrdenDetalle>, IOrdenDetalleRepositorio
    {

        private readonly ApplicationDbContext _db;

        public OrdenDetalleRepositorio(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Actualizar(OrdenDetalle ordenDetalle)
        {
            _db.Update(ordenDetalle);
        }

        
    }
}
