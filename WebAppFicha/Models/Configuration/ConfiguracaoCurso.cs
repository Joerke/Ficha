using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebAppFicha.Models.Configuration
{
    public class ConfiguracaoCurso : EntityTypeConfiguration<Curso>
    {
        public ConfiguracaoCurso()
        {
            ToTable("TabelaCurso");

            Property(x => x.CursoNome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}