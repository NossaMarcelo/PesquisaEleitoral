using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    [Table("Bairro")]
    public class Bairro
    {
        [Key]
        public int BairroId { get; set; }
        [Required]
        public string BairroNome
        {
            get
            {
                return BairroNome.ToUpper();
            }
            set
            {
                BairroNome = value.ToUpper();
            }
        }
    }
}