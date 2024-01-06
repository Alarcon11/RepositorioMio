using EstudiantesCore.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestionDeEstudiantes.Pages
{
    public class EstudiantesModel : PageModel
    {
        public void OnGet()
        {
        }
        [HttpPost]
        public IActionResult OnPostCrearEstudiante(EstudiantesDTO estudiante )
        {
            try
            {
                return StatusCode(200,"todo quedo bien");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
    }
}
