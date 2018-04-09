using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTb01Lab1_Ighor_Moura.Models
{
    public class Automovel
    {
        public int AutomovelId { get; set; }
        [Required(ErrorMessage ="Tipo é obrigatorio")]
        public Tipo Tipo { get; set; }
        [Required(ErrorMessage ="Tipo é obrigatorio")]
        [StringLength(300, ErrorMessage ="Maximo 300 caracteres")]
        public String Descricao { get; set; }
        [Required(ErrorMessage ="Discricao obrigatoria")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public String Marca { get; set; }
        [Required(ErrorMessage ="Disponibilidade obrigatoria")]
        public bool Disponivel { get; set; }
        [Required(ErrorMessage ="Data de cadastro é obrigatoria")]
        public DateTime DataCadastro { get; set; }
    }
}
