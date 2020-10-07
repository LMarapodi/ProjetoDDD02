using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.Models
{
    public class FornecedorEdicaoModel
    {
        [Required(ErrorMessage ="Por favor Informe o Id do Fornecedor.")]
        public string IdFornecedor { get; set; }

        [Required(ErrorMessage = "Por favor,Informe um nome.")]
        [MaxLength(150, ErrorMessage = "Informe no Maximo {1} Caracteres")]
        [MinLength(3, ErrorMessage = "Informe no Minimo {1} Caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor informe um Cnpj.")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$", ErrorMessage = "Por favor, informe um CNPJ válido.")]

        public string Cnpj { get; set; }
    }
}
