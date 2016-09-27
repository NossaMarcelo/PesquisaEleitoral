using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace PesquisaEleitoral.Models
{
    [Table("Candidato")]
    public class Candidato
    {
        [Key]
        public int CandidatoId { get; set; }
        [Required]
        
        public string CandidatoNome
        {
            get
            {
                if (string.IsNullOrEmpty(_nome))
                {
                    return _nome;
                }
                byte[] palavra = Encoding.GetEncoding("iso-8859-8").GetBytes(_nome);
                return Encoding.UTF8.GetString(palavra).Trim().ToUpper();
            }
            set
            {
                _nome = Regex.Replace(value, @"\s{2,}", " ");

                _nome = Regex.Replace(_nome, @"[^\w]+", "");
            }
        }
        private string _nome;
        [Required]
        [Range(10,99, ErrorMessage = "Número do candidato inválido.")]
        public int CandidatoNumero { get; set; }
    }
}