using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArmazenamentoDeImagens.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        public string Nome { get; set; }

        public byte[] Foto { get; set; }
    }
}
