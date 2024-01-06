using System;
using System.Collections.Generic;
using System.Text;

namespace EstudiantesCore.Entidades
{
    class ProfesorXMateria
    {
        public int Id { get; set; }

        public Materia Materia { get; set; }

        public Profesor Profesor { get; set; }
    }
}
