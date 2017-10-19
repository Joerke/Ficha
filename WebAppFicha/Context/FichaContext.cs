using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppFicha.Models;

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

            // aki esta mudando o nome da classe
            modelBuilder.Entity<Curso>().ToTable("TabelaCurso");
            modelBuilder.Entity<Endereco>().ToTable("TabelaEndereço");
            modelBuilder.Entity<Estudante>().ToTable("TabelaEstudante");
            modelBuilder.Entity<NivelEnsino>().ToTable("TabelaNivelEnsino");
            modelBuilder.Entity<Professor>().ToTable("TabaleProfessor");

            //aki esta colocando essas propriedades como NOT NULL (Obrigatorio)
            modelBuilder.Entity<Curso>().Property(x => x.CursoNome).IsRequired();
            modelBuilder.Entity<Professor>().Property(x => x.ProfessorNome).IsRequired();
            modelBuilder.Entity<Professor>().Property(x => x.TipoProfessor).IsRequired();
            modelBuilder.Entity<NivelEnsino>().Property(x => x.Descricao).IsRequired();
            modelBuilder.Entity<Estudante>().Property(x => x.EstudanteNome).IsRequired();
            modelBuilder.Entity<Estudante>().Property(x => x.DataDeNascimento).IsRequired();
            modelBuilder.Entity<Estudante>().Property(x => x.Altura).IsRequired();
            modelBuilder.Entity<Estudante>().Property(x => x.Peso).IsRequired();
            modelBuilder.Entity<Endereco>().Property(x => x.Endereco1).IsRequired();
            modelBuilder.Entity<Endereco>().Property(x => x.Endereco2).IsRequired();
            modelBuilder.Entity<Endereco>().Property(x => x.Cidade).IsRequired();
            modelBuilder.Entity<Endereco>().Property(x => x.Cep).IsRequired();
            modelBuilder.Entity<Endereco>().Property(x => x.Estado).IsRequired();








        }





    }
}