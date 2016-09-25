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
        [Required]
        [RegularExpression(@"^[aA-zZ]+((\s[aA-zZ]+)+)?$", ErrorMessage = "Não é permitido o uso de acentos, caracteres especiais e espaços extras.")]
        public string CandidatoNome { get; set; }
        [Required]
        [Range(10,99, ErrorMessage = "Número do candidato inválido.")]
        public int CandidatoNumero { get; set; }
    }
}