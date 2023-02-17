using Modelos;

namespace AccesoDatos.Datos.Repositorio.IRepositorio
{
    public interface IVentaRepositorio : IRepositorio<Venta>
    {
        void Actualizar(Venta venta);
        
    }
}
