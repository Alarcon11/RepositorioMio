using System;
using System.Collections.Generic;
using System.Text;

namespace EstudiantesCore.Entidades
{
    class Profesor
    {
        public int Id { get; set; }

        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public TipoDocumento TipoDocumento { get; set; }

        public EstadoProfesor EstadoProfesor { get; set; }
    }
}
