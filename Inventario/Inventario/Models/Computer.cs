using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Computer
    {
        [Display(Name = "Identificação do Computador")]
        public string ComputerId { get; set; }
        
        [Required(ErrorMessage = "O hostname deve ser informado")]
        [Display(Name = "Hostname")]
        public string Hostname { get; set; }

        [Required]
        public string Local { get; set; }

        [Required]
        [Display(Name = "IP")]
        public string Ip { get; set; }

        [Required]
        [Display(Name = "Mac-Address")]
        public string Mac { get; set; }
    }
}
