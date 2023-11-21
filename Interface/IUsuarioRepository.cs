using FiapStore.Entity;

namespace FiapStore.Interface
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario ObterComPedidos(int id);
    }
}
