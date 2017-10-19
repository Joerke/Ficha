using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFicha.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string CursoNome { get; set; }
        public int ProfessorId { get; set; } // FK
        public Professor Professor { get; set; } // Propriedade de navegaçao
        public List<Estudante> Estudantes { get; set; } // Lista de Estudantes
    }
}