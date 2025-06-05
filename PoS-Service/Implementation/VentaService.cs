
using PoS_Repository.Entities;
using PoS_Service.Interfaces;

namespace PoS_Service.Implementation
{
    public class VentaService : IVentaService
    {
        private readonly IVentaRepository _ventaRepository;
        public VentaService(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository;
        }
        public async Task<string> Registrar(string ventaXML)
        {
            return await _ventaRepository.Registrar(ventaXML);
        }
        public async Task<Venta> Obtener(string numeroVenta)
        {
            return await _ventaRepository.Obtener(numeroVenta);
        }

        public async Task<List<DetalleVenta>> ObtenerDetalle(string numeroVenta)
        {
            return await _ventaRepository.ObtenerDetalle(numeroVenta);
        }

        public async Task<List<Venta>> Lista(string fechaInicio, string fechaFin, string buscar = "")
        {
            return await _ventaRepository.Lista(fechaInicio, fechaFin, buscar);
        }

        public async Task<List<DetalleVenta>> ReporteVenta(string fechaInicio, string fechaFin)
        {
            return await _ventaRepository.ReporteVenta(fechaInicio, fechaFin);
        }
    }
}
