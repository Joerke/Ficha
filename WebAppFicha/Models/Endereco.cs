using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppFicha.Models
{
    public class Endereco
    {
        // estudante assume a responsabilidade de PK e FK
        [ForeignKey("Estudante")]
        public int EnderecoId { get; set; }
        public string Endereco1 { get; set; }
        public string Endereco2 { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public int EstudanteId { get; set; }//FK
        public Estudante Estudante { get; set; } // Propriedade de Navegaçao
    }
}