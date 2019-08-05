using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace Persistence
{
    public class ProjectDbContext : DbContext
    {
        
        public DbSet<Cursos> Curso { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Parientes> Parientes { get; set; }


        //relaciones
        public DbSet<ProfesorCurso> ProfesorCursos { get; set; }
        public DbSet<EstudianteCurso> estudianteCursos { get; set; }
        public DbSet<EstudiantePariente> estudianteParientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ;
        }

    }
}
