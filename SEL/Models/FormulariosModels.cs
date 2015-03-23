using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SEL.Models
{
    public class IniciarSesionViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage="Email inválido")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }

    public class CrearSolicitudViewModel
    {
        [Required]
        [Display(Name = "FechaServicio")]
        public string FechaServicio { get; set; }

        [Required]
        [Display(Name = "HoraServicio")]
        public string HoraServicio { get; set; }

        [Required]
        [Display(Name = "FechaCita")]
        public string FechaCita { get; set; }

        [Required]
        [Display(Name = "HoraCita")]
        public string HoraCita { get; set; }

        [Required]
        [Display(Name = "FechaRecojida")]
        public string FechaRecojida { get; set; }

        [Required]
        [Display(Name = "HoraRecogida")]
        public string HoraRecogida { get; set; }

        [Required]
        [Display(Name = "Origen")]
        public string Origen { get; set; }

        [Required]
        [Display(Name = "Destino")]
        public string Destino { get; set; }
    }
}