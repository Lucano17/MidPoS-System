
namespace PoS_Service.Interfaces
{
    public interface ICorreoService
    {
        Task Enviar(string para, string asunto, string mensajeHtml);
    }
}
