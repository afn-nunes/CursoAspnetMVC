using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAspnetMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        [Range(1, 10, ErrorMessage ="Quantidade fora da faixa permitida")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "O campo categoria é obrigatório")]
        public Categoria Categoria { get; set; }

    }
}
