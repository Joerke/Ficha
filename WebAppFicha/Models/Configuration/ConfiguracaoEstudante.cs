using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebAppFicha.Models.Configuration
{
    public class ConfiguracaoEstudante : EntityTypeConfiguration<Estudante>
    {
        public ConfiguracaoEstudante()
        {
            ToTable("TB.Estudante");

            HasMany(cur => cur.Cursos)
                .WithMany(estu => estu.Estudantes)
                .Map(ce =>
                {
                    ce.MapLeftKey("CodCursos");
                    ce.MapRightKey("CodEstudane");

                });
                


            Property(x => x.EstudanteNome)
                .HasColumnType("Varchar")
                .IsRequired();

            Property(x => x.DataDeNascimento)
                .HasColumnType("datetime2")
                .IsRequired();

            Property(x => x.Altura)
                .HasColumnType("Varchar")
                .IsRequired();

            Property(x => x.Peso)
                .HasColumnType("Varchar")
                .IsRequired();


        }
    }
}