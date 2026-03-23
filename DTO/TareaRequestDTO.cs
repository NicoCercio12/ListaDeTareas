using System.ComponentModel.DataAnnotations;

namespace ListaDeTareas.DTO
{
    public class TareaRequestDTO
    {
        [Required]
        public string Titulo {  get; set; }
        [Required] 
        public string Descripcion { get; set; }
    }
}
