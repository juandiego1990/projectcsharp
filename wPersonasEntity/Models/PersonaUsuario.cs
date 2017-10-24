using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace wPersonasEntity.Models
{
    public class PersonaUsuario
    {
        [Key]
        public persona Persona { set; get; }
        public usuario Usuario { set; get; }
    }
}