using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFicha.Models
{
    public class Estudante
    {
        public int EstudanteId { get; set; }
        public string EstudanteNome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }

        public int NivelEnsinoId { get; set; } // FK
        public NivelEnsino NivelEnsino { get; set; } // Propriedade de navegaçao
        public List<Curso> Cursos { get; set; } // Lista de Cursos
        public Endereco Endereco { get; set; }
    }
}