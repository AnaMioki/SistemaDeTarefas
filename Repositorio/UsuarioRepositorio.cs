using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.NovaPasta2;
using SistemaDeTarefas.Repositorio.NovaPasta;

namespace SistemaDeTarefas.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefasDBContext _dbContext;
        public UsuarioRepositorio(SistemaTarefasDBContext sistemaTarefasDBContext)
        {
            _dbContext = sistemaTarefasDBContext;
        }
        async Task<UsuarioModel> IUsuarioRepositorio.BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }
        async Task<List<UsuarioModel>> IUsuarioRepositorio.BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }
        async Task<UsuarioModel> IUsuarioRepositorio.Adicionar(UsuarioModel usuario)
        {
             await _dbContext.Usuarios.AddAsync(usuario);
            _dbContext.SaveChanges();

            return usuario;
        }

        async Task<UsuarioModel> IUsuarioRepositorio.Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário por ID : {id} não foi encontrado.");
            }

            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;

            _dbContext.Usuarios.ExecuteUpdateAsync();
            _dbContext.SaveChanges();

            return usuarioPorId;
        }

        async Task<bool> IUsuarioRepositorio.Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário por ID : {id} não foi encontrado no banco de dados.");
            }
            _dbContext.Usuarios.Remove(usuarioPorId);
            _dbContext.SaveChanges();
            return true;
        }

        
    }
}
