using BankApp.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Cada prop. DbSet<TipoDeUmaClasseModel> corresponde a uma tabela no nosso DB
        public DbSet<Cliente> Clientes { get; set; }  // Acessos à tabela de Clientes

        public DbSet<Conta> Contas { get; set; }      // Acessos à tabela de Contas

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }
    }
}
