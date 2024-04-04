using AutenticarconToken.Models.Custom;

namespace AutenticarconToken.Services
{
    public class IAutorizacionService
    {
        Task<AutorizacionResponse> DevolverToken(AutorizacionRequest autorizacion);
    }
}
