using Modelos;
using AccesoDatos.Datos.Repositorio.IRepositorio;

namespace AccesoDatos.Datos.Repositorio
{
    public class OrdenRepositorio : Repositorio<Orden>, IOrdenRepositorio
    {

        private readonly ApplicationDbContext _db;

        public OrdenRepositorio(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Actualizar(Orden orden)
        {
            _db.Update(orden);
        }

        
    }
}
