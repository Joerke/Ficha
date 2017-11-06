using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebAppFicha.Models.Configuration
{
    public class ConfiguracaoNivelEnsino  : EntityTypeConfiguration<NivelEnsino>
    {

        public ConfiguracaoNivelEnsino()
        {
            ToTable("TB.NivelEnsino");


            HasMany(pro => pro.Professores)
                .WithRequired(Niv => Niv.NivelEnsino)
                .HasForeignKey(Niv => Niv.NivelEnsinoId)
                .WillCascadeOnDelete(false);

            HasMany( est => est.Estudantes)
                .WithRequired(Niv => Niv.NivelEnsino)
                .HasForeignKey(Niv => Niv.NivelEnsinoId)
                .WillCascadeOnDelete(false);


            Property(niv => niv.Descricao)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(300);

                

        }
    }
}