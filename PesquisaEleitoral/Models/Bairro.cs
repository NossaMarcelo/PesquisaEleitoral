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
        [RegularExpression(@"^[aA-zZ]+((\s[aA-zZ]+)+)?$", ErrorMessage = "Não é permitido o uso de acentos, caracteres especiais e espaços extras.")]
        public string BairroNome
        {
            get
            {

                return this._nome;
            }
            set
            {
                this._nome = value.Trim().ToUpper();
            }
        }
        private string _nome;



    }
}