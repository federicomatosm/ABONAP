using System;
using ABONAP.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace ABONAP.Models.Context
{
    public class AbonapContext : DbContext
    {
        public AbonapContext(DbContextOptions options) : base(options) { }

        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Departamento>? Departamentos { get; set; }
        public DbSet<Documento>? Documentos { get; set; }
        public DbSet<Empleado>? Empleados { get; set; }
        public DbSet<Empresa>? Empresas { get; set; }
        public DbSet<Persona>? Personas { get; set; }
        public DbSet<Prestamo>? Prestamos { get; set; }
        public DbSet<Sucursal>? Sucursales { get; set; }
        public DbSet<TipoDocumento>? TipoDocumentos { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<ModeloBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.FechaCreacion = DateTime.Now;
                        entry.Entity.FechaActualizacion = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.FechaActualizacion = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

