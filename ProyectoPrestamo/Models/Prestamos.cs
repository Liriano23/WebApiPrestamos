using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ProyectoPrestamo.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
       
        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Required (ErrorMessage = "Debe ingresar el id de la persona")]
        public int PersonaID { get; set; }
        public Personas Personas { get; set; }

        [Required]
        public string Concepto { get; set; }

        [Required]
        public decimal Monto { get; set; }

        [Required]
        public decimal Balance { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            Fecha = DateTime.Now;
            PersonaID = 0;
            Concepto = string.Empty;
            Monto = 0;
            Balance = 0;
        }

    }
}
