using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebAppFicha.Models.Configuration
{
    public class ConfiguracaoProfessor : EntityTypeConfiguration<Professor>
    {
        public ConfiguracaoProfessor()
        {
            ToTable("TB.Professor");


            HasMany(cur => cur.Cursos)
                .WithRequired(prof => prof.Professor)
                .HasForeignKey(prof => prof.ProfessorId)
                .WillCascadeOnDelete(false);


            Property(x => x.ProfessorNome)
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.TipoProfessor)
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();
               

        }

    }
}