using Modelos;
namespace AccesoDatos.Datos.Repositorio.IRepositorio
{
    public interface IVentaDetalleRepositorio : IRepositorio<VentaDetalle>
    {
        void Actualizar(VentaDetalle ventaDetalle);

        
    }
}
