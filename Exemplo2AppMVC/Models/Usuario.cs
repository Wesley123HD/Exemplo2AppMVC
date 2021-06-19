using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Exemplo2AppMVC.Models
{
    public class Usuario
    {
        [Display(Name = "Codigo")]
        [Range(0,999, ErrorMessage = "Insira um peso entre 0 e 15kg")]
        [Required(ErrorMessage = "O campo código é obrigatório.")]
        public int Codigo { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Nome { get; set; }

        [Display(Name = "Descricao")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Insira de 5 a 100 caracteres")]
        public string Descricao { get; set; }

        [Display(Name = "Peso")]
        [Range(0, 15, ErrorMessage = "Insira um peso entre 0 e 15kg")]
        public int Peso { get; set; }

        [Display(Name = "Categoria")]
        [RegularExpression(@"[a-zA-Z]{3,20}", ErrorMessage = "Digite no mínimo 3 caracteres")]
        [Required(ErrorMessage = "O campo categoria é obrigatório")]
       
        public string Categoria { get; set; }

        [Display(Name = "ValorUnit")]
        [Required(ErrorMessage = "Digite um valor acima de R$0,00")]
        public decimal ValorUnit { get; set; }
    }
}