using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class EstudiantePariente
    {
        
        int IdEstudiante { get; set; }
        
        String IdParientes { get; set; }

        [ForeignKey("IdEstudiante")]
        public virtual Estudiantes Estudiantes { get; set; }
        [ForeignKey("IdParientes")]
        public virtual Parientes Parientes { get; set; }


        String TipoRelacion { get; set; }
    }
}
