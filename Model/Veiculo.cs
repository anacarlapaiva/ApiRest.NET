using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeiculosAPI.Model
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { get; set; }
        [Required]
        public String Descricao { get; set; }
        [Required]
        public int Ano { get; set; }
        [Required]
        public String Placa { get; set; }
        [Required]
        public String Modelo { get; set; }
        [Required]
        public String Marca { get; set; }
        [Required]
        public String Cor { get; set; }

    }
}
