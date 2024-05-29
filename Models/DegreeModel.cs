using System.ComponentModel.DataAnnotations;

namespace MyFirstProyectWithLineCommand.Models
{
    public class DegreeModel : BaseModel
    {
        public DegreeModel()
        {
        }
        
        [Required(ErrorMessage = "El (0) es un campo requerido")]
        public string Nombre { get; set; }
        
    }
}