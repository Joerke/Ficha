using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebAppFicha.Models.Configuration
{
    public class ConfiguracaoEndereco : EntityTypeConfiguration<Endereco>
    {

        public ConfiguracaoEndereco()
        {
            ToTable("TabelaEndereço");


            Property(x => x.Endereco1)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
 
            Property(x => x.Endereco2)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Cidade)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Cep)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Estado)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}