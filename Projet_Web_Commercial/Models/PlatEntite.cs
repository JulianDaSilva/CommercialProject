using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Web_Commercial.Models
{
    public class PlatEntite
    {
        public int Id { get; set; } // Propriété automatique

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Nom { get; set; }

        public int Prix { get; set; }
        public int Poid { get; set; }

    }
}
