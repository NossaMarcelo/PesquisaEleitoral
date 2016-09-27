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
    [Table("Bairro")]
    public class Bairro
    {
        [Key]
        public int BairroId { get; set; }
        [Required]
        //[RegularExpression(@"^[aA-zZ]+((\s[aA-zZ]+)+)?$", ErrorMessage = "Não é permitido o uso de acentos, caracteres especiais e espaços extras.")]
        public string BairroNome
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

                _nome = Regex.Replace(_nome, @"[^\w\s']+", "");
            }
        }
        private string _nome;
    }

}