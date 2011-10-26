using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcScallfolding.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}