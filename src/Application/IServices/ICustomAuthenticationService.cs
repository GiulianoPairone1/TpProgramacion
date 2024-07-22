using Application.Request;

namespace Application.IServices
{
    public  interface ICustomAuthenticationService
    {
        string Autenticacion(AuthenticationRequest authenticationRequest);
    }
}
