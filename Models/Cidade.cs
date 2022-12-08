using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace teste_.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Key]
        [Column("codigo")]
        public int Codigo { get; set; }

        [Column("nome")]
        [StringLength(50)]
        [Required]
        public string Nome { get; set; }
    }
}