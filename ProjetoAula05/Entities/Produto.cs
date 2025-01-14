﻿using ProjetoAula05.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Entities
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set;}
        public decimal Preco { get; set; }
        public StatusProduto Status { get; set; } 
    }
}
