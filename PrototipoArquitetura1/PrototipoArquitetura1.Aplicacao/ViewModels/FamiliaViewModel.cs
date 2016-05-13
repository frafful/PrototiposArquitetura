using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Aplicacao.ViewModels
{
    public class FamiliaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage= "Preencha o campo nome")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        public string Codigo { get; set; }

        public bool Excluido { get; set; }

        public bool Trade { get; set; }

        public string CentroDeCusto { get; set; }

        public DateTime? DataDeAtualizacao { get; set; }

        public bool Promovido { get; set; }

        public DateTime DataDeCriacao { get; set; }

        public bool FamiliaConcorrente { get; set; }

        public DateTime? DataDeExclusao { get; set; }

        public string IdDescricao { get; set; }
    }
}
