using System;
using System.Collections.Generic;
using System.Text;

namespace EstudiantesCore.Entidades
{
    class EstudiantesXMateria
    {
        public int Id { get; set; }

        public Estudiante Estudiante { get; set; }

        public Materia Materia { get; set; }


        public EstadoMateriaEstudiante EstadoMateriaEstudiante { get; set; }
    }
}
