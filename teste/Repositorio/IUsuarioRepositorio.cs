using teste.Models;

namespace teste.Repositorio
{
    public interface IUsuarioRepositorio
    {
        LoginViewModel Validar(string email, string senha);
    }
}
