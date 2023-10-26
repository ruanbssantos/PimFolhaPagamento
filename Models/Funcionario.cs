using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PimFolhaPagamento.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [Display(Name = "Nome do usuário.")]
        [StringLength(10, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Cargo é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo Cargo deve ter no máximo 50 caracteres.")]
        public string Cargo { get; set; }
    }
}