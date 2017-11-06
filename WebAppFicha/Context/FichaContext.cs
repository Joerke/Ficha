using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebAppFicha.Models;
using WebAppFicha.Models.Configuration;

namespace WebAppFicha.Context
{
    public class FichaContext : DbContext
    {
        //metodo Contrutor
        public FichaContext() : base("name=strFicha")
        {
                
        }

        // mapear as classes
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<NivelEnsino> NivelEnsinos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ConfiguracaoNivelEnsino());
            modelBuilder.Configurations.Add(new ConfiguracaoProfessor());
            modelBuilder.Configurations.Add(new ConfiguracaoEstudante());
            modelBuilder.Configurations.Add(new ConfiguracaoCurso());




        }





    }
}