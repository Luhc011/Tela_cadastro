using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Cadastro.Model.Models
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public DateTime DataCriacao { get; set;}
        public DateTime AtualizaData { get; set;} = DateTime.Now;
    }
}
