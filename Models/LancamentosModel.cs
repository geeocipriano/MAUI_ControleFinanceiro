using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_ControleFinanceiro.Models
{
    public class LancamentosModel
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }
        public Color CorFundo { get; set; }
    }
}
