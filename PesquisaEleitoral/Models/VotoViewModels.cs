using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    public class VotoViewModels
    {
            [Display(Name = "Candidato Numero")]
            [Range(10, 99, ErrorMessage = "Número inválido.")]
            public int CandidatoNumero { get; set; }

    }
}