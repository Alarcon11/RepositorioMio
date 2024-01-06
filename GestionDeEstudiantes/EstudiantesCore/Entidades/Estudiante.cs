
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstudiantesCore.Entidades
{
    class Estudiante
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String  Apellido { get; set; }
        [Required]
        [MaxLength(20)]
        public String Documento   { get; set; }
        [Required]
        public DateTime FechaNacimiento  { get; set; }
        [Required]
        [MaxLength(1)]
        public String Sexo { get; set; }
        [Required]
        public String Direccion { get; set; }
        [Required]
        [MaxLength(20)]
        public String Telefono { get; set; }

        [MaxLength(50)]
        public String Email { get; set; }
        [Required]
        public DateTime FechaIngreso { get; set; }

        public DateTime FechaEgreso { get; set; }

        public DateTime Retiro { get; set; }

        [Required]
        public TipoDocumento TipoDocumento { get; set; }

        [Required]
        public EstadoEstudiante EstadoEstudiante { get; set; }
        

    }
}
