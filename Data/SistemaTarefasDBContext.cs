using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.NovaPasta2
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options)
            : base(options)
        {

        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
