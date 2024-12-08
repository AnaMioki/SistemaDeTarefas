using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorio.NovaPasta
{
    public interface IUsuarioRepositorio
    {
        //contratos de usuario CRUD

        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
