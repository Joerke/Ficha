using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFicha.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string ProfessorNome { get; set; }
        public string TipoProfessor { get; set; }
        public int NivelEnsinoId { get; set; } // FK
        public NivelEnsino NivelEnsino { get; set; } // Propriedade de Navegaçao
        public List<Curso> Cursos { get; set; } // Lista de Curso
    }
}