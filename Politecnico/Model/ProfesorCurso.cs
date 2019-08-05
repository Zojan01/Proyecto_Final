using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class ProfesorCurso
    {
        
        int IdCurso { get; set; }
        
        int IdProfesor { get; set; }

        [ForeignKey("IdCurso")]
        public virtual Cursos Cursos { get; set; }
        [ForeignKey("IdProfesor")]
        public virtual Profesores Profesores { get; set; }

    }
}
