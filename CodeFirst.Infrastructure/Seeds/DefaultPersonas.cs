using CodeFirst.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CodeFirst.Infrastructure.Seeds
{
    public static class DefaultPersonas
    {
        public static async Task SeedDefaultPersona(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().HasData(
                new Persona()
                {
                    PersonaId = 1,
                    NumeroDocumento = "76018789",
                    Nombres = "Erwing 01",
                    Apellidos = "Candelario Restrepo",
                    DepartamentoId = 1,
                    TipoDocumentoId = Domain.Enums.TipoDocumento.Cedula,
                },
                new Persona()
                {
                    PersonaId = 2,
                    NumeroDocumento = "76018789",
                    Nombres = "Erwing 02",
                    Apellidos = "Candelario Restrepo",
                    DepartamentoId = 2,
                    TipoDocumentoId = Domain.Enums.TipoDocumento.Cedula,
                },
                new Persona()
                {
                    PersonaId = 3,
                    NumeroDocumento = "76018789",
                    Nombres = "Erwing 03",
                    Apellidos = "Candelario Restrepo",
                    DepartamentoId = 3,
                    TipoDocumentoId = Domain.Enums.TipoDocumento.Cedula,
                },
                new Persona()
                {
                    PersonaId = 4,
                    NumeroDocumento = "76018789",
                    Nombres = "Erwing 04",
                    Apellidos = "Candelario Restrepo",
                    DepartamentoId = 4,
                    TipoDocumentoId = Domain.Enums.TipoDocumento.Cedula,
                },
                new Persona()
                {
                    PersonaId = 5,
                    NumeroDocumento = "76018789",
                    Nombres = "Erwing 05",
                    Apellidos = "Candelario Restrepo",
                    DepartamentoId = 5,
                    TipoDocumentoId = Domain.Enums.TipoDocumento.Cedula,
                }
            );
            await Task.FromResult(Task.CompletedTask).ConfigureAwait(false);
        }
    }
}
