using PoS_Repository.Entities;

namespace PoS_Service.Interfaces
{
    public interface IVentaRepository
    {
        Task<string> Registrar(string ventaXML);
        Task<Venta> Obtener(string numeroVenta);
        Task<List<DetalleVenta>> ObtenerDetalle(string numeroVenta);
    }
}
