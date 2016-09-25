using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    public class VotoViewModel
    {
        [Display(Name = "Candidato")]
        public int CandidatoID { get; set; }
    }
}