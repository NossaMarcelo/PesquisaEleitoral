using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    [Table("Candidato")]
    public class Candidato
    {
        [Key]
        public int CandidatoId { get; set; }
        public string CandidatoNome { get; set; }
        public int CandidatoNumero { get; set; }
    }
}